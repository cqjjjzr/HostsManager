namespace HostsManagerConfigurationTool
{
	partial class frmFirst
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblComment = new System.Windows.Forms.Label();
			this.lblComment2 = new System.Windows.Forms.Label();
			this.btnWizard = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblTitle.Location = new System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(242, 25);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "欢迎使用HostsManager！";
			// 
			// lblComment
			// 
			this.lblComment.Location = new System.Drawing.Point(15, 45);
			this.lblComment.Name = "lblComment";
			this.lblComment.Size = new System.Drawing.Size(257, 80);
			this.lblComment.TabIndex = 1;
			this.lblComment.Text = "HostsManager是一个自动管理系统Hosts的便捷工具。\r\nHosts管理了一个数据库，优先于DNS进行域名解析。\r\n有时候，Hosts能强行解析域名，达" +
	"到一些（笑）的效果。";
			// 
			// lblComment2
			// 
			this.lblComment2.Location = new System.Drawing.Point(15, 125);
			this.lblComment2.Name = "lblComment2";
			this.lblComment2.Size = new System.Drawing.Size(252, 33);
			this.lblComment2.TabIndex = 2;
			this.lblComment2.Text = "第一次运行HostsManager，请执行设置。";
			// 
			// btnWizard
			// 
			this.btnWizard.Location = new System.Drawing.Point(12, 146);
			this.btnWizard.Name = "btnWizard";
			this.btnWizard.Size = new System.Drawing.Size(260, 27);
			this.btnWizard.TabIndex = 3;
			this.btnWizard.Text = "设置";
			this.btnWizard.UseVisualStyleBackColor = true;
			this.btnWizard.Click += new System.EventHandler(this.btnWizard_Click);
			// 
			// frmFirst
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 182);
			this.Controls.Add(this.btnWizard);
			this.Controls.Add(this.lblComment2);
			this.Controls.Add(this.lblComment);
			this.Controls.Add(this.lblTitle);
			this.Name = "frmFirst";
			this.Text = "第一次运行";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblComment;
		private System.Windows.Forms.Label lblComment2;
		private System.Windows.Forms.Button btnWizard;
	}
}