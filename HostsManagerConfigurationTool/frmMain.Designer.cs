namespace HostsManagerConfigurationTool
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustom = new System.Windows.Forms.Label();
            this.treCustom = new System.Windows.Forms.TreeView();
            this.btnAddSequence = new System.Windows.Forms.Button();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnServerConfig = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Location = new System.Drawing.Point(338, 9);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(113, 12);
            this.lblCustom.TabIndex = 0;
            this.lblCustom.Text = "自定义Hosts项 配置";
            // 
            // treCustom
            // 
            this.treCustom.CheckBoxes = true;
            this.treCustom.Location = new System.Drawing.Point(13, 33);
            this.treCustom.Name = "treCustom";
            this.treCustom.Size = new System.Drawing.Size(813, 256);
            this.treCustom.TabIndex = 1;
            this.treCustom.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treCustom_AfterCheck);
            // 
            // btnAddSequence
            // 
            this.btnAddSequence.Location = new System.Drawing.Point(13, 296);
            this.btnAddSequence.Name = "btnAddSequence";
            this.btnAddSequence.Size = new System.Drawing.Size(75, 23);
            this.btnAddSequence.TabIndex = 2;
            this.btnAddSequence.Text = "增加段";
            this.btnAddSequence.UseVisualStyleBackColor = true;
            this.btnAddSequence.Click += new System.EventHandler(this.btnAddSequence_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(95, 296);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(75, 23);
            this.btnAddEntry.TabIndex = 3;
            this.btnAddEntry.Text = "增加项";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除选中段/项";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(286, 296);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "移动选中项";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 380);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(813, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "应用到系统";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnServerConfig
            // 
            this.btnServerConfig.Location = new System.Drawing.Point(13, 325);
            this.btnServerConfig.Name = "btnServerConfig";
            this.btnServerConfig.Size = new System.Drawing.Size(813, 23);
            this.btnServerConfig.TabIndex = 7;
            this.btnServerConfig.Text = "自动更新源设置";
            this.btnServerConfig.UseVisualStyleBackColor = true;
            this.btnServerConfig.Click += new System.EventHandler(this.btnServerConfig_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(368, 296);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "编辑选中项";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(450, 296);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(139, 23);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "从Hosts格式批量导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(595, 300);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "自动展开树节点";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 415);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnServerConfig);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.btnAddSequence);
            this.Controls.Add(this.treCustom);
            this.Controls.Add(this.lblCustom);
            this.Name = "frmMain";
            this.Text = "HostsManager 配置实用工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.Button btnAddSequence;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.TreeView treCustom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnServerConfig;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

