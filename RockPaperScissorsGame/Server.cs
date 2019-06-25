using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        //When the form loads
        private void Server_Load(object sender, EventArgs e)
        {
            //Creates the TCP server
            server = new SimpleTcpServer
            {
                Delimiter = 0x13,
                StringEncoder = Encoding.UTF8
            };
            server.DataReceived += Server_DataReceived;
        }

        //If data is received from the client
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            StatusText.Invoke((MethodInvoker)delegate ()
            {
                StatusText.Text += e.MessageString;
            });
        }

        //When start button is pressed
        private void StartButton_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textHost.Text);
            server.Start(ip, Convert.ToInt32(textPort.Text));
            StatusText.Text += "Server started.\r\n";
        }

        //When stop button is pressed
        private void StopButton_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
                StatusText.Text += "Server stopped.\r\n";
            }
        }
    }
}
