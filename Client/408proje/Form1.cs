using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _408proje
{
    public partial class Form1 : Form
    {
        bool terminating = false;
        bool connected = false;
        bool spsconnected = false;
        bool ifconnected = false;
        string spsName = "", ifName = "";


        Socket socket;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IP = textIP.Text;

            if (socket != null && socket.Connected)
            {
                string message = !ifconnected ? "SUBSCRIBE//IF100//" + ifName : "UNSUBSCRIBE//IF100//" + ifName;
                byte[] messageBytes = Encoding.Default.GetBytes(message);
                socket.Send(messageBytes);
                ifconnected = !ifconnected;
                buttonIF.Text = ifconnected ? "Unsubscribe IF100" : "Subscribe IF100";
                buttonIF.ForeColor = ifconnected ? Color.Red : Color.Green;
                buttonSendIF100.Enabled = ifconnected;
                if (ifconnected)    textCOnnectionList.AppendText("IF100\n");   else removeString("IF100\n");
            }
        }



        private void buttonSPS_Click(object sender, EventArgs e)
        {
            string IP = textIP.Text;

            if (connected)
            {
                string message_content = !spsconnected ? "SUBSCRIBE//SPS101//" + spsName : "UNSUBSCRIBE//SPS101//" + spsName;
                byte[] message = Encoding.Default.GetBytes(message_content);
                socket.Send(message);
                spsconnected = !spsconnected;
                buttonSPS.Text = spsconnected ? "Unsubscribe SPS101" : "Subscribe SPS101";
                buttonSPS.ForeColor = spsconnected ? Color.Red : Color.Green;
                buttonSendSps101.Enabled = spsconnected;
                if (spsconnected) textCOnnectionList.AppendText("SPS101\n"); else removeString("SPS101\n");
            }
        }



        private void removeString(string input)
        {
            int index = textCOnnectionList.Text.IndexOf(input);
            if (index != -1)
            {
                textCOnnectionList.Text = textCOnnectionList.Text.Remove(index, input.Length);
            }
        }


        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            terminating = true;
            spsconnected = false;
            ifconnected = false;

            if (socket != null && socket.Connected)
            {
                socket.Close();
            }

            Environment.Exit(0);
        }


        private void disableLogin()
        {
            textName.Enabled = false;
            textIP.Enabled = false;
            textPort.Enabled = false;
        }

        private void textCOnnectionList_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textINPUTsps101_TextChanged(object sender, EventArgs e)
        {

        }

        private void textINPUTif100_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSendSps101_TextChanged(object sender, EventArgs e)
        {
            textSendSps101.ForeColor = Color.Black;
        }

        private void buttonSendSps101_Click(object sender, EventArgs e)
        {
            string userName = spsName;
            string message = textSendSps101.Text;

            if (textSendSps101.Text != "" && message.Length <= 128)
            {
                textINPUTsps101.AppendText(userName + ": " + textSendSps101.Text + "\n");
                Byte[] buffer = Encoding.Default.GetBytes("Client " + userName + " to Channel SPS101: " + message);
                socket.Send(buffer);
                textSendSps101.Clear();
            }
            else if (message.Length > 128)
            {
                textSendSps101.ForeColor = Color.Red;
                textINPUTsps101.AppendText("Message is too long\n");
            }
        }

        private void buttonSendIF100_Click(object sender, EventArgs e)
        {
            string userName = ifName;
            string message = textSendIF.Text;

            if (textSendIF.Text != "" && message.Length <= 128)
            {
                textINPUTif100.AppendText(userName + ": " + textSendIF.Text + "\n");
                Byte[] buffer = Encoding.Default.GetBytes("Client " + userName + " to Channel IF100: " + message);
                socket.Send(buffer);
                textSendIF.Clear();
            }
            else if (message.Length > 128)
            {
                textSendIF.ForeColor = Color.Red;
                textINPUTif100.AppendText("Message is too long\n");
            }
        }

        private void textSendIF_TextChanged(object sender, EventArgs e)
        {
            textSendIF.ForeColor = Color.Black;
        }

        private void textPort_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReceiveSps()
        {
            while (spsconnected)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    int received = socket.Receive(buffer);
                    if (received > 0)
                    {
                        string incomingMessage = Encoding.Default.GetString(buffer);
                        incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                        textINPUTsps101.AppendText(incomingMessage + "\n");
                    }
                    else
                    {
                        throw new SocketException();
                    }
                }
                catch (SocketException)
                {
                    if (socket != null)
                    {
                        socket.Close();
                    }
                    spsconnected = false;

                    DisconnectFromServer();
                }
            }
        }

        private void ReceiveIf()
        {
            while (ifconnected)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    int received = socket.Receive(buffer);

                    if (received > 0)
                    {
                        string incomingMessage = Encoding.Default.GetString(buffer);
                        incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                        textINPUTif100.AppendText("Server: " + incomingMessage + "\n");
                    }
                    else
                    {
                        throw new SocketException();
                    }
                }
                catch (SocketException)
                {
                    if (socket != null)
                    {
                        socket.Close();
                    }
                    ifconnected = false;

                    DisconnectFromServer();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IP = textIP.Text;
            int portNum;

            if (!connected)
            {
                if (Int32.TryParse(textPort.Text, out portNum))
                {
                    try
                    {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socket.Connect(IP, portNum);
                        connected = true;
                        spsName = textName.Text;
                        ifName = textName.Text;

                        string connectionStatus = connected ? "connected to" : "disconnected from";
                        string clientMessage = $"{spsName} has {connectionStatus} the server.";
                        socket.Send(Encoding.Default.GetBytes("//" + clientMessage));

                        UpdateUIOnConnection();
                    }
                    catch
                    {
                        textINPUTsps101.AppendText("Could not connect to the server!\n");   textINPUTif100.AppendText("Could not connect to the server!\n");
                    }
                }
                else
                {
                    textINPUTsps101.AppendText("Check the port\n"); textINPUTif100.AppendText("Check the port\n");
                }
            }
            else
            {
                DisconnectFromServer();
            }
        }

        private void UpdateUIOnConnection()
        {
            button1.Text = connected ? "Disconnect" : "Connect";
            button1.ForeColor = connected ? Color.Red : Color.Green;
            textName.Enabled = !connected;
            textIP.Enabled = !connected;
            textPort.Enabled = !connected;
            buttonSPS.Enabled = connected;
            buttonIF.Enabled = connected;
        }

        private void DisconnectFromServer()
        {
            if (socket != null && socket.Connected)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            disconnectUI();

            UpdateUIOnConnection();
        }


        void disconnectUI()
        {
            textCOnnectionList.Clear();
            connected = false;
            spsconnected = false;
            ifconnected = false;
            buttonSPS.Text = "Subscribe SPS101";
            buttonSPS.ForeColor = Color.Green;
            buttonIF.Text = "Subscribe IF100";
            buttonIF.ForeColor = Color.Green;
        }

        public void StartReceiving()
        {
            if (spsconnected)
            {
                Thread receiveSpsThread = new Thread(ReceiveSps);
                receiveSpsThread.Start();
            }

            if (ifconnected)
            {
                Thread receiveIfThread = new Thread(ReceiveIf);
                receiveIfThread.Start();
            }
        }


    }
}
