using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace form1
{
    public partial class mp_trck_add_frm : Form
    {
        public mp_trck_add_frm()
        {
            InitializeComponent();
        }

        private void mt_add_addRecord_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string edpNo = (Convert.ToString(mt_add_addRecord_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == "") ? "0" : mt_add_addRecord_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (checkForDuplicateRecord(edpNo, e.RowIndex))
                {
                    if (edpNo == "0")
                    {
                        showAlert("*Please enter EDP No.", false);
                    }
                    else
                    {
                        removeAlert();
                    }
                }
                else
                {
                    showAlert("*Employee record already added.", false);
                    removeDataGridRow(mt_add_addRecord_dgv.Rows[e.RowIndex]);
                }
            }
            else
            {
                removeAlert();
            }
        }
// ---------------------------------------- Validating Functions ---------------------------------------------------

        private bool checkForDuplicateRecord(string edpno, int existing)
        {
            int edp = Convert.ToInt32(edpno);

            for (int i = 0; i < mt_add_addRecord_dgv.Rows.Count - 1; i++)
            {
                DataGridViewRow row = mt_add_addRecord_dgv.Rows[i];
                if (Convert.ToInt32((Convert.ToString(row.Cells["mt_add_edpno"].Value).Trim() == "") ? "-1" : row.Cells["mt_add_edpno"].Value) == edp && existing != i)
                {
                    return false;
                }
            }
            return true;
        }

        private void showAlert(string msg, bool isCorr)
        {
            mt_add_note_lbl.Text = msg;
            mt_add_note_lbl.ForeColor = (isCorr) ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private void removeAlert()
        {
            mt_add_note_lbl.Text = "";
            mt_add_note_lbl.ForeColor = System.Drawing.Color.Blue;
        }

        private void removeDataGridRow(DataGridViewRow row)
        {
            row.Cells["mt_add_edpno"].Value = "";
            row.Cells["mt_add_name"].Value = "";
            row.Cells["mt_add_grade"].Value = "";
            row.Cells["mt_add_function"].Value = "";
            row.Cells["mt_add_location"].Value = "";
            row.Cells["mt_add_reportingManager"].Value = "";
            row.Cells["mt_add_dateOfJoining"].Value = "";
        }

        private bool numberValidation(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            return false;
        }
// ------------------- Validation for only number in edp No ----------------------------
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mt_add_addRecord_dgv.CurrentCell.ColumnIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void mt_add_addRecord_dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.ContextMenuStrip = new ContextMenuStrip();
                    tb.KeyDown -= TextBox_KeyDown;
                    tb.KeyDown += TextBox_KeyDown;
                }
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
            catch { }
        }
        void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C | e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        
// ----------------------------------------- End of edp no validation ------------------------------        

        private void mt_srch_edpNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = numberValidation(e);
        }

        private void mt_srch_dateOfJoining_dtp_ValueChanged(object sender, EventArgs e)
        {
            mt_srch_dateOfJoining_txt.Text = mt_srch_dateOfJoining_dtp.Value.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //invt_couDtTo_add_dtp.Value = DateTime.Today;
            mt_srch_dateOfJoining_txt.Text = "";
        }

        private void mt_srch_clear_bt_Click(object sender, EventArgs e)
        {
            mt_srch_edpNo_txt.Text = "";
            mt_srch_grade_txt.Text = "";
            mt_srch_function_txt.Text = "";
            mt_srch_location_txt.Text = "";
            mt_srch_name_txt.Text = "";
            mt_srch_dateOfJoining_txt.Text = "";
            mt_srch_reportingManager_txt.Text = "";
        }

        private void mt_add_clear_btn_Click(object sender, EventArgs e)
        {
            mt_add_addRecord_dgv.Rows.Clear();
        }
        
    }
}
