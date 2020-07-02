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

        private void frmCreateHumanData_Load(object sender, EventArgs e)
        {

        }

        private void tsbAddPersonnel_Click(object sender, EventArgs e)
        {

        }

        private void tsbModifyPersonnel_Click(object sender, EventArgs e)
        {

        }

        private void tsbCancelPersonnel_Click(object sender, EventArgs e)
        {

        }

        private void tsbSavePersonnel_Click(object sender, EventArgs e)
        {

        }

        private void tsbDeletePersonnel_Click(object sender, EventArgs e)
        {

        }

        private void tsbExit_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonnelNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbPersonnelActive_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
