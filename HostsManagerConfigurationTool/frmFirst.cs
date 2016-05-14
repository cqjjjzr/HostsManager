using System;
using System.Windows.Forms;

namespace HostsManagerConfigurationTool
{
	public partial class frmFirst : Form
	{
		public frmFirst()
		{
			InitializeComponent();
		}

		private void btnWizard_Click(object sender, EventArgs e)
		{
			new frmWizard1().Show();
			Hide();
		}
	}
}
