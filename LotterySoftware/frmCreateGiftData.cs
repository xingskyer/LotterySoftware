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

        private void frmCreateGiftData_Load(object sender, EventArgs e)
        {

        }

        private void tsbAddGift_Click(object sender, EventArgs e)
        {

        }

        private void tsbModifyGift_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {

        }

        private void tsbSaveGift_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

        }

        private void tsbExit_Click(object sender, EventArgs e)
        {

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

        }

        private void cbbGiftActive_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
