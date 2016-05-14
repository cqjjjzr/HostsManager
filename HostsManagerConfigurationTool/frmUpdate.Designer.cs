namespace HostsManagerConfigurationTool
{
	partial class frmUpdate
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.lblDescription = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdateNow = new System.Windows.Forms.Button();
			this.lstSource = new System.Windows.Forms.CheckedListBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnShow);
			this.panel1.Controls.Add(this.btnBrowse);
			this.panel1.Controls.Add(this.lblDescription);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lblAddress);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.lblName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(204, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(453, 160);
			this.panel1.TabIndex = 1;
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(6, 129);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(442, 23);
			this.btnShow.TabIndex = 7;
			this.btnShow.Text = "显示此源当前内容";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(6, 99);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(442, 23);
			this.btnBrowse.TabIndex = 6;
			this.btnBrowse.Text = "打开说明";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(42, 51);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(406, 45);
			this.lblDescription.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "描述：：";
			// 
			// lblAddress
			// 
			this.lblAddress.Location = new System.Drawing.Point(42, 30);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(406, 12);
			this.lblAddress.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "地址：";
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(42, 9);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(406, 12);
			this.lblName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "名称：";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(204, 180);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(453, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "增加源";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(13, 180);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(184, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "删除选中项";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdateNow
			// 
			this.btnUpdateNow.Location = new System.Drawing.Point(13, 210);
			this.btnUpdateNow.Name = "btnUpdateNow";
			this.btnUpdateNow.Size = new System.Drawing.Size(644, 23);
			this.btnUpdateNow.TabIndex = 4;
			this.btnUpdateNow.Text = "现在更新";
			this.btnUpdateNow.UseVisualStyleBackColor = true;
			this.btnUpdateNow.Click += new System.EventHandler(this.btnUpdateNow_Click);
			// 
			// lstSource
			// 
			this.lstSource.FormattingEnabled = true;
			this.lstSource.Location = new System.Drawing.Point(13, 13);
			this.lstSource.Name = "lstSource";
			this.lstSource.Size = new System.Drawing.Size(184, 164);
			this.lstSource.TabIndex = 5;
			this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged_1);
			// 
			// frmUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 248);
			this.Controls.Add(this.lstSource);
			this.Controls.Add(this.btnUpdateNow);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.panel1);
			this.Name = "frmUpdate";
			this.Text = "自动更新源设置";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdate_FormClosed);
			this.Load += new System.EventHandler(this.frmUpdate_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdateNow;
		private System.Windows.Forms.CheckedListBox lstSource;
	}
}