using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HostsManagerConfigurationTool
{
	public partial class frmWizard1 : Form
	{
		public frmWizard1()
		{
			InitializeComponent();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			Config cfg = new Config();
			cfg.currentCustoms = new List<Config.Sequence>();
			cfg.updateSource = new List<string>();
			Config.Sequence seq = new Config.Sequence();
			List<Config.Entry> ents = new List<Config.Entry>();
			seq.name = "Import";
			StreamReader sysh = new StreamReader("C:\\Windows\\System32\\drivers\\etc\\hosts");
			string line = sysh.ReadLine();
			while(line != null)
			{
				if (!(line.StartsWith("#")) && !(line.Trim().Length == 0))
				{
					string[] en = line.Trim().Split(new char[] {' ', '	' }, 2);
					Config.Entry ent = new Config.Entry();
					ent.ip = en[0].Trim();
					ent.domain = en[1].Trim();
					ent.enabled = true;
					ents.Add(ent);
				}
				line = sysh.ReadLine();
			}
			seq.entries = ents;
			seq.enabled = true;
			cfg.currentCustoms.Add(seq);
			sysh.Close();
			cfg.lastChanged = DateTime.UtcNow;
			int time;
			switch (cbxUpdateTime.SelectedIndex)
			{
				case 0: time = 1; break;
				case 1: time = 3; break;
				case 2: time = 7; break;
				case 3: time = 14; break;
				case 4: time = 30; break;
				default: time = 1; break;
			}
			cfg.updateTimeDay = time;
			StreamWriter c = new StreamWriter("C:\\HostsManager\\config.json");
			string json = JsonConvert.SerializeObject(cfg);
			c.Write(json);
			c.Close();
			new frmMain().Show();
			Hide();
		}

		private void btnNoImport_Click(object sender, EventArgs e)
		{
			Config cfg = new Config();
			int time;
			switch (cbxUpdateTime.SelectedIndex)
			{
				case 0:time = 1; break;
				case 1:time = 3; break;
				case 2:time = 7; break;
				case 3:time = 14; break;
				case 4: time = 30; break;
				default:time = 1; break;
			}
			cfg.updateTimeDay = time;
			cfg.lastChanged = DateTime.UtcNow;
			string json = JsonConvert.SerializeObject(cfg);
			StreamWriter configFile = new StreamWriter("C:\\HostsManager\\config.json");
			configFile.Write(json);
			new frmMain().Show();
			Hide();
		}

		private void frmWizard1_Load(object sender, EventArgs e)
		{
			cbxUpdateTime.SelectedIndex = 0;
			if (!Directory.Exists("C:\\HostsManager"))
				Directory.CreateDirectory("C:\\HostsManager");
		}
	}
}
