namespace ProjectCygnus_Peer
{
	partial class Form1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.CloseButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ServerCheckButton = new System.Windows.Forms.Button();
			this.PeerPickComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ConnectToServerText = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PeerStatus = new System.Windows.Forms.ListBox();
			this.PeerStatusText = new System.Windows.Forms.Label();
			this.ServerStatusText = new System.Windows.Forms.Label();
			this.ConnectPeerButton = new System.Windows.Forms.Button();
			this.PeersRequestButton = new System.Windows.Forms.Button();
			this.ShareButton = new System.Windows.Forms.Button();
			this.DownloadButton = new System.Windows.Forms.Button();
			this.FileTransferText = new System.Windows.Forms.Label();
			this.MessageTextBox = new System.Windows.Forms.TextBox();
			this.MessageText = new System.Windows.Forms.Label();
			this.SendButton = new System.Windows.Forms.Button();
			this.MessagesList = new System.Windows.Forms.ListBox();
			this.MessagesText = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ProjectCygnus_Peer.Properties.Resources.Project_Cygnus;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(141, 140);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(757, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(31, 23);
			this.CloseButton.TabIndex = 1;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Location = new System.Drawing.Point(0, 137);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(141, 314);
			this.panel1.TabIndex = 2;
			// 
			// ServerCheckButton
			// 
			this.ServerCheckButton.Location = new System.Drawing.Point(154, 201);
			this.ServerCheckButton.Name = "ServerCheckButton";
			this.ServerCheckButton.Size = new System.Drawing.Size(91, 23);
			this.ServerCheckButton.TabIndex = 3;
			this.ServerCheckButton.Text = "Server Check";
			this.ServerCheckButton.UseVisualStyleBackColor = true;
			this.ServerCheckButton.Click += new System.EventHandler(this.ServerCheckButton_Click);
			// 
			// PeerPickComboBox
			// 
			this.PeerPickComboBox.FormattingEnabled = true;
			this.PeerPickComboBox.Location = new System.Drawing.Point(213, 251);
			this.PeerPickComboBox.Name = "PeerPickComboBox";
			this.PeerPickComboBox.Size = new System.Drawing.Size(121, 21);
			this.PeerPickComboBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(147, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 31);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cygnus - Peer";
			// 
			// ConnectToServerText
			// 
			this.ConnectToServerText.AutoSize = true;
			this.ConnectToServerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConnectToServerText.Location = new System.Drawing.Point(150, 162);
			this.ConnectToServerText.Name = "ConnectToServerText";
			this.ConnectToServerText.Size = new System.Drawing.Size(154, 20);
			this.ConnectToServerText.TabIndex = 6;
			this.ConnectToServerText.Text = "Connect to Server";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(151, 254);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Peers:";
			// 
			// PeerStatus
			// 
			this.PeerStatus.FormattingEnabled = true;
			this.PeerStatus.Location = new System.Drawing.Point(534, 90);
			this.PeerStatus.Name = "PeerStatus";
			this.PeerStatus.Size = new System.Drawing.Size(254, 186);
			this.PeerStatus.TabIndex = 8;
			// 
			// PeerStatusText
			// 
			this.PeerStatusText.AutoSize = true;
			this.PeerStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PeerStatusText.Location = new System.Drawing.Point(529, 62);
			this.PeerStatusText.Name = "PeerStatusText";
			this.PeerStatusText.Size = new System.Drawing.Size(120, 25);
			this.PeerStatusText.TabIndex = 9;
			this.PeerStatusText.Text = "Peer Status:";
			// 
			// ServerStatusText
			// 
			this.ServerStatusText.AutoSize = true;
			this.ServerStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ServerStatusText.Location = new System.Drawing.Point(151, 288);
			this.ServerStatusText.Name = "ServerStatusText";
			this.ServerStatusText.Size = new System.Drawing.Size(84, 13);
			this.ServerStatusText.TabIndex = 10;
			this.ServerStatusText.Text = "Server Status";
			// 
			// ConnectPeerButton
			// 
			this.ConnectPeerButton.Location = new System.Drawing.Point(414, 201);
			this.ConnectPeerButton.Name = "ConnectPeerButton";
			this.ConnectPeerButton.Size = new System.Drawing.Size(90, 23);
			this.ConnectPeerButton.TabIndex = 12;
			this.ConnectPeerButton.Text = "Connect Peer";
			this.ConnectPeerButton.UseVisualStyleBackColor = true;
			this.ConnectPeerButton.Click += new System.EventHandler(this.ConnectPeerButton_Click);
			// 
			// PeersRequestButton
			// 
			this.PeersRequestButton.Location = new System.Drawing.Point(283, 201);
			this.PeersRequestButton.Name = "PeersRequestButton";
			this.PeersRequestButton.Size = new System.Drawing.Size(90, 23);
			this.PeersRequestButton.TabIndex = 13;
			this.PeersRequestButton.Text = "Peers Request";
			this.PeersRequestButton.UseVisualStyleBackColor = true;
			this.PeersRequestButton.Click += new System.EventHandler(this.PeersRequestButton_Click);
			// 
			// ShareButton
			// 
			this.ShareButton.Location = new System.Drawing.Point(303, 321);
			this.ShareButton.Name = "ShareButton";
			this.ShareButton.Size = new System.Drawing.Size(75, 23);
			this.ShareButton.TabIndex = 14;
			this.ShareButton.Text = "Share";
			this.ShareButton.UseVisualStyleBackColor = true;
			this.ShareButton.Click += new System.EventHandler(this.ShareButton_Click);
			// 
			// DownloadButton
			// 
			this.DownloadButton.Location = new System.Drawing.Point(222, 321);
			this.DownloadButton.Name = "DownloadButton";
			this.DownloadButton.Size = new System.Drawing.Size(75, 23);
			this.DownloadButton.TabIndex = 15;
			this.DownloadButton.Text = "Download";
			this.DownloadButton.UseVisualStyleBackColor = true;
			// 
			// FileTransferText
			// 
			this.FileTransferText.AutoSize = true;
			this.FileTransferText.Location = new System.Drawing.Point(151, 326);
			this.FileTransferText.Name = "FileTransferText";
			this.FileTransferText.Size = new System.Drawing.Size(65, 13);
			this.FileTransferText.TabIndex = 16;
			this.FileTransferText.Text = "FileTransfer:";
			// 
			// MessageTextBox
			// 
			this.MessageTextBox.Location = new System.Drawing.Point(222, 373);
			this.MessageTextBox.Multiline = true;
			this.MessageTextBox.Name = "MessageTextBox";
			this.MessageTextBox.Size = new System.Drawing.Size(156, 65);
			this.MessageTextBox.TabIndex = 17;
			// 
			// MessageText
			// 
			this.MessageText.AutoSize = true;
			this.MessageText.Location = new System.Drawing.Point(151, 373);
			this.MessageText.Name = "MessageText";
			this.MessageText.Size = new System.Drawing.Size(53, 13);
			this.MessageText.TabIndex = 18;
			this.MessageText.Text = "Message:";
			// 
			// SendButton
			// 
			this.SendButton.Location = new System.Drawing.Point(384, 373);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(75, 23);
			this.SendButton.TabIndex = 19;
			this.SendButton.Text = "Send";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// MessagesList
			// 
			this.MessagesList.FormattingEnabled = true;
			this.MessagesList.Location = new System.Drawing.Point(534, 316);
			this.MessagesList.Name = "MessagesList";
			this.MessagesList.Size = new System.Drawing.Size(254, 121);
			this.MessagesList.TabIndex = 20;
			// 
			// MessagesText
			// 
			this.MessagesText.AutoSize = true;
			this.MessagesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MessagesText.Location = new System.Drawing.Point(531, 300);
			this.MessagesText.Name = "MessagesText";
			this.MessagesText.Size = new System.Drawing.Size(67, 13);
			this.MessagesText.TabIndex = 21;
			this.MessagesText.Text = "Messages:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MessagesText);
			this.Controls.Add(this.MessagesList);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.MessageText);
			this.Controls.Add(this.MessageTextBox);
			this.Controls.Add(this.FileTransferText);
			this.Controls.Add(this.DownloadButton);
			this.Controls.Add(this.ShareButton);
			this.Controls.Add(this.PeersRequestButton);
			this.Controls.Add(this.ConnectPeerButton);
			this.Controls.Add(this.ServerStatusText);
			this.Controls.Add(this.PeerStatusText);
			this.Controls.Add(this.PeerStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ConnectToServerText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PeerPickComboBox);
			this.Controls.Add(this.ServerCheckButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button ServerCheckButton;
		private System.Windows.Forms.ComboBox PeerPickComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label ConnectToServerText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox PeerStatus;
		private System.Windows.Forms.Label PeerStatusText;
		private System.Windows.Forms.Label ServerStatusText;
		private System.Windows.Forms.Button ConnectPeerButton;
		private System.Windows.Forms.Button PeersRequestButton;
		private System.Windows.Forms.Button ShareButton;
		private System.Windows.Forms.Button DownloadButton;
		private System.Windows.Forms.Label FileTransferText;
		private System.Windows.Forms.TextBox MessageTextBox;
		private System.Windows.Forms.Label MessageText;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.ListBox MessagesList;
		private System.Windows.Forms.Label MessagesText;
	}
}

