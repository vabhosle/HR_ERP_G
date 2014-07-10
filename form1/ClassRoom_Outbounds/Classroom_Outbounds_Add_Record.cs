using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class Classroom_Outbounds_Add_Record : Form
    {
        public Classroom_Outbounds_Add_Record()
        {
            InitializeComponent();
        }

        private void Classroom_Outbounds_Add_Record_Load(object sender, EventArgs e)
        {

        }

        private void ClassOut_GrdVewAddRec_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int i = 0, j = 11;
            int k;
            if (ClassOut_GrdVewAddRec.CurrentCell.ColumnIndex == i)
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out k))
                {
                    e.Cancel = true;
                    MessageBox.Show("must be numeric");
                }
            }
            if (ClassOut_GrdVewAddRec.CurrentCell.ColumnIndex == j)
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out k))
                {
                    e.Cancel = true;
                    MessageBox.Show("must be numeric");
                }
            }
            
            
        }

        private void ClassOut_GrdVewAddRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}