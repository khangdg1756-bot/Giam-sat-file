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
        Socket sckClient;
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
            int size = sckClient.EndReceive(ar);
            //Xu ly du lieu trong buffer data
            string s = Encoding.ASCII.GetString(data, 0, size);
            //chen s vao trong textbox noi dung chat
            txtLog.Invoke(new CapNhatGUI(CapNhatNoiDungChat), new Object[] { "Server: " + s });
            //Tiep tuc cho nhan du lieu
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(Xulydulieunhanduoc), null);
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
    }
}
