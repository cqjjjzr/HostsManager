using HostsManagerConfigurationTool;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HostsManagerGeneraterTool
{
	public partial class frmMain : Form
	{
		private Source src;
		bool lockd = false;
		public frmMain()
		{
			InitializeComponent();
			src = new Source();
			src.current = new List<Config.Sequence>();
			txtIntro.ScrollBars = ScrollBars.Both;
		}

		private void mnuOpen_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Json文件|*.json";
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string fileName = this.openFileDialog1.FileName;
				src = JsonConvert.DeserializeObject<Source>(File.ReadAllText(fileName));
				txtInternalName.Text = src.internalName;
				txtName.Text = src.name;
				txtDescription.Text = src.description;
				txtIntro.Text = src.html;
				txtDestAddress.Text = src.address;
				numericUpDown1.Value = src.version;
				updateTree();
			}
		}

		private void btnAddSequence_Click(object sender, EventArgs e)
		{
			string name = Interaction.InputBox("段名称：", "新建段");
			if (name.Length == 0) return;
			Config.Sequence seq = new Config.Sequence();
			seq.name = name;
			seq.entries = new List<Config.Entry>();
			src.current.Add(seq);
			updateTree();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode != null && treCustom.SelectedNode.Level == 0)
			{
				string ip = Interaction.InputBox("IP：", "新建项");
				string domain = Interaction.InputBox("域名：", "新建项");
				if (ip.Length == 0 || domain.Length == 0) return;
				Config.Entry entry = new Config.Entry();
				entry.ip = ip;
				entry.domain = domain;
				((Config.Sequence)treCustom.SelectedNode.Tag).entries.Add(entry);
				updateTree();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode != null && treCustom.SelectedNode.Level == 0)
			{
				//seq
				foreach (Config.Sequence seq in src.current)
					if (seq.name == treCustom.SelectedNode.Text)
					{
						src.current.Remove(seq);
						updateTree();
						return;
					}
			}
			else
			{
				foreach (Config.Sequence seq in src.current)
					if (seq.name == treCustom.SelectedNode.Parent.Text)
						foreach (Config.Entry entry in seq.entries)
							if (treCustom.SelectedNode.Tag == entry)
							{
								seq.entries.Remove(entry);
								updateTree();
								return;
							}
			}
		}

		private void btnMove_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode != null && treCustom.SelectedNode.Level == 1)
			{
				string target = Interaction.InputBox("移动到段：", "移动项");
				if (target.Length == 0) return;
				Config.Sequence ts = null;
				Config.Entry entry = null;
				TreeNode etn = null;
				foreach (Config.Sequence seq in src.current)
				{
					if (seq.name == target) ts = seq;
					if (seq.name == treCustom.SelectedNode.Parent.Text)
					{
						foreach (Config.Entry en in seq.entries)
							if (treCustom.SelectedNode.Tag == en)
							{
								entry = en;
								seq.entries.Remove(en);
								etn = treCustom.SelectedNode;
								break;
							}
					}
				}
				updateTree();
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (treCustom.SelectedNode != null && treCustom.SelectedNode.Level == 0)
			{
				Config.Sequence seq = (Config.Sequence)treCustom.SelectedNode.Tag;
				string name = Interaction.InputBox("段名称:", "修改", seq.name);
				if (name.Length == 0) return;
				seq.name = name;
			}
			else if(treCustom.SelectedNode != null)
			{
				Config.Entry entry = (Config.Entry)treCustom.SelectedNode.Tag;
				string ip = Interaction.InputBox("IP:", "修改", entry.ip);
				string domain = Interaction.InputBox("域名:", "修改", entry.domain);
				if (ip.Length == 0 || domain.Length == 0) return;
				entry.ip = ip;
				entry.domain = domain;
			}
			updateTree();
		}

		public void import(string sequ, string hosts)
		{
			foreach (Config.Sequence s in src.current)
				if (s.name == sequ)
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
					syshi.Close();
					updateTree();
					return;
				}
			Config.Sequence seq = new Config.Sequence();
			List<Config.Entry> ents = new List<Config.Entry>();
			seq.name = sequ;
			StringReader sysh = new StringReader(hosts);
			string line = sysh.ReadLine();
			while (line != null)
			{
				if (!(line.StartsWith("#")) && line.Trim().Length != 0)
				{
					string[] en = line.Trim().Split(new char[] { ' ', ' ' }, 2);
					Config.Entry ent = new Config.Entry();
					ent.ip = en[0].Trim();
					ent.domain = en[1].Trim();
					ents.Add(ent);
				}
				line = sysh.ReadLine();
			}
			seq.entries = ents;
			src.current.Add(seq);
			sysh.Close();
			updateTree();
		}

		private void updateTree()
		{
			treCustom.Nodes.Clear();
			foreach (Config.Sequence seq in src.current)
			{
				TreeNode node = new TreeNode(seq.name);
				List<Config.Entry> entries = seq.entries;
				if (entries != null)
					foreach (Config.Entry entry in entries)
					{
						TreeNode leaf = new TreeNode("[" + entry.ip + "] " + entry.domain);
						leaf.Tag = entry;
						leaf.Checked = entry.enabled;
						node.Nodes.Add(leaf);
					}
				node.Tag = seq;
				node.Checked = seq.enabled;
				treCustom.Nodes.Add(node);
			}
			if (chkAutoExpand.Checked)
				treCustom.ExpandAll();
		}

		private void mnuSave_Click(object sender, EventArgs e)
		{
			if (txtInternalName.Text.Length == 0 && txtDestAddress.Text.Length == 0 && txtName.Text.Length == 0 && txtDescription.Text.Length == 0 && txtIntro.Text.Length == 0) return;
			if (!txtDestAddress.Text.StartsWith("http://")) return;
			if (txtDestAddress.Text.Contains("\n") || txtInternalName.Text.Contains("\n") || txtName.Text.Contains("\n")) return;
			if (!Regex.IsMatch(txtInternalName.Text, "[A-Za-z\\.]")) return;
			if (!Regex.IsMatch(txtDestAddress.Text, "(http):\\/\\/[\\w\\-_]+(\\.[\\w\\-_]+)+([\\w\\-\\.,@?^=%&amp;:/~\\+#]*[\\w\\-\\@?^=%&amp;/~\\+#])?") || !txtDestAddress.Text.EndsWith(".json")) return;
			src.address = txtDestAddress.Text;
			src.description = txtDescription.Text;
			src.name = txtName.Text;
			src.html = txtIntro.Text;
			src.version = (int) numericUpDown1.Value;
			src.internalName = txtInternalName.Text;
			saveFileDialog.Filter = "Json文件|*.json";
			saveFileDialog.FileName = src.internalName;
			if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.OverwritePrompt)
				File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(src));
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			new frmImport(this).ShowDialog();
		}

		private void treCustom_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (!lockd)
				setchild(e.Node);
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
