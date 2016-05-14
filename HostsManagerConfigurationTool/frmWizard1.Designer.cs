namespace HostsManagerConfigurationTool
{
    partial class frmWizard1
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUpdateTime = new System.Windows.Forms.Label();
            this.cbxUpdateTime = new System.Windows.Forms.ComboBox();
            this.lblImport = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnNoImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpdateTime
            // 
            this.lblUpdateTime.AutoSize = true;
            this.lblUpdateTime.Location = new System.Drawing.Point(12, 16);
            this.lblUpdateTime.Name = "lblUpdateTime";
            this.lblUpdateTime.Size = new System.Drawing.Size(89, 12);
            this.lblUpdateTime.TabIndex = 0;
            this.lblUpdateTime.Text = "更新检查周期：";
            // 
            // cbxUpdateTime
            // 
            this.cbxUpdateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpdateTime.FormattingEnabled = true;
            this.cbxUpdateTime.Items.AddRange(new object[] {
            "1 天",
            "3 天",
            "1 周",
            "2 周",
            "1 月"});
            this.cbxUpdateTime.Location = new System.Drawing.Point(109, 13);
            this.cbxUpdateTime.Name = "cbxUpdateTime";
            this.cbxUpdateTime.Size = new System.Drawing.Size(276, 20);
            this.cbxUpdateTime.TabIndex = 1;
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(14, 43);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(239, 12);
            this.lblImport.TabIndex = 2;
            this.lblImport.Text = "第一次运行，推荐从系统现有Hosts导入项。";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(13, 59);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(372, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnNoImport
            // 
            this.btnNoImport.Location = new System.Drawing.Point(13, 88);
            this.btnNoImport.Name = "btnNoImport";
            this.btnNoImport.Size = new System.Drawing.Size(372, 23);
            this.btnNoImport.TabIndex = 4;
            this.btnNoImport.Text = "不导入";
            this.btnNoImport.UseVisualStyleBackColor = true;
            this.btnNoImport.Click += new System.EventHandler(this.btnNoImport_Click);
            // 
            // frmWizard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 117);
            this.Controls.Add(this.btnNoImport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.cbxUpdateTime);
            this.Controls.Add(this.lblUpdateTime);
            this.Name = "frmWizard1";
            this.Text = "HostsManager第一次运行设置";
            this.Load += new System.EventHandler(this.frmWizard1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateTime;
        private System.Windows.Forms.ComboBox cbxUpdateTime;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnNoImport;
    }
}