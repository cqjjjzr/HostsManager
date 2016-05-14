namespace HostsManagerGeneraterTool
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
				components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnImport = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnMove = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAddSequence = new System.Windows.Forms.Button();
			this.treCustom = new System.Windows.Forms.TreeView();
			this.mnuOpen = new System.Windows.Forms.Button();
			this.mnuSave = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDestAddress = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.txtInternalName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIntro = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.chkAutoExpand = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(452, 245);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(139, 23);
			this.btnImport.TabIndex = 16;
			this.btnImport.Text = "从Hosts格式批量导入";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(370, 245);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 15;
			this.btnEdit.Text = "编辑选中项";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnMove
			// 
			this.btnMove.Location = new System.Drawing.Point(288, 245);
			this.btnMove.Name = "btnMove";
			this.btnMove.Size = new System.Drawing.Size(75, 23);
			this.btnMove.TabIndex = 14;
			this.btnMove.Text = "移动选中项";
			this.btnMove.UseVisualStyleBackColor = true;
			this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(179, 245);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(103, 23);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "删除选中段/项";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(97, 245);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "增加项";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAddSequence
			// 
			this.btnAddSequence.Location = new System.Drawing.Point(15, 245);
			this.btnAddSequence.Name = "btnAddSequence";
			this.btnAddSequence.Size = new System.Drawing.Size(75, 23);
			this.btnAddSequence.TabIndex = 11;
			this.btnAddSequence.Text = "增加段";
			this.btnAddSequence.UseVisualStyleBackColor = true;
			this.btnAddSequence.Click += new System.EventHandler(this.btnAddSequence_Click);
			// 
			// treCustom
			// 
			this.treCustom.CheckBoxes = true;
			this.treCustom.Location = new System.Drawing.Point(12, 41);
			this.treCustom.Name = "treCustom";
			this.treCustom.Size = new System.Drawing.Size(813, 186);
			this.treCustom.TabIndex = 10;
			this.treCustom.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treCustom_AfterCheck);
			// 
			// mnuOpen
			// 
			this.mnuOpen.Location = new System.Drawing.Point(12, 12);
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Size = new System.Drawing.Size(75, 23);
			this.mnuOpen.TabIndex = 17;
			this.mnuOpen.Text = "打开";
			this.mnuOpen.UseVisualStyleBackColor = true;
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// mnuSave
			// 
			this.mnuSave.Location = new System.Drawing.Point(94, 12);
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size(75, 23);
			this.mnuSave.TabIndex = 18;
			this.mnuSave.Text = "保存";
			this.mnuSave.UseVisualStyleBackColor = true;
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(293, 12);
			this.label2.TabIndex = 21;
			this.label2.Text = "服务器目标地址（重要，文件名为内部名称+.json）：";
			// 
			// txtDestAddress
			// 
			this.txtDestAddress.Location = new System.Drawing.Point(314, 295);
			this.txtDestAddress.Name = "txtDestAddress";
			this.txtDestAddress.Size = new System.Drawing.Size(514, 21);
			this.txtDestAddress.TabIndex = 22;
			this.txtDestAddress.Text = "http://";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// txtInternalName
			// 
			this.txtInternalName.Location = new System.Drawing.Point(236, 328);
			this.txtInternalName.Name = "txtInternalName";
			this.txtInternalName.Size = new System.Drawing.Size(592, 21);
			this.txtInternalName.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 331);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 12);
			this.label1.TabIndex = 23;
			this.label1.Text = "取个内部名称（只能含字母数字和.）：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 363);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 25;
			this.label3.Text = "源名称：";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(74, 360);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(754, 21);
			this.txtName.TabIndex = 26;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(74, 396);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(754, 21);
			this.txtDescription.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 399);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 27;
			this.label4.Text = "源说明：";
			// 
			// txtIntro
			// 
			this.txtIntro.Location = new System.Drawing.Point(17, 434);
			this.txtIntro.Multiline = true;
			this.txtIntro.Name = "txtIntro";
			this.txtIntro.Size = new System.Drawing.Size(811, 145);
			this.txtIntro.TabIndex = 30;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 420);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(305, 12);
			this.label5.TabIndex = 29;
			this.label5.Text = "源简介（会出现在第一次添加源时，可使用html代码）：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 596);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 12);
			this.label6.TabIndex = 32;
			this.label6.Text = "版本号（数字）：";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(122, 594);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			1316134912,
			2328,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(706, 21);
			this.numericUpDown1.TabIndex = 33;
			this.numericUpDown1.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// chkAutoExpand
			// 
			this.chkAutoExpand.AutoSize = true;
			this.chkAutoExpand.Location = new System.Drawing.Point(597, 249);
			this.chkAutoExpand.Name = "chkAutoExpand";
			this.chkAutoExpand.Size = new System.Drawing.Size(84, 16);
			this.chkAutoExpand.TabIndex = 34;
			this.chkAutoExpand.Text = "自动展开树";
			this.chkAutoExpand.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 621);
			this.Controls.Add(this.chkAutoExpand);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtIntro);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtInternalName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDestAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mnuSave);
			this.Controls.Add(this.mnuOpen);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnMove);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnAddSequence);
			this.Controls.Add(this.treCustom);
			this.Name = "frmMain";
			this.Text = "HostsManager 服务器配置生成工具";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnMove;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAddSequence;
		private System.Windows.Forms.TreeView treCustom;
		private System.Windows.Forms.Button mnuOpen;
		private System.Windows.Forms.Button mnuSave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDestAddress;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.TextBox txtInternalName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIntro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox chkAutoExpand;
	}
}

