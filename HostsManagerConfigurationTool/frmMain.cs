using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace HostsManagerConfigurationTool
{
	public partial class frmMain : Form
	{
		Config cfg;
		bool lockd = false;
		bool sel = false;
		public frmMain()
		{
			InitializeComponent();
			Text = Text + " ver - " + Application.ProductVersion;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			cfg = JsonConvert.DeserializeObject<Config>(File.ReadAllText("C:\\HostsManager\\config.json"));
		}

		private void btnAddSequence_Click(object sender, EventArgs e)
		{
			string name = Interaction.InputBox("段名称：", "新建段");
			Config.Sequence seq = new Config.Sequence();
			seq.name = name;
			seq.entries = new List<Config.Entry>();
			cfg.currentCustoms.Add(seq);
			updateTree();
		}

		private void btnAddEntry_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode == null) return;
			if (treCustom.SelectedNode.Level == 0)
			{
				string ip = Interaction.InputBox("IP：", "新建项");
				string domain = Interaction.InputBox("域名：", "新建项");
				Config.Entry entry = new Config.Entry();
				entry.ip = ip;
				entry.domain = domain;
				((Config.Sequence)treCustom.SelectedNode.Tag).entries.Add(entry);
				updateTree();
			}
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			File.WriteAllText("C:\\HostsManager\\config.json", JsonConvert.SerializeObject(cfg));
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode == null) return;
			if (treCustom.SelectedNode.Level == 0)
			{
				//seq
				foreach (Config.Sequence seq in cfg.currentCustoms)
				{
					if (seq.name == treCustom.SelectedNode.Text)
					{
						cfg.currentCustoms.Remove(seq);
						updateTree();
						return;
					}
				}
			}
			else
				foreach (Config.Sequence seq in cfg.currentCustoms)
					if (seq.name == treCustom.SelectedNode.Parent.Text)
						seq.entries.Remove((Config.Entry)treCustom.SelectedNode.Tag);
		}

		private void btnMove_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode == null) return;
			if (treCustom.SelectedNode.Level == 1)
			{
				string target = Interaction.InputBox("移动到段：", "移动项");
				Config.Sequence ts = null;
				Config.Entry entry = null;
				TreeNode etn = null;
				foreach (Config.Sequence seq in cfg.currentCustoms)
				{
					if(seq.name == target) ts = seq;
					if (seq.name == treCustom.SelectedNode.Parent.Text)
						foreach (Config.Entry en in seq.entries)
							if (treCustom.SelectedNode.Tag == en)
							{
								entry = en;
								seq.entries.Remove(en);
								etn = treCustom.SelectedNode;
								break;
							}
				}
				updateTree();
			}
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			cfg.lastChanged = DateTime.UtcNow;
			string json = JsonConvert.SerializeObject(cfg);
			StreamWriter jfile = new StreamWriter("C:\\HostsManager\\config.json");
			jfile.Write(json);
			jfile.Close();
			IPAddress ip = IPAddress.Parse("127.0.0.1");
			Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				clientSocket.Connect(new IPEndPoint(ip, 8885));
				clientSocket.Send(Encoding.UTF8.GetBytes("cupdate"));
				clientSocket.Close();
			}
			catch(Exception) {
				MessageBox.Show("连接到HostsManager服务失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnServerConfig_Click(object sender, EventArgs e)
		{
			new frmUpdate(cfg).ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode == null) return;
			if(treCustom.SelectedNode.Level == 0)
			{
				Config.Sequence seq = (Config.Sequence)treCustom.SelectedNode.Tag;
				string name = Interaction.InputBox("段名称:", "修改", seq.name);
				seq.name = name;
			}
			else
			{
				Config.Entry entry = (Config.Entry)treCustom.SelectedNode.Tag;
				string ip = Interaction.InputBox("IP:", "修改", entry.ip);
				string domain = Interaction.InputBox("域名:", "修改", entry.domain);
				entry.ip = ip;
				entry.domain = domain;
			}
			updateTree();
		}

		public void import(string sequ, string hosts)
		{
			foreach(Config.Sequence s in cfg.currentCustoms)
				if(s.name == sequ)
				{
					StringReader syshi = new StringReader(hosts);
					string lines = syshi.ReadLine();
					while (lines != null)
					{
						if (!(lines.StartsWith("#")) && !(lines.Trim().Length == 0))
						{
							string[] en = lines.Trim().Split(new char[] { ' ', '	' }, 2);
							Config.Entry ent = new Config.Entry();
							ent.ip = en[0].Trim();
							ent.domain = en[1].Trim();
							s.entries.Add(ent);
						}
						lines = syshi.ReadLine();
					}
					return;
				}
			Config.Sequence seq = new Config.Sequence();
			List<Config.Entry> ents = new List<Config.Entry>();
			seq.name = sequ;
			StringReader sysh = new StringReader(hosts);
			string line = sysh.ReadLine();
			while (line != null)
			{
				if (!(line.StartsWith("#")) && !(line.Trim().Length == 0))
				{
					string[] en = line.Trim().Split(new char[] { ' ', '	' }, 2);
					Config.Entry ent = new Config.Entry();
					ent.ip = en[0].Trim();
					ent.domain = en[1].Trim();
					ents.Add(ent);
				}
				line = sysh.ReadLine();
			}
			seq.entries = ents;
			cfg.currentCustoms.Add(seq);
			sysh.Close();
			updateTree();
		}

		private void updateTree()
		{
			treCustom.Nodes.Clear();
			foreach (Config.Sequence seq in cfg.currentCustoms)
			{
				TreeNode node = new TreeNode(seq.name);
				List<Config.Entry> entries = seq.entries;
				if (entries != null)
					foreach (Config.Entry entry in entries)
					{
						TreeNode leaf = new TreeNode("[" + entry.ip + "] " + entry.domain);
						leaf.Tag = entry;
						sel = true;
						leaf.Checked = entry.enabled;
						sel = false;
						node.Nodes.Add(leaf);
					}
				node.Tag = seq;
				node.Checked = seq.enabled;
				treCustom.Nodes.Add(node);
			}
			if (checkBox1.Checked)
				treCustom.ExpandAll();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			new frmImport(this).ShowDialog();
		}

		private void treCustom_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (sel) return;
			if (!lockd) setchild(e.Node);
			setparent(e.Node);
			lockd = false;
		}

		private void setchild(TreeNode node)
		{
			foreach (TreeNode child in node.Nodes)
			{
				child.Checked = node.Checked;
				((Config.HasEnabled)child.Tag).enabled = node.Checked;
			}
			lockd = true;
		}

		private void setparent(TreeNode node)
		{
			if (node.Parent != null)
			{
				//如果当前节点状态为勾选，则需要所有兄弟节点都勾选才能勾选父节点
				if (node.Checked)
					foreach (TreeNode brother in node.Parent.Nodes)
						if (brother.Checked == false)
							return;
				node.Parent.Checked = node.Checked;
				((Config.HasEnabled)node.Parent.Tag).enabled = node.Checked;
			}
		}
	}
}
