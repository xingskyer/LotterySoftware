namespace LotterySoftware
{
    partial class frmCreatePersonnelData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatePersonnelData));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPersonnelActive = new System.Windows.Forms.ComboBox();
            this.txtPersonnelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonnelNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbAddPersonnel = new System.Windows.Forms.ToolStripButton();
            this.tsbModifyPersonnel = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelPersonnel = new System.Windows.Forms.ToolStripButton();
            this.tsbSavePersonnel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeletePersonnel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDataList);
            this.groupBox2.Location = new System.Drawing.Point(9, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 247);
            this.groupBox2.TabIndex = 245;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "现有人员信息";
            // 
            // dgvDataList
            // 
            this.dgvDataList.AllowUserToAddRows = false;
            this.dgvDataList.AllowUserToDeleteRows = false;
            this.dgvDataList.AllowUserToResizeColumns = false;
            this.dgvDataList.AllowUserToResizeRows = false;
            this.dgvDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDataList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataList.Location = new System.Drawing.Point(10, 18);
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.ReadOnly = true;
            this.dgvDataList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDataList.RowTemplate.Height = 23;
            this.dgvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataList.Size = new System.Drawing.Size(646, 221);
            this.dgvDataList.TabIndex = 88;
            this.dgvDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataList_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbPersonnelActive);
            this.groupBox1.Controls.Add(this.txtPersonnelName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonnelNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 51);
            this.groupBox1.TabIndex = 244;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "是否参加抽奖";
            // 
            // cbbPersonnelActive
            // 
            this.cbbPersonnelActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPersonnelActive.FormattingEnabled = true;
            this.cbbPersonnelActive.Items.AddRange(new object[] {
            " ",
            "参加抽奖",
            "不参加抽奖"});
            this.cbbPersonnelActive.Location = new System.Drawing.Point(480, 20);
            this.cbbPersonnelActive.Name = "cbbPersonnelActive";
            this.cbbPersonnelActive.Size = new System.Drawing.Size(121, 20);
            this.cbbPersonnelActive.TabIndex = 6;
            // 
            // txtPersonnelName
            // 
            this.txtPersonnelName.Location = new System.Drawing.Point(48, 20);
            this.txtPersonnelName.Name = "txtPersonnelName";
            this.txtPersonnelName.Size = new System.Drawing.Size(169, 21);
            this.txtPersonnelName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // txtPersonnelNumber
            // 
            this.txtPersonnelNumber.Location = new System.Drawing.Point(286, 20);
            this.txtPersonnelNumber.Name = "txtPersonnelNumber";
            this.txtPersonnelNumber.Size = new System.Drawing.Size(91, 21);
            this.txtPersonnelNumber.TabIndex = 5;
            this.txtPersonnelNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonnelNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "编号";
            // 
            // tsTools
            // 
            this.tsTools.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbAddPersonnel,
            this.tsbModifyPersonnel,
            this.tsbCancelPersonnel,
            this.tsbSavePersonnel,
            this.toolStripSeparator2,
            this.tsbDeletePersonnel,
            this.tsbExit});
            this.tsTools.Location = new System.Drawing.Point(0, 0);
            this.tsTools.Name = "tsTools";
            this.tsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTools.Size = new System.Drawing.Size(678, 56);
            this.tsTools.TabIndex = 243;
            this.tsTools.Text = "toolStrip1";
            this.tsTools.Paint += new System.Windows.Forms.PaintEventHandler(this.tsTools_Paint);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(12, 53);
            this.toolStripLabel1.Text = " ";
            // 
            // tsbAddPersonnel
            // 
            this.tsbAddPersonnel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbAddPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddPersonnel.Image")));
            this.tsbAddPersonnel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddPersonnel.Name = "tsbAddPersonnel";
            this.tsbAddPersonnel.Size = new System.Drawing.Size(60, 53);
            this.tsbAddPersonnel.Text = "添加人员";
            this.tsbAddPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddPersonnel.Click += new System.EventHandler(this.tsbAddPersonnel_Click);
            // 
            // tsbModifyPersonnel
            // 
            this.tsbModifyPersonnel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbModifyPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("tsbModifyPersonnel.Image")));
            this.tsbModifyPersonnel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifyPersonnel.Name = "tsbModifyPersonnel";
            this.tsbModifyPersonnel.Size = new System.Drawing.Size(60, 53);
            this.tsbModifyPersonnel.Text = "修改人员";
            this.tsbModifyPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModifyPersonnel.Click += new System.EventHandler(this.tsbModifyPersonnel_Click);
            // 
            // tsbCancelPersonnel
            // 
            this.tsbCancelPersonnel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbCancelPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelPersonnel.Image")));
            this.tsbCancelPersonnel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelPersonnel.Name = "tsbCancelPersonnel";
            this.tsbCancelPersonnel.Size = new System.Drawing.Size(60, 53);
            this.tsbCancelPersonnel.Text = "取消修改";
            this.tsbCancelPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelPersonnel.Click += new System.EventHandler(this.tsbCancelPersonnel_Click);
            // 
            // tsbSavePersonnel
            // 
            this.tsbSavePersonnel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbSavePersonnel.Image = ((System.Drawing.Image)(resources.GetObject("tsbSavePersonnel.Image")));
            this.tsbSavePersonnel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSavePersonnel.Name = "tsbSavePersonnel";
            this.tsbSavePersonnel.Size = new System.Drawing.Size(60, 53);
            this.tsbSavePersonnel.Text = "保存人员";
            this.tsbSavePersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSavePersonnel.Click += new System.EventHandler(this.tsbSavePersonnel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbDeletePersonnel
            // 
            this.tsbDeletePersonnel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeletePersonnel.Image")));
            this.tsbDeletePersonnel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletePersonnel.Name = "tsbDeletePersonnel";
            this.tsbDeletePersonnel.Size = new System.Drawing.Size(60, 53);
            this.tsbDeletePersonnel.Text = "删除人员";
            this.tsbDeletePersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeletePersonnel.Click += new System.EventHandler(this.tsbDeletePersonnel_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(36, 53);
            this.tsbExit.Text = "退出";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // frmCreatePersonnelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(678, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreatePersonnelData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽奖人员信息录入";
            this.Load += new System.EventHandler(this.frmCreateHumanData_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPersonnelActive;
        private System.Windows.Forms.TextBox txtPersonnelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbAddPersonnel;
        private System.Windows.Forms.ToolStripButton tsbModifyPersonnel;
        private System.Windows.Forms.ToolStripButton tsbCancelPersonnel;
        private System.Windows.Forms.ToolStripButton tsbSavePersonnel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDeletePersonnel;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.TextBox txtPersonnelNumber;
        private System.Windows.Forms.Label label3;
    }
}