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
    public partial class mp_trck_add_frm : Form
    {
        public mp_trck_add_frm()
        {
            InitializeComponent();
        }

        private void Manpower_Tracker_Add_Record_Load(object sender, EventArgs e)
        {

        }

        private void mp_add_dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
            catch { }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = 0, j=1;
            if (mt_add_addRecord_gdv.CurrentCell.ColumnIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }

            if (mt_add_addRecord_gdv.CurrentCell.ColumnIndex == 1 || mt_add_addRecord_gdv.CurrentCell.ColumnIndex == 4)
            {
                int ascii = Convert.ToInt16(e.KeyChar);

                if ((ascii >= 97 && ascii <= 122) || (ascii >= 65 && ascii <= 90) || (ascii == 8) || (ascii == 32))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void mt_add_addRecord_grb_Enter(object sender, EventArgs e)
        {

        }
    }
}
