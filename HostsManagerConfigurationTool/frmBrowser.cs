using System;
using System.Windows.Forms;

namespace HostsManagerConfigurationTool
{
	public partial class frmBrowser : Form
	{
		public frmBrowser()
		{
			InitializeComponent();
		}

		private void btnAgree_Click(object sender, EventArgs e)
		{
			Hide();
		}

		public void load(string html)
		{
			webBrowser1.DocumentText = html;
		}
	}
}
