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

namespace ProjectCygnus_Server
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

		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		int Sock_Port = 3788;
		string Sock_IP = "127.0.0.1";

		private List<Peer> PeersList = new List<Peer>();

		class Peer
		{
			public Socket Peer_Con = null;
			public string Peer_Addr = null;
			public int Con_Port = -5;
		}

		private String getIP()
		{
			IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
					return ip.ToString();
			}
			return "127.0.0.1";
		}

		public Form1()
		{
			InitializeComponent();

			Sock_IP = getIP();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				socket.Bind(new IPEndPoint(IPAddress.Parse(Sock_IP), Sock_Port));
				IPNumber.Text = Sock_IP;
				PortNumber.Text = "" + Sock_Port;
			}
			catch (Exception ex)
			{
				PeerStatusList.Items.Add("Error Found: " + ex);
			}
			PeerConnThread(() => Adding_Peers());
			PeerStatusList.Items.Add("Server is now ON");
		}


		//Threads
		private void PeerConnThread(ThreadStart CreateThread)
		{
			Thread temp = new Thread(CreateThread);
			temp.IsBackground = true;
			temp.Start();
		}

		private void ConnPeers()
		{

		}

		private void Adding_Peers()
		{
			while(true)
			{
				socket.Listen(0);
				Socket temp = socket.Accept();
				Peer newPeer = new Peer();
				newPeer.Peer_Con = temp;
				temp = null;
				PeersList.Add(newPeer);
				PeerConnThread(() => Conn_Peer(newPeer));
			}
		}

		private void Conn_Peer(Peer Connected_Peer)
		{
			while(true)
			{
				try
				{
					byte[] buffer = new byte[2000];
					int messageLength = Connected_Peer.Peer_Con.Receive(buffer, 0, buffer.Length, 0);

					PeerStatusList.Items.Add(buffer);
					string Convert_Msg = Convert_buffer_to_msg(buffer, messageLength);
					if (Convert_Msg.Contains("Constellation Address is :"))
					{
						string extractedMsg = Convert_Msg.Substring(Convert_Msg.IndexOf(':') + 1);
						Connected_Peer.Peer_Addr = extractedMsg.Substring(0, extractedMsg.IndexOf('&'));
						Connected_Peer.Con_Port = Convert.ToInt32(extractedMsg.Substring(extractedMsg.IndexOf('_') + 1));
						PeerStatusList.Items.Add("New Constellation Connected. With IP: " + Connected_Peer.Peer_Addr + " and Port no.: " + Connected_Peer.Con_Port);
					}
					else if (Convert_Msg == "Send me all available Constellations")
					{
						string All_Conn_Peers = "All available clients:";
						for (int i = 0; i < PeersList.Count(); i++)
						{
							if (PeersList[i] == Connected_Peer)
							{
								continue;
							}
							All_Conn_Peers += PeersList[i].Peer_Addr + ":" + PeersList[i].Con_Port + '_';
						}
						Connected_Peer.Peer_Con.Send(Encoding.Default.GetBytes(All_Conn_Peers));
					}
				}
				catch
				{
					PeerStatusList.Items.Add("Connection Failed With Constellations");
				}
			}
		}

		//private void MsgtoPeer(string msgtoPeer, Socket PeerSoc)
		//{
		//	PeerSoc.Send(Encoding.Default.GetBytes(msgtoPeer));
		//}

		string Convert_buffer_to_msg(byte[] buffer, int messageLength)
		{
			char[] convert_to_char = new char[messageLength];
			Encoding.Default.GetDecoder().GetChars(buffer, 0, messageLength, convert_to_char, 0);
			string convert_msg = new string(convert_to_char);
			return convert_msg;
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
