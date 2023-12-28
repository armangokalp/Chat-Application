using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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


        Socket spsSocket;
        Socket ifSocket;
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IP = textIP.Text;
            int portNum;

            if (!ifconnected)
            {
                if (Int32.TryParse(textPort.Text, out portNum))
                {
                    try
                    {
                        ifSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        ifSocket.Connect(IP, portNum);

                        ifconnected = true;

                        textINPUTif100.AppendText("Connected to IF100 channel as " + textName.Text + "!\n");
                        disableLogin();
                        buttonIF.ForeColor = Color.Green;
                        buttonSendIF100.Enabled = true;
                        textCOnnectionList.AppendText("IF100\n");

                        Thread receiveIfThread = new Thread(ReceiveIf);
                        receiveIfThread.Start();
                        ifName = textName.Text;
                        byte[] nameBuffer = Encoding.Default.GetBytes("IFF//" + ifName);
                        ifSocket.Send(nameBuffer);
                    }
                    catch
                    {
                        textINPUTif100.AppendText("Could not connect to the server!\n");
                        ifSocket = null;
                    }
                }
                else
                {
                    textINPUTif100.AppendText("Check the port\n");
                }
            }
            else
            {
                try
                {
                    if (ifSocket != null && ifSocket.Connected)
                    {
                        byte[] disconnectMessage = Encoding.Default.GetBytes("Client " + textName.Text + " is disconnected from IF100.");
                        ifSocket.Send(disconnectMessage);

                        ifSocket.Shutdown(SocketShutdown.Both);
                        ifSocket.Close();
                        textINPUTif100.AppendText("Disconnected from the IF100 Channel!\n");
                    }
                    else
                    {
                        textINPUTif100.AppendText("Socket is not connected.\n");
                    }
                }
                catch (Exception ex)
                {
                    textINPUTif100.AppendText("Error during disconnection: " + ex.Message + "\n");
                }
                finally
                {
                    ifconnected = false;
                    buttonIF.ForeColor = Color.Red;
                    buttonSendIF100.Enabled = false;
                    removeString("IF100\n");
                    ifSocket = null;
                }
            }
        }




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSPS_Click(object sender, EventArgs e)
        {
            string IP = textIP.Text;
            int portNum;

            if (!spsconnected)
            {
                if (Int32.TryParse(textPort.Text, out portNum))
                {
                    try
                    {
                        spsSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        spsSocket.Connect(IP, portNum);

                        spsconnected = true;
                        textINPUTsps101.AppendText("Connected to the SPS101 Channel as " + textName.Text + "!\n");
                        disableLogin();
                        textCOnnectionList.AppendText("SPS101\n");
                        buttonSPS.ForeColor = Color.Green;
                        buttonSendSps101.Enabled = true;

                        Thread receiveSpsThread = new Thread(ReceiveSps);
                        receiveSpsThread.Start();
                        spsName = textName.Text;
                        byte[] nameBuffer = Encoding.Default.GetBytes("SPS//" + spsName);
                        spsSocket.Send(nameBuffer);
                    }
                    catch
                    {
                        textINPUTsps101.AppendText("Could not connect to the server!\n");
                    }
                }
                else
                {
                    textINPUTsps101.AppendText("Check the port\n");
                }
            }
            else
            {
                try
                {
                    if (spsSocket != null && spsSocket.Connected)
                    {
                        byte[] disconnectMessage = Encoding.Default.GetBytes("Client " + textName.Text + " is disconnected from SPS101.");
                        spsSocket.Send(disconnectMessage);

                        spsSocket.Shutdown(SocketShutdown.Both);
                        spsSocket.Close();
                        textINPUTsps101.AppendText("Disconnected from the SPS101 Channel!\n");
                    }
                    else
                    {
                        textINPUTsps101.AppendText("Socket is not connected.\n");
                    }
                }
                catch (Exception ex)
                {
                    textINPUTsps101.AppendText("Error during disconnection: " + ex.Message + "\n");
                }
                finally
                {
                    spsconnected = false;
                    buttonSPS.ForeColor = Color.Red;
                    buttonSendSps101.Enabled = false;
                    removeString("SPS101\n");

                }
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

            if (spsSocket != null && spsSocket.Connected)
            {
                spsSocket.Close();
            }

            if (ifSocket != null && ifSocket.Connected)
            {
                ifSocket.Close();
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
                spsSocket.Send(buffer);
                textSendSps101.Clear();
            }
            else if (message.Length > 128)
            {
                textINPUTsps101.AppendText("Message is too long\n");
                textSendSps101.ForeColor = Color.Red;
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
                ifSocket.Send(buffer);
                textSendIF.Clear();
            }
            else if (message.Length > 128)
            {
                textINPUTif100.AppendText("Message is too long\n");
                textSendIF.ForeColor = Color.Red;
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
                    int received = spsSocket.Receive(buffer);
                    if (received > 0)
                    {
                        string incomingMessage = Encoding.Default.GetString(buffer);
                        incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                        textINPUTsps101.AppendText(incomingMessage + "\n"); //server
                    }
                    else
                    {
                        throw new SocketException();
                    }
                }
                catch (SocketException)
                {
                    if (spsSocket != null)
                    {
                        spsSocket.Close();
                    }
                    spsconnected = false;
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
                    int received = ifSocket.Receive(buffer);

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
                    if (ifSocket != null)
                    {
                        ifSocket.Close();
                    }
                    ifconnected = false;
                }
            }
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


        /*  private void DisconnectFromServer(Socket socket, string channel)
          {
              try
              {
                  if (socket.Connected)
                  {
                      byte[] disconnectMessage = Encoding.Default.GetBytes("DISCONNECT//" + channel);
                      socket.Send(disconnectMessage);

                      socket.Shutdown(SocketShutdown.Both);
                      socket.Close();


                      if (channel == "SPS101")
                      {
                          spsconnected = false;
                      }
                      else if (channel == "IF100")
                      {
                          ifconnected = false;
                      }

                      textCOnnectionList.AppendText("Disconnected from " + channel + " channel!\n");
                  }
                  else
                  {
                      textCOnnectionList.AppendText("Connection is already closed.\n");
                  }
              }
              catch (Exception ex)
              {
                  textCOnnectionList.AppendText("Error while disconnecting: " + ex.Message + "\n");
              }
          }*/




    }
}
