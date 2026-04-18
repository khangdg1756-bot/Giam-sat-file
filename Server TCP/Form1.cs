using System.Net;
using System.Net.Sockets;
using System.Text;

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


        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            int size = sckClient.EndReceive(ar);
            // Xu ly du lieu trong Buffer data
            string s = Encoding.ASCII.GetString(data, 0, size);
            // Chen S vao Listbox
            rtbLog.Invoke(new CapnhatGUI(CapNhatListbox), new object[] { "Client: " + s });
            // Tiep tuc nhan du lieu tu client
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);



        }

        delegate void CapnhatGUI(string s);
        void CapNhatTrangthai(string s)
        {
            lblStatus.Text = s;
        }
        void CapNhatListbox(string s)
        {
            rtbLog.Text += s + "\r\n";


        }



    }
}


