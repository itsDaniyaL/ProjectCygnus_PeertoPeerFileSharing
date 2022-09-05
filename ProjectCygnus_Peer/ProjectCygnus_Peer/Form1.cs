using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace ProjectCygnus_Peer
{
	public partial class Form1 : Form
	{

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x84:
					base.WndProc(ref m);
					if ((int)m.Result == 0x1)
						m.Result = (IntPtr)0x2;
					return;
			}

			base.WndProc(ref m);
		}

		Socket Listen_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		Socket Server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		int server_Port = 3788;
		string server_IP = "127.0.0.1";
		public string my_IP = "127.0.0.1";
		public int my_Port = -5;
		public string file_name = null;
		public bool is_server_conn = false;


		class PeerInfo
		{
			public string IP = null;
			public Socket Peer_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			public string msg = null;
			public string send_Status = null;
			public string recv_Status = null;
			public int Con_Port = -5;
		}

		private List<PeerInfo> Peers = new List<PeerInfo>();

		public Form1()
		{
			InitializeComponent();
			PeersRequestButton.Visible = false;
			ConnectPeerButton.Visible = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PeerPickComboBox.Enabled = false;
			CheckForIllegalCrossThreadCalls = false;
		}

		private void Enable_Options()
		{
			ServerCheckButton.Enabled = false;
			PeerPickComboBox.Enabled = false;
		}

		private string Encrypt_Msg(byte[] buffer, int msgLength)
		{
			return "";
		}

		private void Server_Comm()
		{
			while(true)
			{
				try
				{
					byte[] buffer = new byte[1500];
					int msgLength = Server_socket.Receive(buffer, 0, buffer.Length, 0);
					string recv_Msg = Encrypt_Msg(buffer, msgLength);
					if(recv_Msg.Contains("All available clients:"))
					{
						string Peer_ID_Port = recv_Msg.Substring(recv_Msg.IndexOf(':') + 1);
						while(true)
						{
							int i = Peer_ID_Port.IndexOf('_');
							string newSinglePeer = Peer_ID_Port.Substring(0, i);
							PeerPickComboBox.Items.Add(newSinglePeer);
							PeerPickComboBox.SelectedIndex = PeerPickComboBox.FindStringExact(newSinglePeer);
							ConnectPeerButton.Visible = true;
							Peer_ID_Port = Peer_ID_Port.Substring(i + 1);
						}
					}
					else
					{
						PeerStatus.Items.Add(recv_Msg);
					}
				}
				catch
				{
					ServerStatusText.Text = "Error Found on Server Communication";
				}
			}
		}

		private void Pre_Peer_Comm()
		{
			while(true)
			{
				try
				{
					Listen_socket.Listen(0);
					Socket temp = Listen_socket.Accept();
					PeerStatus.Items.Add("Peer Connected");
					PeerInfo new_Peer = new PeerInfo();
					new_Peer.Peer_socket = temp;
					Peers.Add(new_Peer);
					Thread new_Thread = new Thread(() => Peer_Comm(new_Peer));
				}
			}
		}

		private void Server_Conn()
		{
			try
			{
				Server_socket.Connect(new IPEndPoint(IPAddress.Parse(server_IP), server_Port));
				ServerStatusText.Text = "Server Found & Connected";
				Thread Server_Conn_Thread = new Thread(() => Server_Comm());
				Server_Conn_Thread.IsBackground = true;
				Server_Conn_Thread.Start();
				Thread Enabling_Button = new Thread(() => Pre_Peer_Comm());
				Enabling_Button.IsBackground = true;
				Enabling_Button.Start();
				Thread.Sleep(200);
				Server_socket.Send(Encoding.Default.GetBytes("Constellation Address is:" + my_IP + "&" + my_Port));
			}
			catch
			{
				ServerStatusText.Text = "Server Connection Failed";
			}
		}

		private void Peer_Conn()
		{

		}


		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private int getPortNo()
		{
			TcpListener Check_New_Port = new TcpListener(IPAddress.Loopback, 0);
			Check_New_Port.Start();
			int Port_No = ((IPEndPoint)Check_New_Port.LocalEndpoint).Port;
			Check_New_Port.Stop();
			return Port_No;
		}

		private void Folder_Creation()
		{
			file_name = "Constellation " + my_Port;
			Directory.CreateDirectory(file_name);
		}

		private void ServerCheckButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (!is_server_conn)
				{
					my_Port = getPortNo();
					Listen_socket.Bind(new IPEndPoint(IPAddress.Parse(my_IP), my_Port));
					PeerStatus.Items.Add("IP: " + my_IP + " & Port No. :" + my_Port + ", sent to the server ");
					Folder_Creation();
					is_server_conn = true;
				}
			}
			catch
			{
				ServerStatusText.Text = "Server Bind Failed";
			}
			Server_Conn();
			PeersRequestButton.Visible = true;
		}

		private void Peer_Comm()
		{

		}

		private void ConnectPeerButton_Click(object sender, EventArgs e)
		{
			try
			{
				string dest_Peer = PeerPickComboBox.Text;
				PeerInfo new_Peer = new PeerInfo();
				new_Peer.IP = dest_Peer.Substring(0, dest_Peer.IndexOf(":"));
				new_Peer.Con_Port = Convert.ToInt32(dest_Peer.Substring(dest_Peer.IndexOf(":") + 1));

				for(int i = 0;i< Peers.Count(); i++)
				{
					if(Peers[i].IP == new_Peer.IP && Peers[i].Con_Port == new_Peer.Con_Port)
					{
						PeerStatus.Items.Add("Already Connected to " + new_Peer.Con_Port);
					}
					Enable_Options();
					PeerPickComboBox.SelectedIndex = PeerPickComboBox.FindStringExact(new_Peer.Con_Port.ToString());
					new_Peer = null;
					return;
				}

				PeerStatus.Items.Add("Connecting to Peer " + new_Peer.Con_Port);
				new_Peer.Peer_socket.Connect(new IPEndPoint(IPAddress.Parse(new_Peer.IP), new_Peer.Con_Port));
				PeerStatus.Items.Add("Connected to Peer " + new_Peer.Con_Port);
				Enable_Options();
				PeerPickComboBox.Items.Add(new_Peer.Con_Port);
				PeerPickComboBox.SelectedIndex = PeerPickComboBox.FindStringExact(new_Peer.Con_Port.ToString());
				Thread new_Peer_Thread = new Thread(() => Peer_Comm());
				new_Peer_Thread.IsBackground = true;
				new_Peer_Thread.Start();
				new_Peer.Peer_socket.Send(Encoding.Default.GetBytes("My IP Address is:" + my_IP + "_" + my_Port));
			}
			catch
			{
				ServerStatusText.Text = "Peer Find Process Failed";
			}
		}

		private void PeersRequestButton_Click(object sender, EventArgs e)
		{
			PeerPickComboBox.Items.Clear();
			Server_socket.Send(Encoding.Default.GetBytes("Send me all available Constellations"));
			PeerStatus.Items.Add("Server requested for Constellations");
			Thread.Sleep(10);
		}

		void File_Send(PeerInfo peer_to_Send, string filename_with_path)
		{
			DownloadButton.Visible = false;
			ShareButton.Visible = false;

			peer_to_Send.send_Status = "*";
			while (peer_to_Send.send_Status == "*") ;

			if(peer_to_Send.send_Status == "1")
			{
				peer_to_Send.Peer_socket.SendFile(filename_with_path);
				Thread.Sleep(75);
				peer_to_Send.Peer_socket.Send(Encoding.Default.GetBytes("file completed"));
				PeerStatus.Items.Add("File Shared");
			}
			else
			{
				PeerStatus.Items.Add("Constellation did not accept file: "+ peer_to_Send.Con_Port);
			}
			peer_to_Send.send_Status = null;
			DownloadButton.Visible = true;
			ShareButton.Visible = true;
		}

		private void ShareButton_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog File_Select = new OpenFileDialog();
				File_Select.Filter = "All Files (*.*)|*.*";
				File_Select.Title = "Select file";
				if(File_Select.ShowDialog() == DialogResult.OK)
				{
					for(int i = 0;i<Peers.Count();i++)
					{
						if (Peers[i].Con_Port == Convert.ToInt32(PeerPickComboBox.Text))
						{
							string filename_with_path = File_Select.FileName.ToString();
							string File_Name = Path.GetFileName(filename_with_path);
							string file_Bytes = new FileInfo(filename_with_path).Length.ToString();

							Peers[i].Peer_socket.Send(Encoding.Default.GetBytes("Can I send this file to you:" + File_Name));

							PeerStatus.Items.Add("File Share in Process:" + File_Name);

							Thread Send_File_Thread = new Thread(() => File_Send(Peers[i],filename_with_path));
							Send_File_Thread.IsBackground = true;
							Send_File_Thread.Start();
							break;
						}
					}
				}
			}
			catch
			{
				PeerStatus.Items.Add("File Sharing Failed!");
			}
		}

		private void SendButton_Click(object sender, EventArgs e)
		{
			if(MessageTextBox.Text.Length != 0)
			{
				Server_socket.Send(Encoding.Default.GetBytes(MessageTextBox.Text));
				MessagesList.Items.Add("My message:" + MessageTextBox.Text);
				MessageTextBox.Clear();
				MessageTextBox.Focus();
			}
		}
	}
}
