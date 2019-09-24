using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        string machine_name;
        string first_name;
        string last_name;
        bool connected = false;
        readonly string serverText = "10.255.2.140";
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        public Form1()
        {
            InitializeComponent();
            machine_name = Environment.MachineName;
            LogInTroughDB();
            ConnectToChat();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if(connected == true) { 
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msgText.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            msgText.Text = "";
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            ConnectToChat();
        }


        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if(connected == true)
            {
                connected = false;
                using (TcpClient tcpClient = new TcpClient())
                {
                    tcpClient.Close();
                }
            }
            else
            {
                MessageBox.Show("You are not connected to a server!", "Not connected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void getMessage()
        {
            while (true && connected == true)
            {
                if (connected && FormWindowState.Minimized == this.WindowState)
                {
                this.WindowState = FormWindowState.Normal;
                    System.Media.SystemSounds.Asterisk.Play();
                    GetMessage();
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        System.Media.SystemSounds.Asterisk.Play();
                        GetMessage();
                    }
                    else
                        GetMessage();
                }
             }
        }

        private void msg()
        {
            string vrijeme;
            vrijeme = DateTime.Now.ToShortTimeString();
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                msgsText.Text = msgsText.Text + Environment.NewLine + "[" + vrijeme + "]" + " - " + readData;
        }

        private void MsgText_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && connected == true)
            {
                e.SuppressKeyPress = true;
                if (msgText.Text != ""){ 
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msgText.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                msgText.Text = "";
                }
                else
                {
                    MessageBox.Show("Message is null!", "No message!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MsgsText_TextChanged(object sender, EventArgs e)
        {
            msgsText.SelectionStart = msgsText.Text.Length;
            msgsText.ScrollToCaret();
        }

        public void GetMessage()
        {
            serverStream = clientSocket.GetStream();
            int buffSize = 0;
            byte[] inStream = new byte[10025];
            buffSize = clientSocket.ReceiveBufferSize;
            serverStream.Read(inStream, 0, buffSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            readData = "" + returndata;
            msg();
        }
        public void LogInTroughDB()
        {
            string serverName = "10.255.2.140\\C025A2890\\LOCALDB,1433";
            string userID = "smarjanov";
            string password = "Vr4Rkmu5";
            string connetionString = null;
            connetionString = @"Server=" + serverName + ";Initial Catalog=master;User ID=" + userID + ";Password=" + password;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!");
            }

            string sqlquery = ("SELECT * FROM dbo.Users WHERE (machine_name ='"+machine_name+"')"); ;
            SqlCommand command = new SqlCommand(sqlquery, cnn);
            SqlDataReader sReader = command.ExecuteReader();
            while(sReader.Read()) { 
            first_name = sReader["first_name"].ToString(); 
            last_name = sReader["last_name"].ToString();
            userNameText.Text = first_name + " " + last_name;
            }
        }

        void ConnectToChat()
        {
            if (connected != true)
            {
                    readData = "Connected to RWE IT chat!";
                    msg();
                    clientSocket.Connect("10.255.2.140", 8888);
                    serverStream = clientSocket.GetStream();

                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes(userNameText.Text + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();

                    Thread ctThread = new Thread(getMessage);
                    ctThread.Start();
                    connected = true;            
            }
            else
            {
                MessageBox.Show("You are already connected to: " + serverText, "Already connected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
