namespace ProjectCygnus_Server
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
			this.PeerStatusList = new System.Windows.Forms.ListBox();
			this.IPText = new System.Windows.Forms.Label();
			this.PortText = new System.Windows.Forms.Label();
			this.PeerText = new System.Windows.Forms.Label();
			this.IPNumber = new System.Windows.Forms.Label();
			this.PortNumber = new System.Windows.Forms.Label();
			this.CloseButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.CygnusServerText = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PeerStatusList
			// 
			this.PeerStatusList.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.PeerStatusList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PeerStatusList.FormattingEnabled = true;
			this.PeerStatusList.Location = new System.Drawing.Point(355, 137);
			this.PeerStatusList.Name = "PeerStatusList";
			this.PeerStatusList.Size = new System.Drawing.Size(311, 262);
			this.PeerStatusList.TabIndex = 0;
			// 
			// IPText
			// 
			this.IPText.AutoSize = true;
			this.IPText.Location = new System.Drawing.Point(36, 192);
			this.IPText.Name = "IPText";
			this.IPText.Size = new System.Drawing.Size(63, 13);
			this.IPText.TabIndex = 2;
			this.IPText.Text = "IP Number: ";
			// 
			// PortText
			// 
			this.PortText.AutoSize = true;
			this.PortText.Location = new System.Drawing.Point(36, 231);
			this.PortText.Name = "PortText";
			this.PortText.Size = new System.Drawing.Size(72, 13);
			this.PortText.TabIndex = 3;
			this.PortText.Text = "Port Number: ";
			// 
			// PeerText
			// 
			this.PeerText.AutoSize = true;
			this.PeerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PeerText.Location = new System.Drawing.Point(350, 105);
			this.PeerText.Name = "PeerText";
			this.PeerText.Size = new System.Drawing.Size(149, 29);
			this.PeerText.TabIndex = 4;
			this.PeerText.Text = "Peer Status: ";
			// 
			// IPNumber
			// 
			this.IPNumber.AutoSize = true;
			this.IPNumber.Location = new System.Drawing.Point(105, 192);
			this.IPNumber.Name = "IPNumber";
			this.IPNumber.Size = new System.Drawing.Size(57, 13);
			this.IPNumber.TabIndex = 5;
			this.IPNumber.Text = "IP Number";
			// 
			// PortNumber
			// 
			this.PortNumber.AutoSize = true;
			this.PortNumber.Location = new System.Drawing.Point(104, 231);
			this.PortNumber.Name = "PortNumber";
			this.PortNumber.Size = new System.Drawing.Size(26, 13);
			this.PortNumber.TabIndex = 6;
			this.PortNumber.Text = "Port";
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(757, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(31, 23);
			this.CloseButton.TabIndex = 8;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ProjectCygnus_Server.Properties.Resources.Project_Cygnus;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(98, 97);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// CygnusServerText
			// 
			this.CygnusServerText.AutoSize = true;
			this.CygnusServerText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CygnusServerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CygnusServerText.Location = new System.Drawing.Point(116, 48);
			this.CygnusServerText.Name = "CygnusServerText";
			this.CygnusServerText.Size = new System.Drawing.Size(210, 31);
			this.CygnusServerText.TabIndex = 9;
			this.CygnusServerText.Text = "Cygnus - Server";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CygnusServerText);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.PortNumber);
			this.Controls.Add(this.IPNumber);
			this.Controls.Add(this.PeerText);
			this.Controls.Add(this.PortText);
			this.Controls.Add(this.IPText);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.PeerStatusList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "ProjectCygnus_Server";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox PeerStatusList;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label IPText;
		private System.Windows.Forms.Label PortText;
		private System.Windows.Forms.Label PeerText;
		private System.Windows.Forms.Label IPNumber;
		private System.Windows.Forms.Label PortNumber;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label CygnusServerText;
	}
}

