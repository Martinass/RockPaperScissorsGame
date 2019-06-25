using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        //When the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates the TCP client
            client = new SimpleTcpClient
            {
                StringEncoder = Encoding.UTF8
            };
            client.DataReceived += Client_DataReceived;
        }

        //When connect button is pressed
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client.Connect(textHost.Text, Convert.ToInt32(textPort.Text));
            ConnectButton.Enabled = false;
            StatusText.Text = "Connected!";
            client.WriteLine("\r\n" + NameTextBox.Text + " has connected");
            GameTextBox.Text = "Waiting for an opponent, please wait...\r\n";
        }

        // If data is received from the server
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
                StatusText.Invoke((MethodInvoker)delegate ()
                {
                    StatusText.Text += e.MessageString;
                });
        }

        //If scissors button is selected. Sends data to the server
        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("\r\n" + NameTextBox.Text + " has chosen: Scissors", TimeSpan.FromSeconds(1));
            RockButton.Enabled = false;
            ScissorsButton.Enabled = false;
            PaperButton.Enabled = false;
        }

        //If paper button is selected. Sends data to the server
        private void PaperButton_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("\r\n" + NameTextBox.Text + " has chosen: Paper", TimeSpan.FromSeconds(1));
            RockButton.Enabled = false;
            ScissorsButton.Enabled = false;
            PaperButton.Enabled = false;
        }

        //If rock button is selected. Sends data to the server
        private void RockButton_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("\r\n" + NameTextBox.Text + " has chosen: Rock", TimeSpan.FromSeconds(1));
            RockButton.Enabled = false;
            ScissorsButton.Enabled = false;
            PaperButton.Enabled = false;
        }
    }
}
