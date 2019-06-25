namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.RockButton = new System.Windows.Forms.Button();
            this.GameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(203, 28);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 20);
            this.textPort.TabIndex = 9;
            this.textPort.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(62, 28);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(100, 20);
            this.textHost.TabIndex = 7;
            this.textHost.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(453, 28);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(27, 67);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.Size = new System.Drawing.Size(322, 44);
            this.StatusText.TabIndex = 10;
            // 
            // RockButton
            // 
            this.RockButton.Location = new System.Drawing.Point(189, 117);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(75, 23);
            this.RockButton.TabIndex = 11;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // GameTextBox
            // 
            this.GameTextBox.Enabled = false;
            this.GameTextBox.Location = new System.Drawing.Point(27, 146);
            this.GameTextBox.Multiline = true;
            this.GameTextBox.Name = "GameTextBox";
            this.GameTextBox.ReadOnly = true;
            this.GameTextBox.Size = new System.Drawing.Size(322, 142);
            this.GameTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(347, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Location = new System.Drawing.Point(27, 117);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(75, 23);
            this.ScissorsButton.TabIndex = 15;
            this.ScissorsButton.Text = "Scissors";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(108, 117);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 23);
            this.PaperButton.TabIndex = 16;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 339);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GameTextBox);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.TextBox GameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Button PaperButton;
    }
}

