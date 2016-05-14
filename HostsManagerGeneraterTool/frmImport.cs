using System;
using System.Windows.Forms;

namespace HostsManagerGeneraterTool
{
	public partial class frmImport : Form
	{
		frmMain main;
		public frmImport(frmMain main)
		{
			InitializeComponent();
			this.main = main;
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			main.import(txtSequence.Text, txtHosts.Text);
			this.Close();
		}
	}
}
