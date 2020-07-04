using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LotterySoftware
{
    public partial class frmCreateGiftData : Form
    {
        public frmCreateGiftData()
        {
            InitializeComponent();
        }
        Boolean IsUpdate = false;
        string GiftID = "";
        private void frmCreateGiftData_Load(object sender, EventArgs e)
        {
            //dgvDataList.RowsDefaultCellStyle.BackColor = Color.Thistle;  //奇数行颜色
            dgvDataList.AlternatingRowsDefaultCellStyle.BackColor = Color.Linen; //偶数行颜色
            dgvDataList.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行
            dgvDataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // 设定包括Header和所有单元格的列宽自动调整
            dgvDataList.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行,设定不包括Header所有单元格的行高自动调整
            dgvDataList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;  //AllCells;设定包括Header和所有单元格的行高自动调整            
            LoadGiftDataInformation();

            tsbModifyGift.Enabled = false;
            tsbCancel.Enabled = false;
            tsbDelete.Enabled = false;
            tsbSaveGift.Enabled = false;

            txtGiftName.ReadOnly = true;
            txtGiftCount.ReadOnly = true;
            cbbGiftActive.Enabled = false;
        }

        private void tsbAddGift_Click(object sender, EventArgs e)
        {
            tsbAddGift.Enabled = false;
            tsbModifyGift.Enabled = false;
            tsbCancel.Enabled = true;
            tsbSaveGift.Enabled = true;
            tsbDelete.Enabled = false;
            txtGiftName.ReadOnly = false;
            txtGiftCount.ReadOnly = false;
            cbbGiftActive.Enabled = true;

            txtGiftName.Text = "";
            txtGiftCount.Text = "";
            cbbGiftActive.Text = " ";
            IsUpdate = false;
        }

        private void tsbModifyGift_Click(object sender, EventArgs e)
        {
            tsbAddGift.Enabled = false;
            tsbModifyGift.Enabled = false;
            tsbCancel.Enabled = true;
            tsbSaveGift.Enabled = true;
            tsbDelete.Enabled = false;

            txtGiftName.ReadOnly = false;
            txtGiftCount.ReadOnly = false;
            cbbGiftActive.Enabled = true;

            IsUpdate = true;
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            tsbAddGift.Enabled = true;
            tsbModifyGift.Enabled = false;
            tsbCancel.Enabled = false;
            tsbSaveGift.Enabled = false;
            tsbDelete.Enabled = false;
            txtGiftName.ReadOnly = true;
            txtGiftCount.ReadOnly = true;
            cbbGiftActive.Enabled = false;

            txtGiftCount.Text = "";
            txtGiftName.Text = "";
            cbbGiftActive.Text = " ";
        }

        private void tsbSaveGift_Click(object sender, EventArgs e)
        {
            if (txtGiftName.Text.Trim() == "")
            {
                MessageBox.Show("请输入参加抽奖的礼品名称.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiftName.Focus();
                return;
            }
            if (txtGiftCount.Text.Trim() == "")
            {
                MessageBox.Show("请输入参加抽奖的礼品数量.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiftCount.Focus();
                return;
            }
            if (cbbGiftActive.Text.Trim() == "")
            {
                MessageBox.Show("请选择是否加入抽奖.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbGiftActive.Focus();
                return;
            }
            SaveGiftDataToDatabase();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除这个奖品吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strSQL = "DELETE FROM tb_GiftInfo WHERE GiftID='" + GiftID + "'";
                if (DataAccess.ExcuteNonQuery(strSQL) > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGiftName.Text = "";
                    txtGiftCount.Text = "";
                    cbbGiftActive.Text = " ";
                    tsbAddGift.Enabled = true;
                    tsbModifyGift.Enabled = false;
                    tsbSaveGift.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbCancel.Enabled = false;
                    LoadGiftDataInformation();
                }
                else
                {
                    MessageBox.Show("删除失败,请重试.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiftCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataList.Rows.Count > 0)
            {
                if (tsbSaveGift.Enabled)
                {
                    tsbAddGift.Enabled = true;
                    tsbModifyGift.Enabled = false;
                    tsbCancel.Enabled = false;
                    tsbSaveGift.Enabled = false;
                    tsbDelete.Enabled = false;
                    txtGiftName.ReadOnly = true;
                    txtGiftCount.ReadOnly = true;
                    cbbGiftActive.Enabled = false;

                    txtGiftCount.Text = "";
                    txtGiftName.Text = "";
                    cbbGiftActive.Text = " ";
                }
                int index = dgvDataList.CurrentRow.Index;
                string GiftName = dgvDataList.Rows[index].Cells[1].Value.ToString().Trim();
                GetDataInfoToText(GiftName);
            }
        }

        private void tsTools_Paint(object sender, PaintEventArgs e)
        {
            //重画工具栏,避免出现下横线不好看
            if ((sender as ToolStrip).RenderMode == ToolStripRenderMode.System)
            {
                Rectangle rect = new Rectangle(0, 0, this.tsTools.Width, this.tsTools.Height - 2);
                e.Graphics.SetClip(rect);
            }
        }
        private void LoadGiftDataInformation()
        {
            string strSQL = "SELECT GiftID,GiftName AS 奖品名称,GiftCount AS 奖品数量, GiftActive AS 是否加入抽奖, AddDate AS 添加日期, ModifyDate AS 修改日期 FROM tb_GiftInfo";
            dgvDataList.DataSource = DataAccess.GetDataTable(strSQL);
            dgvDataList.Columns[0].Visible = false;
            dgvDataList.ClearSelection();
        }
        private void GetDataInfoToText(string strGiftName)
        {
            string SQLSelect = "SELECT GiftID,GiftName,GiftCount,GiftActive FROM tb_GiftInfo WHERE GiftName='" + strGiftName + "'";
            try
            {
                DataTable dt = DataAccess.GetDataTable(SQLSelect);
                if (dt.Rows.Count > 0)
                {
                    GiftID = dt.Rows[0]["GiftID"].ToString();
                    txtGiftName.Text = dt.Rows[0]["GiftName"].ToString();
                    txtGiftCount.Text = dt.Rows[0]["GiftCount"].ToString();
                    if (dt.Rows[0]["GiftActive"].ToString() != null)
                    {
                        if (Convert.ToBoolean(dt.Rows[0]["GiftActive"].ToString()) == true)
                        {
                            cbbGiftActive.Text = "参加抽奖";
                        }
                        else
                        {
                            cbbGiftActive.Text = "不参加抽奖";
                        }
                    }
                    tsbDelete.Enabled = true;
                    tsbModifyGift.Enabled = true;
                    tsbAddGift.Enabled = true;
                }
            }
            catch
            {

            }
        }
        private string GetGiftRecordExist(string strGiftName)
        {
            string SQLSelect = "SELECT GiftID FROM tb_GiftInfo WHERE GiftName='" + strGiftName;
            return DataAccess.ExecuteScalar(SQLSelect);
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        private void SaveGiftDataToDatabase()
        {
            string OptSQL = "";
            if (IsUpdate)
            {
                if (MessageBox.Show("确认保存吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int GiftA;
                    if (cbbGiftActive.Text.Trim() == "参加抽奖")
                    {
                        GiftA = 1;
                    }
                    else
                    {
                        GiftA = 0;
                    }
                    OptSQL = "UPDATE tb_GiftInfo SET GiftName='" + txtGiftName.Text.Trim() + "',GiftCount='" + txtGiftCount.Text.Trim() + "',GiftActive='" + GiftA + "',ModifyDate='" + DateTime.Now + "' WHERE GiftID='" + GiftID + "'";

                    if (DataAccess.ExcuteNonQuery(OptSQL) > 0)
                    {
                        MessageBox.Show("保存成功.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGiftName.Text = "";
                        txtGiftCount.Text = "";
                        cbbGiftActive.Text = " ";
                        tsbAddGift.Enabled = true;
                        tsbModifyGift.Enabled = false;
                        tsbSaveGift.Enabled = false;
                        tsbDelete.Enabled = false;
                        tsbCancel.Enabled = false;

                        txtGiftName.ReadOnly = true;
                        txtGiftCount.ReadOnly = true;
                        cbbGiftActive.Enabled = false;
                        LoadGiftDataInformation();
                    }
                    else
                    {
                        MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("确认添加奖品吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GetGiftRecordExist(txtGiftName.Text.Trim()) == null)
                    {
                        int GiftA;
                        if (cbbGiftActive.Text.Trim() == "参加抽奖")
                        {
                            GiftA = 1;
                        }
                        else
                        {
                            GiftA = 0;
                        }
                        OptSQL = "INSERT INTO tb_GiftInfo(GiftID,GiftName,GiftCount,GiftActive,addDate,ModifyDate) values('" + Guid.NewGuid().ToString() + "','" + txtGiftName.Text.Trim() + "','" + txtGiftCount.Text.Trim() + "','" + GiftA + "','" + DateTime.Now + "','" + DateTime.Now + "')";
                        if (DataAccess.ExcuteNonQuery(OptSQL) > 0)
                        {
                            MessageBox.Show("保存成功.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtGiftName.Text = "";
                            txtGiftCount.Text = "";
                            cbbGiftActive.Text = " ";
                            tsbAddGift.Enabled = true;
                            tsbModifyGift.Enabled = false;
                            tsbSaveGift.Enabled = false;
                            tsbDelete.Enabled = false;
                            tsbCancel.Enabled = false;

                            txtGiftName.ReadOnly = true;
                            txtGiftCount.ReadOnly = true;
                            cbbGiftActive.Enabled = false;
                            LoadGiftDataInformation();
                        }
                        else
                        {
                            MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("已存在相同的礼品名称,请重新输入名称.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGiftName.Focus();
                    }
                }
            }
        }
    }
}
