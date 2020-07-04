namespace LotterySoftware
{
    partial class frmCreateGiftData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateGiftData));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbGiftActive = new System.Windows.Forms.ComboBox();
            this.txtGiftName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiftCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbAddGift = new System.Windows.Forms.ToolStripButton();
            this.tsbModifyGift = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveGift = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
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
            this.groupBox2.Location = new System.Drawing.Point(10, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 247);
            this.groupBox2.TabIndex = 242;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "现在奖品信息";
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
            this.groupBox1.Controls.Add(this.cbbGiftActive);
            this.groupBox1.Controls.Add(this.txtGiftName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiftCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 51);
            this.groupBox1.TabIndex = 241;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "是否参加抽奖";
            // 
            // cbbGiftActive
            // 
            this.cbbGiftActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGiftActive.FormattingEnabled = true;
            this.cbbGiftActive.Items.AddRange(new object[] {
            " ",
            "参加抽奖",
            "不参加抽奖"});
            this.cbbGiftActive.Location = new System.Drawing.Point(503, 20);
            this.cbbGiftActive.Name = "cbbGiftActive";
            this.cbbGiftActive.Size = new System.Drawing.Size(121, 20);
            this.cbbGiftActive.TabIndex = 6;
            // 
            // txtGiftName
            // 
            this.txtGiftName.Location = new System.Drawing.Point(71, 20);
            this.txtGiftName.Name = "txtGiftName";
            this.txtGiftName.Size = new System.Drawing.Size(169, 21);
            this.txtGiftName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "奖品名称";
            // 
            // txtGiftCount
            // 
            this.txtGiftCount.Location = new System.Drawing.Point(309, 20);
            this.txtGiftCount.Name = "txtGiftCount";
            this.txtGiftCount.Size = new System.Drawing.Size(91, 21);
            this.txtGiftCount.TabIndex = 5;
            this.txtGiftCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiftCount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "奖品数量";
            // 
            // tsTools
            // 
            this.tsTools.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbAddGift,
            this.tsbModifyGift,
            this.tsbCancel,
            this.tsbSaveGift,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.tsbExit});
            this.tsTools.Location = new System.Drawing.Point(0, 0);
            this.tsTools.Name = "tsTools";
            this.tsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTools.Size = new System.Drawing.Size(681, 56);
            this.tsTools.TabIndex = 240;
            this.tsTools.Text = "toolStrip1";
            this.tsTools.Paint += new System.Windows.Forms.PaintEventHandler(this.tsTools_Paint);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(12, 53);
            this.toolStripLabel1.Text = " ";
            // 
            // tsbAddGift
            // 
            this.tsbAddGift.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbAddGift.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddGift.Image")));
            this.tsbAddGift.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddGift.Name = "tsbAddGift";
            this.tsbAddGift.Size = new System.Drawing.Size(60, 53);
            this.tsbAddGift.Text = "添加奖品";
            this.tsbAddGift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddGift.Click += new System.EventHandler(this.tsbAddGift_Click);
            // 
            // tsbModifyGift
            // 
            this.tsbModifyGift.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbModifyGift.Image = ((System.Drawing.Image)(resources.GetObject("tsbModifyGift.Image")));
            this.tsbModifyGift.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifyGift.Name = "tsbModifyGift";
            this.tsbModifyGift.Size = new System.Drawing.Size(60, 53);
            this.tsbModifyGift.Text = "修改奖品";
            this.tsbModifyGift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModifyGift.Click += new System.EventHandler(this.tsbModifyGift_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(60, 53);
            this.tsbCancel.Text = "取消修改";
            this.tsbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbSaveGift
            // 
            this.tsbSaveGift.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbSaveGift.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveGift.Image")));
            this.tsbSaveGift.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveGift.Name = "tsbSaveGift";
            this.tsbSaveGift.Size = new System.Drawing.Size(60, 53);
            this.tsbSaveGift.Text = "保存奖品";
            this.tsbSaveGift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSaveGift.Click += new System.EventHandler(this.tsbSaveGift_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 53);
            this.tsbDelete.Text = "删除奖品";
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
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
            // frmCreateGiftData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(681, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateGiftData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "奖品数据录入";
            this.Load += new System.EventHandler(this.frmCreateGiftData_Load);
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
        private System.Windows.Forms.ComboBox cbbGiftActive;
        private System.Windows.Forms.TextBox txtGiftName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiftCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbAddGift;
        private System.Windows.Forms.ToolStripButton tsbModifyGift;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbSaveGift;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbExit;
    }
}