﻿using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace HostsManagerConfigurationTool
{
	public partial class frmUpdate : Form
	{
		private Config cfg;
		private List<Source> srcs = new List<Source>();
		public frmUpdate(Config cfg)
		{
			InitializeComponent();
			this.cfg = cfg;
			updateView();
		}

		private void frmUpdate_Load(object sender, EventArgs e)
		{
			updateView();
		}

		private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstSource.SelectedItems.Count == 1)
			{
				Source src = (Source)lstSource.SelectedItem;
				lblName.Text = src.name;
				lblDescription.Text = src.description;
				lblAddress.Text = src.address;
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (lstSource.SelectedItems.Count == 1) 
			{
				Source src = (Source)lstSource.SelectedItem;
				frmBrowser fb = new frmBrowser();
				fb.load(src.html);
				fb.Show();
			}
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			if (lstSource.SelectedItems.Count == 1)
			{
				Source src = (Source)lstSource.SelectedItem;
				new frmShow(src).ShowDialog();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			File.Delete("C:\\HostsManager\\" + ((Source)lstSource.SelectedItem).internalName + ".json");
			cfg.updateSource.Remove(((Source)lstSource.SelectedItem).internalName);
			updateView();
		}

		private void updateView()
		{
			lstSource.Items.Clear();
			srcs.Clear();
			foreach (string sr in cfg.updateSource)
				try
				{
					srcs.Add(JsonConvert.DeserializeObject<Source>(File.ReadAllText("C:\\HostsManager\\" + sr + ".json")));
				}
				catch (IOException)
				{
					cfg.updateSource.Remove(sr);
					return;
				}
			foreach (Source src in srcs)
				lstSource.Items.Add(src, src.enabled);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string address = Interaction.InputBox("源地址：", "增加源", "http://");
				HttpWebRequest hwr = WebRequest.CreateHttp(address);
				hwr.Method = "GET";
				HttpWebResponse resp = hwr.GetResponse() as HttpWebResponse;
				if(resp.ContentLength > 0 && resp.StatusCode == HttpStatusCode.OK && resp.ContentType == "application/json")
				{
					string str;
					using (StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
					{
						str = reader.ReadToEnd();
					}
					Source src = JsonConvert.DeserializeObject<Source>(str);
					File.WriteAllText("C:\\HostsManager\\" + src.internalName + ".json", str);
					cfg.updateSource.Add(src.internalName);
					frmBrowser fb = new frmBrowser();
					fb.load(src.html);
					fb.ShowDialog();
					updateView();
				}
				else if(resp.StatusCode == HttpStatusCode.NotFound)
					MessageBox.Show("源未找到，你确定你的URL填对了吗？\n404", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show("服务器错误：\n" + resp.StatusCode, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				resp.Close();
			}
			catch (WebException exc)
			{
				MessageBox.Show("Web异常：" + exc, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (SocketException)
			{
				MessageBox.Show("服务器连接错误/文件读写错误，你确定你的URL填对了，并且网络环境正常，并有权限读写文件吗？", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (IOException)
			{
				MessageBox.Show("服务器连接错误/文件读写错误，你确定你的URL填对了，并且网络环境正常，并有权限读写文件吗？", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdateNow_Click(object sender, EventArgs e)
		{
			updateLocal();
			cfg.lastChanged = DateTime.UtcNow;
			string json = JsonConvert.SerializeObject(cfg);
			File.WriteAllText("C:\\HostsManager\\config.json", json);
			try
			{
				TcpClient tc = new TcpClient();
				tc.Connect("127.0.0.1", 8885);
				StreamWriter writer = new StreamWriter(tc.GetStream());
				writer.Write("supdate");
				MessageBox.Show("已经提交。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				tc.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("连接到HostsManager服务失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lstSource_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			lstSource_SelectedIndexChanged(sender, e);
		}

		private void frmUpdate_FormClosed(object sender, FormClosedEventArgs e)
		{
			updateLocal();
		}

		private void updateLocal()
		{
			for (int i = 0; i < lstSource.Items.Count; i++)
			{
				Source src = lstSource.Items[i] as Source;
				foreach (string s in cfg.updateSource)
					if (src.internalName == s)
						src.enabled = lstSource.GetItemChecked(lstSource.Items.IndexOf(src));
			}
			foreach (Source s in srcs)
			{
				StreamWriter sw = new StreamWriter("C:\\HostsManager\\" + s.internalName + ".json");
				sw.Write(JsonConvert.SerializeObject(s));
				sw.Close();
			}
		}
	}
}
