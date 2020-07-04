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
    public partial class frmCreatePersonnelData : Form
    {
        public frmCreatePersonnelData()
        {
            InitializeComponent();
        }
        Boolean IsUpdate = false;
        string PersonnelID = "";
        private void frmCreateHumanData_Load(object sender, EventArgs e)
        {
            //dgvDataList.RowsDefaultCellStyle.BackColor = Color.Thistle;  //奇数行颜色
            dgvDataList.AlternatingRowsDefaultCellStyle.BackColor = Color.Linen; //偶数行颜色
            dgvDataList.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行
            dgvDataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // 设定包括Header和所有单元格的列宽自动调整
            dgvDataList.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行,设定不包括Header所有单元格的行高自动调整
            dgvDataList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;  //AllCells;设定包括Header和所有单元格的行高自动调整            
            LoadPersonnelDataInformation();

            tsbModifyPersonnel.Enabled = false;
            tsbCancelPersonnel.Enabled = false;
            tsbDeletePersonnel.Enabled = false;
            tsbSavePersonnel.Enabled = false;

            txtPersonnelName.ReadOnly = true;
            txtPersonnelNumber.ReadOnly = true;
            cbbPersonnelActive.Enabled = false;
        }

        private void tsbAddPersonnel_Click(object sender, EventArgs e)
        {
            tsbAddPersonnel.Enabled = false;
            tsbModifyPersonnel.Enabled = false;
            tsbCancelPersonnel.Enabled = true;
            tsbSavePersonnel.Enabled = true;
            tsbDeletePersonnel.Enabled = false;
            txtPersonnelName.ReadOnly = false;
            txtPersonnelNumber.ReadOnly = false;
            cbbPersonnelActive.Enabled = true;

            txtPersonnelName.Text = "";
            txtPersonnelNumber.Text = "";
            cbbPersonnelActive.Text = " ";
            IsUpdate = false;
        }

        private void tsbModifyPersonnel_Click(object sender, EventArgs e)
        {
            tsbAddPersonnel.Enabled = false;
            tsbModifyPersonnel.Enabled = false;
            tsbCancelPersonnel.Enabled = true;
            tsbSavePersonnel.Enabled = true;
            tsbDeletePersonnel.Enabled = false;

            txtPersonnelName.ReadOnly = false;
            txtPersonnelNumber.ReadOnly = false;
            cbbPersonnelActive.Enabled = true;

            IsUpdate = true;
        }

        private void tsbCancelPersonnel_Click(object sender, EventArgs e)
        {
            tsbAddPersonnel.Enabled = true;
            tsbModifyPersonnel.Enabled = false;
            tsbCancelPersonnel.Enabled = false;
            tsbSavePersonnel.Enabled = false;
            tsbDeletePersonnel.Enabled = false;
            txtPersonnelName.ReadOnly = true;
            txtPersonnelNumber.ReadOnly = true;
            cbbPersonnelActive.Enabled = false;

            txtPersonnelNumber.Text = "";
            txtPersonnelName.Text = "";
            cbbPersonnelActive.Text = " ";
        }

        private void tsbSavePersonnel_Click(object sender, EventArgs e)
        {
            if (txtPersonnelName.Text.Trim() == "")
            {
                MessageBox.Show("请输入参加抽奖人员名称.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPersonnelName.Focus();
                return;
            }
            if (txtPersonnelNumber.Text.Trim() == "")
            {
                MessageBox.Show("请输入参加抽奖人员编号.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPersonnelNumber.Focus();
                return;
            }
            if (cbbPersonnelActive.Text.Trim() == "")
            {
                MessageBox.Show("请选择是否加入抽奖.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbPersonnelActive.Focus();
                return;
            }
            SavePersonnelDataToDatabase();
        }

        private void tsbDeletePersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除这个人员吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                if (Operations.DeletePersonnelRecord(PersonnelID) > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPersonnelName.Text = "";
                    txtPersonnelNumber.Text = "";
                    cbbPersonnelActive.Text = " ";
                    tsbAddPersonnel.Enabled = true;
                    tsbModifyPersonnel.Enabled = false;
                    tsbSavePersonnel.Enabled = false;
                    tsbDeletePersonnel.Enabled = false;
                    tsbCancelPersonnel.Enabled = false;
                    LoadPersonnelDataInformation();
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

        private void txtPersonnelNumber_KeyPress(object sender, KeyPressEventArgs e)
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
                if (tsbSavePersonnel.Enabled)
                {
                    tsbAddPersonnel.Enabled = true;
                    tsbModifyPersonnel.Enabled = false;
                    tsbCancelPersonnel.Enabled = false;
                    tsbSavePersonnel.Enabled = false;
                    tsbDeletePersonnel.Enabled = false;
                    txtPersonnelName.ReadOnly = true;
                    txtPersonnelNumber.ReadOnly = true;
                    cbbPersonnelActive.Enabled = false;

                    txtPersonnelNumber.Text = "";
                    txtPersonnelName.Text = "";
                    cbbPersonnelActive.Text = " ";
                }
                int index = dgvDataList.CurrentRow.Index;
                string PersonnelName = dgvDataList.Rows[index].Cells[1].Value.ToString().Trim();
                GetDataInfoToText(PersonnelName);
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
        private void LoadPersonnelDataInformation()
        {            
            dgvDataList.DataSource = Operations.GetPersonnels();
            dgvDataList.Columns[0].Visible = false;
            dgvDataList.ClearSelection();
        }
        private void GetDataInfoToText(string strPersonnelNumber)
        {
            Dictionary<string, string> PersonnelInfo = Operations.GetPersonelDetails(strPersonnelNumber);
            if (PersonnelInfo == null)
            {
                MessageBox.Show("未找到相关信息,请重试.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PersonnelID = PersonnelInfo["PersonnelID"];
                txtPersonnelName.Text = PersonnelInfo["PersonnelName"];
                txtPersonnelNumber.Text = PersonnelInfo["PersonnelNumber"];
                cbbPersonnelActive.Text = PersonnelInfo["PersonnelActive"];
                
                tsbDeletePersonnel.Enabled = true;
                tsbModifyPersonnel.Enabled = true;
                tsbAddPersonnel.Enabled = true;
            }            
        }        
        /// <summary>
        /// 保存数据
        /// </summary>
        private void SavePersonnelDataToDatabase()
        {
            Dictionary<string, string> PersonnelInfo = new Dictionary<string, string>();            

            if (IsUpdate)
            {
                if (MessageBox.Show("确认保存吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PersonnelInfo["PersonnelID"] = PersonnelID;
                    PersonnelInfo["PersonnelName"] = txtPersonnelName.Text.Trim();
                    PersonnelInfo["PersonnelNumber"] = txtPersonnelNumber.Text.Trim();
                    PersonnelInfo["PersonnelActive"] = cbbPersonnelActive.Text.Trim();

                    if (Operations.UpdatePersonnelInformation(PersonnelInfo) > 0)
                    {
                        MessageBox.Show("修改成功.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPersonnelName.Text = "";
                        txtPersonnelNumber.Text = "";
                        cbbPersonnelActive.Text = " ";
                        tsbAddPersonnel.Enabled = true;
                        tsbModifyPersonnel.Enabled = false;
                        tsbSavePersonnel.Enabled = false;
                        tsbDeletePersonnel.Enabled = false;
                        tsbCancelPersonnel.Enabled = false;

                        txtPersonnelName.ReadOnly = true;
                        txtPersonnelNumber.ReadOnly = true;
                        cbbPersonnelActive.Enabled = false;
                        LoadPersonnelDataInformation();
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("确认添加抽奖人员吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Operations.GetPersonnelExist(txtPersonnelNumber.Text.Trim()))
                    {
                        MessageBox.Show("已存在相同的抽奖人员了,请重新输入编号.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPersonnelNumber.Focus();
                    }
                    else
                    {

                        PersonnelInfo["PersonnelID"] = Guid.NewGuid().ToString();
                        PersonnelInfo["PersonnelName"] = txtPersonnelName.Text.Trim();
                        PersonnelInfo["PersonnelNumber"] = txtPersonnelNumber.Text.Trim();
                        PersonnelInfo["PersonnelActive"] = cbbPersonnelActive.Text.Trim();

                        
                        if (Operations.AddPersonnelInformation(PersonnelInfo) > 0)
                        {
                            MessageBox.Show("添加成功.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPersonnelName.Text = "";
                            txtPersonnelNumber.Text = "";
                            cbbPersonnelActive.Text = " ";
                            tsbAddPersonnel.Enabled = true;
                            tsbModifyPersonnel.Enabled = false;
                            tsbSavePersonnel.Enabled = false;
                            tsbDeletePersonnel.Enabled = false;
                            tsbCancelPersonnel.Enabled = false;

                            txtPersonnelName.ReadOnly = true;
                            txtPersonnelNumber.ReadOnly = true;
                            cbbPersonnelActive.Enabled = false;
                            LoadPersonnelDataInformation();
                        }
                        else
                        {
                            MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
