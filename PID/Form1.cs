using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PID
{
    public partial class Form1 : Form
    {
        String strIp = String.Empty;
        int intPort = 7000;
        bool booServer = false;
        TcpListener listen;
        Thread mainTh = null;
        byte[] buff = new byte[1024];
        TcpClient tcl;
        NetworkStream stream;

        private StringBuilder _Strings;
        private String Logs
        {
            set
            {
                if (_Strings == null)
                    _Strings = new StringBuilder(1500);
                if (_Strings.Length >= (1500 - value.Length))
                    _Strings.Clear();
                _Strings.AppendLine(value);
                tbContent.Text = _Strings.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(!booServer)
            {
                serverOpen();
            }
            else
            {
                serverClose();
            }
        }

        void serverOpen()
        {
            try
            {
                mainTh = new Thread(new ThreadStart(Running));
                mainTh.Start();
                booServer = true;
            }catch(Exception exe)
            {
                Logs = String.Format("System Error = {0}", exe.Message);

                booServer = false;
                return;
            }
        }

        void serverClose()
        {
            try
            {
                if (tcl != null) tcl.Close();
                if (stream != null) stream.Close();

                listen.Stop();
                mainTh.Abort();

                this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("Server Closed");
                        btnConnect.Text = "연결";
                        booServer = false;
                    }));
            }
            catch(Exception exe)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    Logs = String.Format("Server Closed Error = {0}", exe.Message);
                }));
            }
        }

        void Running()
        {
            try
            {
                strIp = tbIp.Text;
                intPort = Int32.Parse(tbPort.Text);
                listen = new TcpListener(IPAddress.Parse(strIp), intPort);
                listen.Start();

                this.Invoke(new MethodInvoker(delegate ()
                {
                    Logs = String.Format("Server Open");
                    btnConnect.Text = "Stop";
                }));
            }catch(Exception exe)
            {
                this.Invoke(new MethodInvoker(delegate ()
                    {
                    Logs = String.Format("Server Error = {0}", exe.Message);
                    btnConnect.Text = "Start";
                    }));

                booServer = false;
                return;
            }

            while (booServer == true)
            {
                try
                {
                    tcl = listen.AcceptTcpClient();
                    stream = tcl.GetStream();
                }
                catch
                {

                }
                int intLength = 0;
                while((intLength = stream.Read(buff, 0, buff.Length)) > 0)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("Receive Data = {0} Byte", buff.Length);
                        Logs = String.Format("Content");
                    }));

                    String strData = byteToString(buff);

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        Logs = String.Format("{0}", strData);
                    }));
                };
            }
        }

        String byteToString(byte[] strByte)
        {
            string str = Encoding.Default.GetString(strByte);
            return str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _Strings.Clear();
            tbContent.Text = _Strings.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    tbIp.Text = host.AddressList[i].ToString();
                    break;
                }
            }
            tbPort.Text = intPort.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverClose();
        }
    }
}
