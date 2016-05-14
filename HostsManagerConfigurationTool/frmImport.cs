using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostsManagerConfigurationTool
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
