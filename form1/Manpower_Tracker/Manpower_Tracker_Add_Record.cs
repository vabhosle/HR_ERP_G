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
    public partial class Manpower_Tracker_Add_Record : Form
    {
        public Manpower_Tracker_Add_Record()
        {
            InitializeComponent();
        }

        private void ManpowerTrackAddGrdVew_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int i = 0;
            int k;
            if (ManpowerTrackAddGrdVew.CurrentCell.ColumnIndex == i)
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out k))
                {
                    e.Cancel = true;
                    MessageBox.Show("must be numeric");
                }
            }
        }

        private void Manpower_Tracker_Add_Record_Load(object sender, EventArgs e)
        {

        }
    }
}
