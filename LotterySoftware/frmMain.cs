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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //dgvDataList.RowsDefaultCellStyle.BackColor = Color.Thistle;  //奇数行颜色
            dgvDataList.AlternatingRowsDefaultCellStyle.BackColor = Color.Linen; //偶数行颜色
            dgvDataList.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行
            dgvDataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // 设定包括Header和所有单元格的列宽自动调整
            dgvDataList.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;  //设置列标题不换行,设定不包括Header所有单元格的行高自动调整
            dgvDataList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;  //AllCells;设定包括Header和所有单元格的行高自动调整    
        }

        private void cbbGiftType_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnStartGift_Click(object sender, EventArgs e)
        {

        }

        private void btnStopGift_Click(object sender, EventArgs e)
        {

        }

        private void rbSuperGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbGrandGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbLevelOneGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbLevelTwoGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbLevelThreeGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbLevelFourGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbLevelFiveGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rbComfortGift_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtSuperGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtGrandGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLevelOneGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLevelTwoGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLevelThreeGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLevelFourGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLevelFiveGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtComfortGift_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TSMGiftEntry_Click(object sender, EventArgs e)
        {
            frmCreateGiftData frmCreateGiftData = new frmCreateGiftData();
            frmCreateGiftData.ShowDialog();
        }

        private void TSMPersonnelEntry_Click(object sender, EventArgs e)
        {
            frmCreatePersonnelData frmCreatePersonnelData = new frmCreatePersonnelData();
            frmCreatePersonnelData.ShowDialog();
        }

        private void TSMAbout_Click(object sender, EventArgs e)
        {

        }

        private void TSMChinese_Click(object sender, EventArgs e)
        {

        }

        private void TSMEnglish_Click(object sender, EventArgs e)
        {

        }
    }
}
