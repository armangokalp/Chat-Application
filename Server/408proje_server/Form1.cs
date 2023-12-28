using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _408proje_server
{
    public partial class Form1 : Form
    {
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Dictionary<Socket, string> SPSclientSockets = new Dictionary<Socket, string>();
        Dictionary<Socket, string> IFclientSockets = new Dictionary<Socket, string>();

        bool terminating = false;
        bool listening = false;
        Dictionary<Socket, string> KeyValuePair;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();

        }
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            terminating = true;
            listening = false;

            foreach (var client in SPSclientSockets.Keys.Concat(IFclientSockets.Keys).ToList())
            {
                try
                {
                    if (client.Connected)
                    {
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                    }
                }
                catch
                {
                }
            }

            serverSocket.Close();
        }


        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_all_actions_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSPS101_connected_users_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIF100_connected_users_TextChanged(object sender, EventArgs e)
        {

        }


        private void UpdateTextBox(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateTextBox), new object[] { message });
            }
            else
            {
                textSPS101_connected_users.AppendText(message + Environment.NewLine);
            }
        }


        public struct obje
        {
            public string name;
            public Socket socket;
            public bool sps101;
            public bool if100;
        }

        private void button_START_Click(object sender, EventArgs e)
        {
            int serverPort;
            Thread updateListThread = new Thread(UpdateClientLists);
            updateListThread.Start();

            if (Int32.TryParse(text_port_num.Text, out serverPort))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(3);

                listening = true;
                
                Thread acceptThread = new Thread(Accept);
                acceptThread.Start();

                text_all_actions.AppendText("Started listening on port: " + serverPort + "\n");
                button_START.Enabled = false;

            }
            else
            {
                text_all_actions.AppendText("Please check port number \n");
            }
        }


        private void Accept()
        {
            while (listening)
            {
                try
                {
                    obje newObje = new obje();
                    newObje.if100 = false;
                    newObje.sps101 = false;
                    Socket newClient = serverSocket.Accept();
                    newObje.socket = newClient;
                    Byte[] buffer = new Byte[64];
                    int received = newClient.Receive(buffer);
                    if (received > 0)
                    {
                        string clientName = Encoding.Default.GetString(buffer, 0, received);


                        if (clientName.Substring(0, 5) == "SPS//")
                        {
                            
                            
                            clientName = clientName.Substring(5, clientName.Length - 5);
                            newObje.name = clientName;
                            text_all_actions.AppendText(clientName + " is connected to SPS101.\n");


                            newObje.sps101 = true;

                            //textSPS101_connected_users.AppendText(clientName + "\n");
                            Thread receiveThread = new Thread(() => Receive(newObje));
                            receiveThread.Start();

                            string welcomeMessage = clientName + " has joined to the server SPS101.";
                            byte[] welcomeBuffer = Encoding.Default.GetBytes(welcomeMessage);
                            newClient.Send(welcomeBuffer);


                            Echo(newObje.name, SPSclientSockets, welcomeMessage);

                            SPSclientSockets.Add(newClient, clientName);
                        }
                        else if (clientName.Substring(0, 5) == "IFF//")
                        {
                            
                            clientName = clientName.Substring(5, clientName.Length - 5);
                            newObje.name = clientName;
                            text_all_actions.AppendText(clientName + " is connected to IF100.\n");
                            newObje.if100 = true;
                            //textIF100_connected_users.AppendText(clientName + "\n");
                            Thread receiveThread = new Thread(() => Receive(newObje));
                            receiveThread.Start();

                            string welcomeMessage = clientName + " has joined to the server IF100.";
                            byte[] welcomeBuffer = Encoding.Default.GetBytes(welcomeMessage);
                            newClient.Send(welcomeBuffer);

                            Echo(newObje.name, IFclientSockets, welcomeMessage);

                            IFclientSockets.Add(newClient, clientName);
                        }



                        //richTextBox1.AppendText(clientName + "\n");
                    }
                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        text_all_actions.AppendText("The socket stopped working.\n");
                    }
                }
            }
        }




        public void Echo(string username, Dictionary<Socket , string> userConnections, string message)
        {
            foreach (var userEntry in userConnections)
            {
                if ((userEntry.Value != "SPS//"+username || userEntry.Value != "IFF//" + username) && message != "")
                {
                    userEntry.Key.Send(Encoding.Default.GetBytes($"{username}: {message}"));
                }

            }

        }
        
        private void Receive(obje thisClient)
        {
            bool connected = true;

            while (connected && !terminating)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    thisClient.socket.Receive(buffer);
                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));


                    
                    if (thisClient.sps101)
                    {

                        Echo(thisClient.name, SPSclientSockets, incomingMessage);

                    }
                    if (thisClient.if100)
                    {
                        Echo(thisClient.name, IFclientSockets, incomingMessage);
                    }




                    try
                    {
                        text_all_actions.AppendText(incomingMessage + "\n");
                    }
                    catch
                    {

                    }

                }
                catch
                {
                    if (!terminating)
                    {
                    //     text_all_actions.AppendText("A client has disconnected\n");
                    }
                    SPSclientSockets.Remove(thisClient.socket);
                    IFclientSockets.Remove(thisClient.socket);
                    thisClient.socket.Close();

                    connected = false;

                    removeString("IFF//" + thisClient.name + "\n", "SPS//" + thisClient.name + "\n");
                }
            }
        }
        
        private void removeString(string input1, string input2)
        {
            try
            {

                if (textIF100_connected_users.Text != null)
                {
                    int index = textIF100_connected_users.Text.IndexOf(input1);
                    if (index != -1)
                    {
                        textIF100_connected_users.Text = textIF100_connected_users.Text.Remove(index, input1.Length);
                    }
                }

            }
            catch
            {

            }

            try
            {

                if (textSPS101_connected_users.Text != null)
                {
                    int index = textSPS101_connected_users.Text.IndexOf(input2);
                    if (index != -1)
                    {
                        textSPS101_connected_users.Text = textSPS101_connected_users.Text.Remove(index, input2.Length);
                    }
                }

            }
            catch
            {

            }

            try
            {

                if (richTextBox1.Text != null)
                {
                    int index0 = richTextBox1.Text.IndexOf(input1);
                    if (index0 != -1)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(index0, input1.Length);
                    }
                    int index = richTextBox1.Text.IndexOf(input2);
                    if (index != -1)
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(index, input2.Length);
                    }
                }

            }
            catch
            {

            }

        }

        private void UpdateClientLists()
        {
            while (!terminating)
            {
                try
                {
                    UpdateClientListUI(SPSclientSockets, textSPS101_connected_users);
                    UpdateClientListUI(IFclientSockets, textIF100_connected_users);

                    UpdateClientListUI(SPSclientSockets, richTextBox1);
                    UpdateClientListUI(IFclientSockets, richTextBox1);


                }
                catch
                {
                }

            }
        }

        private void UpdateClientListUI(Dictionary<Socket, string> clientSockets, RichTextBox textBox)
        {
            foreach (var client in clientSockets)
            {
                if ( textBox.Find(client.Value) == -1  )
                {
                    textBox.AppendText(client.Value + "\n");
                }
                
            }
            
            
        }


    }
}
