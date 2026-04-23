using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //==============Client=============
        //khoi tao
        Socket sckClient;
        FileSystemWatcher watcher;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //tao socket
            sckClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Connect
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(txtIP.Text), (int)numPort.Value);
            sckClient.BeginConnect(ep, new AsyncCallback(OnConnected), null);
            //Goi ham bat dong bo
        }
        byte[] data = new byte[1024];
        private void OnConnected(IAsyncResult ar)
        {
            sckClient.EndConnect(ar);
            // den day ca ket noi duoc client va server
            // Cap nhat trang thai va nhan du lieu
            lblStatus.Invoke(new CapNhatGUI(CapNhatTrangThai), new Object[] { "Connected Successfully!" });
            //Bat dau nhan du lieu
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(Xulydulieunhanduoc), null);
        }

        private void Xulydulieunhanduoc(IAsyncResult ar)
        {
            try
            {
                int size = sckClient.EndReceive(ar);
                //Xu ly du lieu trong buffer data
                string s = Encoding.ASCII.GetString(data, 0, size);
                //Điều kiện nếu server gửi lệnh yêu cầu
                if (s.StartsWith("START|"))
                {
                    string[] parts = s.Split('|'); // tách chuỗi
                    string folderPath = parts[1]; // lấy ký tự 2 trong mảng có dạng D:\Download
                    string filter = parts[2]; // lấy ký tự 3 trong mảng có dạng .txt
                    //cap nhat giao dien txtFolder va txtFilter
                    txtFolder.Invoke(new CapNhatTextBox(CapNhatNoidungTextBox), new Object[] { folderPath, filter });
                    StartMonitoring(folderPath, filter); //gọi hàm giám sát
                }
                else
                {
                    //chen s vao trong textbox noi dung chat
                    txtLog.Invoke(new CapNhatGUI(CapNhatNoiDungChat), new Object[] { "Server: " + s });
                }
                //Tiep tuc cho nhan du lieu
                sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(Xulydulieunhanduoc), null);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi nạp file: " + ex.Message); }
        }
        string[] filtersAr;
        private void StartMonitoring(string folderPath, string filter)
        {
            filtersAr = filter.ToLower().Split(',');

            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
            }
            //tạo filesystemwatcher
            watcher = new FileSystemWatcher(); // đã khai bao bên ngoài
            watcher.Path = folderPath;
            //watcher cho tất cả các file
            watcher.Filter = "*.*";
            //Đăng ký event
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            //Bat dau watching
            watcher.EnableRaisingEvents = true;

            //Hiện thị lên giao diện client
            lblStatus.Invoke(new CapNhatGUI(CapNhatTrangThai), new Object[] { "Dang giam sat..." });
            txtFolder.Invoke(new CapNhatGUI(CapNhatNoiDungChat), new Object[] { "Dang giam sat: " + folderPath });
        }

        //Hàm xử lý sự kiện đổi tên,..
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            // lay duoi file vua thay doi .txt
            string fileLast = Path.GetExtension(e.FullPath).ToLower();
            if (filtersAr.Contains(fileLast))
            {
                // lay thoi gian thuc
                string realTime = DateTime.Now.ToString("dd/MM/yyyy,HH:mm:ss");
                //Tạp chuỗi thông báo để gửi cho server
                string msgLog = $"{realTime}|RENAMED|{e.OldFullPath} to {e.FullPath}";
                //Send cho server thông báo
                //byte[] 
                byte[] sendData = Encoding.ASCII.GetBytes(msgLog);
                sckClient.Send(sendData);
                //Hiện thị lên giao diện log client
                txtLog.Invoke(new CapNhatGUI(CapNhatNoiDungChat), new Object[] { "Sent to the server: " + msgLog });
            }
        }


        //Hàm xử lý sự kiện tạo,xoá,sửa,..
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // lay duoi file vua thay doi .txt
            string fileLast = Path.GetExtension(e.FullPath).ToLower();
            if (filtersAr.Contains(fileLast))
            {
                // lay thoi gian thuc
                string realTime = DateTime.Now.ToString("dd/MM/yyyy|HH:mm:ss");
                //Tạo chuỗi thông báo để gửi cho server
                string msgLog = $"{realTime}|{e.ChangeType.ToString().ToUpper()}|{e.FullPath}";
                //Send cho server thông báo
                //byte[] 
                byte[] sendData = Encoding.ASCII.GetBytes(msgLog);
                sckClient.Send(sendData);
                //Hiện thị lên giao diện log client
                txtLog.Invoke(new CapNhatGUI(CapNhatNoiDungChat), new Object[] { "Sent to the server: " + msgLog });
            }
        }

        delegate void CapNhatTextBox(string path, string filter);
        void CapNhatNoidungTextBox(string path, string filter)
        {
            txtFolder.Text = path;
            txtFilter.Text = filter;
        }

        private void CapNhatNoiDungChat(string s)
        {
            txtLog.Text += s + "\r\n";
        }

        delegate void CapNhatGUI(string s);
        void CapNhatTrangThai(string s)
        {
            lblStatus.Text = s;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sckClient.Send(Encoding.ASCII.GetBytes(txtMessage.Text));
            CapNhatNoiDungChat("Client: " + txtMessage.Text);
            txtMessage.Text = ""; //xoa noi dung cua txtbox
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá log không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtLog.Clear();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (sckClient != null) sckClient.Close();
            btnConnect.Enabled = true; btnDisconnect.Enabled = false;
        }
    }
}
