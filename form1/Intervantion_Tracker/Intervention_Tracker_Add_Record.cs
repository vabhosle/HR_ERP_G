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
    public partial class Intervention_Tracker_Add_Record : Form
    {
        public Intervention_Tracker_Add_Record()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InterventionIDAddTxt_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void InterventionTrackAddGrdVew_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /*int i = 0, j = 11;
            int k;
            if (InterventionTrackAddGrdVew.CurrentCell.ColumnIndex == i)
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out k))
                {
                    e.Cancel = true;
                    MessageBox.Show("must be numeric");
                }
            }
            if (InterventionTrackAddGrdVew.CurrentCell.ColumnIndex == j)
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out k))
                {
                    e.Cancel = true;
                    MessageBox.Show("must be numeric");
                }
            }*/
        }
    }
}