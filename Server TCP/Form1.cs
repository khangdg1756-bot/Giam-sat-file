using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace Server_TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Khai bao 2 Socket
        Socket sckServer;
        Socket sckClient;
        private void btnStartserver_Click(object sender, EventArgs e)
        {
            // Tao Socket
            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Bind, Listen, Accept
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, (int)numPort.Value);
            sckServer.Bind(ep);
            sckServer.Listen(5);
            // Accept
            sckServer.BeginAccept(new AsyncCallback(AcceptCallback), null);
            // Cap nhat trang thai dang ket noi
            CapNhatTrangthai("Waiting for client...");

        }
        byte[] data = new byte[1024];
        private void AcceptCallback(IAsyncResult ar)
        {
            sckClient = sckServer.EndAccept(ar);
            // Cap nhat trang thai
            lblStatus.Invoke(new CapnhatGUI(CapNhatTrangthai), new object[] { "Client Connected!" });
            // Nhan du lieu tu client
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
            // Cap nhat thong tin client
            IPEndPoint clientEndPoint = (IPEndPoint)sckClient.RemoteEndPoint;
            string clientIP = clientEndPoint.Address.ToString();

            lblClientInfo.Invoke(new CapnhatGUI(CapNhatClientInfo), new object[] { "Client: " + clientIP });

        }
        // Ham lay filter tu cac checkbox
        string GetFilter()
        {
            List<string> filters = new List<string>();

            if (chkTxt.Checked) filters.Add(".txt");
            if (chkDocx.Checked) filters.Add(".docx");
            if (chkPdf.Checked) filters.Add(".pdf");
            if (chkExe.Checked) filters.Add(".exe");
            if (chkJpg.Checked) filters.Add(".jpg");
            if (chkPng.Checked) filters.Add(".png");

            return string.Join(",", filters);
        }
        // Ham them log vao RichTextBox
        void AddLog(string action, string path, string time)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy,HH:mm:ss");
            string log = $"{date},{time}|{action}|{path}\n";
            rtbLog.AppendText(log);
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                int size = sckClient.EndReceive(ar);
                // Xu ly du lieu trong Buffer data
                string s = Encoding.ASCII.GetString(data, 0, size);
                // Chen S vao Listbox
                // rtbLog.Invoke(new CapnhatGUI(CapNhatListbox), new object[] { "Client: " + s });
                // Tach s thanh 3 phan: action, path, time
                string[] parts = s.Split('|');

                if (parts.Length == 4 && parts[1] != "RENAMED")
                {
                    // CREATE / DELETE / CHANGED
                    string date = parts[0];
                    string time = parts[1];
                    string action = parts[2];
                    string path = parts[3];

                    rtbLog.Invoke(new Action(() =>
                    {
                        string log = $"Client: {date},{time}|{action}|{path}\n";
                        rtbLog.AppendText(log);
                    }));
                }
                else if (parts.Length >= 3 && parts[1] == "RENAMED")
                {
                    // RENAMED giữ nguyên
                    rtbLog.Invoke(new Action(() =>
                    {
                        rtbLog.AppendText("Client: " + s + "\n");
                    }));
                }


                // Tiep tuc nhan du lieu tu client
                sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);



            }
            catch (Exception ex)
            {
                lblStatus.Invoke(new CapnhatGUI(CapNhatTrangthai), new object[] { "Client disconnected!" });
                rtbLog.Invoke(new CapnhatGUI(CapNhatListbox), new object[] { "Client disconnected!" });
            }
        }
        // Cap nhat giao dien tu thread khac
        delegate void CapnhatGUI(string s);
        void CapNhatTrangthai(string s)
        {
            lblStatus.Text = s;
        }
        // Cap nhat Listbox tu thread khac
        void CapNhatListbox(string s)
        {
            rtbLog.Text += s + "\r\n";


        }
        // Cap nhat thong tin client tu thread khac
        void CapNhatClientInfo(string s)
        {
            lblClientInfo.Text = s;
        }

        // Ham stop server
        private void btnStopserver_Click(object sender, EventArgs e)
        {
            if (sckClient != null) sckClient.Close();
            if (sckServer != null) sckServer.Close();

            lblStatus.Text = "Server stopped";

        }

        // Ham Browse folder
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = fbd.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (sckClient == null)
            {
                MessageBox.Show("Don't have client!");
                return;
            }

            string folder = txtFolderPath.Text;
            string filter = GetFilter();

            string msg = $"START|{folder}|{filter}";

            byte[] dataSend = Encoding.ASCII.GetBytes(msg);
            sckClient.Send(dataSend);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (sckClient != null)
            {
                byte[] dataSend = Encoding.ASCII.GetBytes("STOP");
                sckClient.Send(dataSend);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt|CSV file (*.csv)|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, rtbLog.Text);
                MessageBox.Show("Saved log!");
            }
        }
    }
}



