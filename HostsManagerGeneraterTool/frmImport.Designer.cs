namespace HostsManagerGeneraterTool
{
	partial class frmImport
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSequence = new System.Windows.Forms.TextBox();
			this.txtHosts = new System.Windows.Forms.TextBox();
			this.btnImport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "导入到段：";
			// 
			// txtSequence
			// 
			this.txtSequence.Location = new System.Drawing.Point(84, 10);
			this.txtSequence.Name = "txtSequence";
			this.txtSequence.Size = new System.Drawing.Size(467, 21);
			this.txtSequence.TabIndex = 1;
			// 
			// txtHosts
			// 
			this.txtHosts.Location = new System.Drawing.Point(14, 37);
			this.txtHosts.Multiline = true;
			this.txtHosts.Name = "txtHosts";
			this.txtHosts.Size = new System.Drawing.Size(538, 244);
			this.txtHosts.TabIndex = 2;
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(13, 288);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(538, 23);
			this.btnImport.TabIndex = 3;
			this.btnImport.Text = "导入";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// frmImport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 317);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.txtHosts);
			this.Controls.Add(this.txtSequence);
			this.Controls.Add(this.label1);
			this.Name = "frmImport";
			this.Text = "从Hosts格式导入";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSequence;
		private System.Windows.Forms.TextBox txtHosts;
		private System.Windows.Forms.Button btnImport;
	}
}