using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HostsManagerConfigurationTool
{
	public partial class frmShow : Form
	{
		Source source;
		public frmShow(Source src)
		{
			InitializeComponent();
			source = src;
		}

		private void frmShow_Load(object sender, EventArgs e)
		{
			Text = source.name;
			foreach (Config.Sequence seq in source.current)
			{
				TreeNode node = new TreeNode(seq.name);
				List<Config.Entry> entries = seq.entries;
				if (entries != null)
					foreach (Config.Entry entry in entries)
					{
						TreeNode leaf = new TreeNode("[" + entry.ip + "] " + entry.domain);
						leaf.Tag = entry;
						node.Nodes.Add(leaf);
					}
				treShow.Nodes.Add(node);
			}
		}
	}
}
