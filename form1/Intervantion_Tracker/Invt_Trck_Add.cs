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
    public partial class invt_trck_add_frm : Form
    {
        int invtId = 0;
        int gridRowCount = 0;
        public invt_trck_add_frm()
        {
            InitializeComponent();
        }
        /*------------------------------------------------------------  Form events start ---------------------------------------------------------------------*/

        private void invt_trck_add_frm_Load(object sender, EventArgs e)
        {
            invt_updtInvt_add_btn.Visible = false;
            invt_tot_add_txt.Text = "0";
            invt_add_dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            invt_add_dgv.EditingControlShowing += invt_add_dgv_EditingControlShowing;

            //TabPage myTabPage = new TabPage("Update Record");
            //myTabPage.Name = "tab_Update";
            //it_tab_main.TabPages.Add(myTabPage);



            //it_tab_main.SuspendLayout();

            //it_updt_updatePanel_pan.Size = it_tab_main.TabPages[0].Size;

            //it_tab_main.TabPages[0].Controls.Add(it_updt_updatePanel_pan);

            //it_updt_updatePanel_pan.BorderStyle = BorderStyle.FixedSingle;

            //it_updt_updatePanel_pan.ResumeLayout();

            //it_updt_updatePanel_pan.Show();


            //it_updt_updatePanel_pan.Dock = DockStyle.Fill;

            //it_updt_updatePanel_pan.SuspendLayout();
            //.myTabPage.Controls.Add(it_updt_updatePanel_pan);
            //it_updt_updatePanel_pan.ResumeLayout();

            //fillDataGridForImage();
        }




        /*------------------------------------------------------------ Add tab events -------------------------------------------------------------------*/



        private void InterventionIDAddTxt_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }
        private void invt_saveInvt_add_btn_Click(object sender, EventArgs e)
        {
            doSaveOrUpdate(true);
        }
        private void invt_updtInvt_add_btn_Click(object sender, EventArgs e)
        {
            doSaveOrUpdate(false);
        }
        private void invt_couHrs_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = costValidation(sender, e);
        }
        private void invt_noOfPpl_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = numberValidation(e);
        }
        private void invt_vnuCst_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = costValidation(sender, e);
        }
        private void invt_trnFee_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = costValidation(sender, e);
        }

        private void invt_acm_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = costValidation(sender, e);
        }

        private void invt_tot_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
        private void invt_misc_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = costValidation(sender, e);
        }
        private void invt_trp_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = costValidation(sender, e);
        }
        private void invt_trnNme_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;//nameValidation(e);
        }
        private void invt_cldtFr_srch_btn_Click(object sender, EventArgs e)
        {
            invt_couDtFrm_add_dtp.Value = DateTime.Today;
            invt_couDtFrm_add_txt.Text = "";
        }
        private void invt_cldtTo_srch_btn_Click(object sender, EventArgs e)
        {
            invt_couDtTo_add_dtp.Value = DateTime.Today;
            invt_couDtTo_add_txt.Text = "";
        }



        private void invt_couHrs_add_txt_TextChanged(object sender, EventArgs e)
        {
            if (invt_couHrs_add_txt.Text.StartsWith("."))
            {
                invt_couHrs_add_txt.Text = new string(invt_couHrs_add_txt.Text.SkipWhile(c => c == '.').ToArray());
            }
        }
        private void invt_vnuCst_add_txt_TextChanged(object sender, EventArgs e)
        {
            if (invt_vnuCst_add_txt.Text.StartsWith("."))
            {
                invt_vnuCst_add_txt.Text = new string(invt_vnuCst_add_txt.Text.SkipWhile(c => c == '.').ToArray());
            }
            
        }
        private void invt_trnFee_add_txt_TextChanged(object sender, EventArgs e)
        {
            if (invt_trnFee_add_txt.Text.StartsWith("."))
            {
                invt_trnFee_add_txt.Text = new string(invt_trnFee_add_txt.Text.SkipWhile(c => c == '.').ToArray());
            }
        }
        private void invt_trp_add_txt_TextChanged(object sender, EventArgs e)
        {
            if (invt_trp_add_txt.Text.StartsWith("."))
            {
                invt_trp_add_txt.Text = new string(invt_trp_add_txt.Text.SkipWhile(c => c == '.').ToArray());
            }
        }
        private void invt_acm_add_txt_TextChanged(object sender, EventArgs e)
        {
            if (invt_acm_add_txt.Text.StartsWith("."))
            {
                invt_acm_add_txt.Text = new string(invt_acm_add_txt.Text.SkipWhile(c => c == '.').ToArray());
            }
        }
        private void invt_misc_add_txt_TextChanged(object sender, EventArgs e)
        {
            if (invt_misc_add_txt.Text.StartsWith("."))
            {
                invt_misc_add_txt.Text = new string(invt_misc_add_txt.Text.SkipWhile(c => c == '.').ToArray());
            }
        }

        private void invt_savePrtc_add_btn_Click(object sender, EventArgs e)
        {
            if (invtId != 0)
            {
                insertParticipants();
            }
            else
            {
                showAlert("*Please save intervention before adding participant to it.", false);
            }
        }
        private void invt_add_dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (invtId != 0)
            {
                removeAlert();
            }
            else
            {
                showAlert("*Please save the intervention first.", false);
            }
            //fillDataGridForImage();
        }
        private void invt_add_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex == gridRowCount - 1 && Convert.ToString(invt_add_dgv.Rows[e.RowIndex].Cells[0].Value).Trim() != "")
                {
                    addNewRowToDataGrid();
                }
                string edpNo = (Convert.ToString(invt_add_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == "")?"0": invt_add_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (checkForDuplicateRecord(edpNo, e.RowIndex))
                {
                    if (edpNo != "0")
                        getParticipants(edpNo, e);
                    else
                        showAlert("*Please enter EDP No.", false);
                }
                else
                {
                    showAlert("*Employee record already added.", false);
                    removeDataGridRow(invt_add_dgv.Rows[e.RowIndex]);
                }
            }
            else if (e.ColumnIndex == 8)
            {
                string val = (invt_add_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) ? "" : invt_add_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (val.IndexOf(".") == (val.Length - 1))
                {
                    invt_add_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value += "00";
                }
                if (val.IndexOf(".") == 0)
                {
                    invt_add_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "00" + invt_add_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }
            }
        }
        private void invt_clr_add_btn_Click(object sender, EventArgs e)
        {

            resetInvtForm();

        }
        private void invt_couDtFrm_add_dtp_ValueChanged(object sender, EventArgs e)
        {
            invt_couDtFrm_add_txt.Text = invt_couDtFrm_add_dtp.Value.ToString("yyyy-MM-dd");
            if (!checkDateRange())
            {
                showAlert("*From date can not be greater than to date", false);
            }
            else
            {
                removeAlert();
            }
            
        }

        private void invt_couDtTo_add_dtp_ValueChanged(object sender, EventArgs e)
        {
            invt_couDtTo_add_txt.Text = invt_couDtTo_add_dtp.Value.ToString("yyyy-MM-dd");
            if (!checkDateRange())
            {
                showAlert("*From date can not be greater than to date", false);
            }
            else
            {
                removeAlert();
            }
            
        }
        private void InterventionTrackAddGrdVew_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /*int i = 0, j = 11;
            int k;
            if (invt_couDtTo_add_dtp.CurrentCell.ColumnIndex == i)
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out k))
                {
                    e.Cancel = true;
                    
                }
            }
            if (invt_couDtTo_add_dtp.CurrentCell.ColumnIndex == j)
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out k))
                {
                    e.Cancel = true;
                    
                }
            }*/
        }
        private void invt_clrPrtc_add_btn_Click(object sender, EventArgs e)
        {
            if (invtId != 0)
            {
                invt_add_dgv.Rows.Clear();
                invt_add_dgv.Refresh();
                gridRowCount = 0;
                addNewRowToDataGrid();
            }   
        }

        private void invt_add_dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = 0, j = 1;
            if (invt_add_dgv.CurrentCell.ColumnIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }

            if (invt_add_dgv.CurrentCell.ColumnIndex == 8)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
               
                if (e.KeyChar == '.')
                {
                    if ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.Length == 0)
                    {
                        e.Handled = true;
                    }                    
                }
            }
        }
        private void invt_trnLoc_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;// componentTextValidation(e);
        }
        private void invt_batch_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;// componentTextValidation(e);
        }
        private void invt_couNam_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;// componentTextValidation(e);
        }


        private void invt_couHrs_add_txt_Leave(object sender, EventArgs e)
        {
            string val = invt_couHrs_add_txt.Text;
            if (val.IndexOf(".") == val.Length - 1 && val.IndexOf(".") != -1)
            {
                invt_couHrs_add_txt.Text += "00";
            }
        }
        private void invt_vnuCst_add_txt_Leave(object sender, EventArgs e)
        {
            string val = invt_vnuCst_add_txt.Text;
            if (val.IndexOf(".") == val.Length - 1 && val.IndexOf(".") != -1)
            {
                invt_vnuCst_add_txt.Text += "00";
            }
            invt_tot_add_txt.Text = calculateTotal();
        }
        private void invt_trnFee_add_txt_Leave(object sender, EventArgs e)
        {
            string val = invt_trnFee_add_txt.Text;
            if (val.IndexOf(".") == val.Length - 1 && val.IndexOf(".") != -1)
            {
                invt_trnFee_add_txt.Text += "00";
            }
            invt_tot_add_txt.Text = calculateTotal();
        }
        private void invt_trp_add_txt_Leave(object sender, EventArgs e)
        {
            string val = invt_trp_add_txt.Text;
            if (val.IndexOf(".") == val.Length - 1 && val.IndexOf(".") != -1)
            {
                invt_trp_add_txt.Text += "00";
            }
            invt_tot_add_txt.Text = calculateTotal();
        }
        private void invt_acm_add_txt_Leave(object sender, EventArgs e)
        {
            string val = invt_acm_add_txt.Text;
            if (val.IndexOf(".") == val.Length - 1 && val.IndexOf(".") != -1)
            {
                invt_acm_add_txt.Text += "00";
            }
            invt_tot_add_txt.Text = calculateTotal();
        }
        private void invt_misc_add_txt_Leave(object sender, EventArgs e)
        {
            string val = invt_misc_add_txt.Text;
            if (val.IndexOf(".") == val.Length - 1 && val.IndexOf(".") != -1)
            {
                invt_misc_add_txt.Text += "00";
            }
            invt_tot_add_txt.Text = calculateTotal();
        }
        private void invt_addRec2_add_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add a new record? It will delete all your unsaved data.", "New Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                resetEntireForm();
            }
        }
        private void invt_add_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (invtId != 0)
            {
                if (e.ColumnIndex == 9)
                {
                    invt_add_dgv.Rows.Remove(invt_add_dgv.Rows[e.RowIndex]);
                    gridRowCount--;
                }
            }
        }



        /*------------------------------------------------------------  Search tab events ---------------------------------------------------------------------*/


        private void it_srch_search_btn_Click(object sender, EventArgs e)
        {

            
            Dictionary<string, string> d = new Dictionary<string, string>()
                {
                    {"iv_invtName", it_srch_trainingName_txt.Text},
                    {"iv_invtLocation", it_srch_trainingLocation_txt.Text},
                    {"iv_trainerName", it_srch_trainerName_txt.Text},
                    {"iv_invtBatch", it_srch_batch_txt.Text},
                    {"iv_invtFromDate", it_srch_fromDate_txt.Text},
                    {"iv_invtToDate", it_srch_toDate_txt.Text},
                    {"iv_invtHours", it_srch_trainingHours_txt.Text},
                    {"iv_attdCount", it_srch_headCount_txt.Text},
                    {"iv_venueCost", it_srch_venueCost_txt.Text},
                    {"iv_trainerCost", it_srch_trainerFees_txt.Text},
                    {"iv_trasportCost", it_srch_transportCost_txt.Text},
                    {"iv_acmdCost", it_srch_accomodation_txt.Text},
                    {"iv_miscCost", it_srch_miscellaneous_txt.Text},
                    {"iv_totalCost", it_srch_total_txt.Text}
                };
            searchInterventions(d);
        }

        private void it_srch_clear_btn_Click(object sender, EventArgs e)
        {
            it_srch_trainingName_txt.Text = "";
            it_srch_trainingLocation_txt.Text = "";
            it_srch_batch_txt.Text = "";
            
        }


        /*------------------------------------------------------------  Form events end ---------------------------------------------------------------------*/
        

        
        

       /*--------------------------------------------------  Form Validation Functions start ---------------------------------------------------------------------*/
        private void removeDataGridRow(DataGridViewRow row)
        {
            row.Cells["edpno"].Value = "";
            row.Cells["name"].Value = "";
            row.Cells["grade"].Value = "";
            row.Cells["function"].Value = "";
            row.Cells["location"].Value = "";
            row.Cells["reptManager"].Value = "";
            row.Cells["cadre"].Value = "";
            row.Cells["doj"].Value = "";
            row.Cells["rate"].Value = "0";
        }
        private void fillDataGridForImage()
        {
            for (int row = 0; row <= invt_add_dgv.Rows.Count - 1; row++)
            {
                ((DataGridViewImageCell)invt_add_dgv.Rows[row].Cells[9]).Value = Properties.Resources.Delete_btn;
            }
        }

        private void resetEntireForm()
        {
            resetInvtForm();
            invtId = 0;
            invt_add_dgv.Rows.Clear();
            invt_add_dgv.Refresh();
            invt_updtInvt_add_btn.Visible = false;
            invt_saveInvt_add_btn.Visible = true;
            removeAlert();
            gridRowCount = 0;
            //fillDataGridForImage();
        }
        private void resetInvtForm()
        {
            invt_batch_add_txt.Text = "";
            invt_trnLoc_add_txt.Text = "";
            invt_couNam_add_txt.Text = "";
            invt_couDtTo_add_txt.Text = "";
            invt_couDtFrm_add_txt.Text = "";
            invt_couDtTo_add_txt.Text = "";
            invt_couHrs_add_txt.Text = "";
            invt_trnNme_add_txt.Text = "";
            invt_misc_add_txt.Text = "";
            invt_couDtFrm_add_txt.Text = "";
            invt_noOfPpl_add_txt.Text = "";
            invt_vnuCst_add_txt.Text = "";
            invt_trnFee_add_txt.Text = "";
            invt_trp_add_txt.Text = "";
            invt_acm_add_txt.Text = "";
            invt_tot_add_txt.Text = "0";
        }
        private bool componentTextValidation(KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt16(e.KeyChar);
            if ((ascii >= 97 && ascii <= 122) || (ascii >= 65 && ascii <= 90) || (ascii == 8) || (ascii == 32) || (ascii == 95)
            || (ascii == 45) || (ascii >= 48 && ascii <= 57))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private string calculateTotal()
        {
            decimal cost = 0;
            cost += (invt_misc_add_txt.Text == "") ? 0 : Convert.ToDecimal(invt_misc_add_txt.Text);
            cost += (invt_vnuCst_add_txt.Text == "") ? 0 : Convert.ToDecimal(invt_vnuCst_add_txt.Text);
            cost += (invt_trnFee_add_txt.Text == "") ? 0 : Convert.ToDecimal(invt_trnFee_add_txt.Text);
            cost += (invt_trp_add_txt.Text == "") ? 0 : Convert.ToDecimal(invt_trp_add_txt.Text);
            cost += (invt_acm_add_txt.Text == "") ? 0 : Convert.ToDecimal(invt_acm_add_txt.Text);

            return Convert.ToString(cost);

        }
        private bool nameValidation(KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt16(e.KeyChar);
            if ((ascii >= 97 && ascii <= 122) || (ascii >= 65 && ascii <= 90) || (ascii == 8) || (ascii == 32))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool numberValidation(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            return false;
        }
        private bool costValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                return true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                return true;
            }
            return false;
        }
        private bool checkValidation()
        {
            DateTime frDate;
            DateTime.TryParse(invt_couDtFrm_add_txt.Text, out frDate);
            DateTime toDate;
            DateTime.TryParse(invt_couDtTo_add_txt.Text, out toDate);
            if (invt_couNam_add_txt.Text.Trim() == "")
            {
                showAlert("*Please enter training name.", false);
                return false;
            }
            if (invt_trnLoc_add_txt.Text.Trim() == "")
            {
                showAlert("*Please enter training location.", false);
                return false;
            }
            if (invt_trnNme_add_txt.Text.Trim() == "")
            {
                showAlert("*Please enter trainer name.", false);
                return false;
            }
            if (invt_batch_add_txt.Text.Trim() == "")
            {
                showAlert("*Please enter batch.", false);
                return false;
            }
            if (invt_noOfPpl_add_txt.Text.Trim() == "")
            {
                showAlert("*Please enter head count.", false);
                return false;
            }
            if (invt_couHrs_add_txt.Text.Trim() == "")
            {
                showAlert("*Please enter training hours", false);
                return false;
            }
            if (frDate.Ticks != 0 && toDate.Ticks == 0)
            {
                showAlert("*Please select To date", false);
                return false;
            }
            if (frDate.Ticks == 0 && toDate.Ticks != 0)
            {
                showAlert("*Please select From date", false);
                return false;
            }
            if (!checkDateRange())
            {
                showAlert("*From date can not be greater than to date",false);
                return false;
            }
            removeAlert();
            return true;    
        }
        private void showAlert(string msg,bool isCorr)
        {
            invt_note_add_lbl.Text = msg;
            invt_note_add_lbl.ForeColor = (isCorr) ? System.Drawing.Color.Green: System.Drawing.Color.Red;
        }
        private void removeAlert()
        {
            invt_note_add_lbl.Text = "Note: Please save intervention before adding participant to it.";
            invt_note_add_lbl.ForeColor = System.Drawing.Color.Blue;
        }
        private bool checkDateRange()
        {
            DateTime frDate;
            DateTime.TryParse(invt_couDtFrm_add_txt.Text, out frDate);
            DateTime toDate;
            DateTime.TryParse(invt_couDtTo_add_txt.Text, out toDate);
            if (toDate.Ticks != 0 && frDate.Ticks != 0)
            {
                if (frDate.Ticks > toDate.Ticks)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
            
        }
        private string checkForEmptyCost(string cost)
        {
            if (cost.Trim() == "")
                cost = "0";
            return cost;
        }
        private string appendSQLdateFormat(string date)
        {
            if (date != "")
            {
                date += "T00:00:00.000";
            }
            else
            {
                date = DateTime.Now.ToString("yyyy-MM-dd")+"T00:00:00.000" ;
            }
            return date;
        }
        private string getMonthFromDate(string date)
        {
            if (date != "")
            {
                DateTime dt = Convert.ToDateTime(date);
                date = dt.ToString("MMMM");
            }
            else
            {
                date = "";
            }
            return date;
        }
        private bool checkForDuplicateRecord(string edpno,int existing)
        {
            int edp = Convert.ToInt32(edpno);

            for (int i = 0; i < invt_add_dgv.Rows.Count - 1; i++)
            {
                DataGridViewRow row = invt_add_dgv.Rows[i];
                if (Convert.ToInt32((Convert.ToString(row.Cells["edpno"].Value).Trim() == "") ? "-1" : row.Cells["edpno"].Value) == edp && existing != i)
                {
                    return false;
                }
            }
            return true;
        }
        private string generateCombineString(string col)
        {
            string str = "";
            for (int i = 0; i < invt_add_dgv.Rows.Count - 1; i++)
            {
                DataGridViewRow row = invt_add_dgv.Rows[i];
                if (col == "edpno")
                {
                    if (Convert.ToString(row.Cells[col].Value).Trim() != "")
                    {
                        str += row.Cells[col].Value + ",";
                    }
                }
                else if (col == "rate")
                {
                    str += (Convert.ToString(row.Cells[col].Value).Trim() == "")?"0,":row.Cells[col].Value + ",";
                }
                
            }
            if (str.Trim() != "")
            {
                str = "," + str;
            }
            return str;
        }
        private void addNewRowToDataGrid()
        {
            invt_add_dgv.Rows.Insert(gridRowCount);
            DataGridViewRow row = invt_add_dgv.Rows[gridRowCount];
            row.Cells["edpno"].ReadOnly = false;
            row.Cells["rate"].ReadOnly = false;
            fillDataGridForImage();
            gridRowCount++;
        }
        /*--------------------------------------------------  Form Validation Functions end ---------------------------------------------------------------------*/




        /*------------------------------------------------------------  Form sql call start ---------------------------------------------------------------------*/
        private void getParticipants(string edpNo, DataGridViewCellEventArgs e)
        {
            removeAlert();
            Dictionary<string, string> d = new Dictionary<string, string>()
            {
                {"EDP_NO", edpNo}
            };
            try
            {
                queryShooter query = new queryShooter();
                XmlDocument doc = new XmlDocument();
                doc = query.invt_mp_srach_mp_add(d);
                DataGridViewRow row = invt_add_dgv.Rows[e.RowIndex];
                XmlNodeList elemList = doc.GetElementsByTagName("Manpower");
                if (elemList.Count == 0)
                {
                    removeDataGridRow(row);
                    showAlert("No record found for EDP No: " + row.Cells["edpno"].Value, false);
                }
                else
                {
                    removeAlert();
                }
                for (int i = 0; i < elemList.Count; i++)
                {
                    int attrVal = elemList[i].Attributes.Count;
                    for (int j = 0; j < attrVal; j++)
                    {
                        if (elemList[i].Attributes[j].Name == "mp_Name")
                        {
                            row.Cells["name"].Value = elemList[i].Attributes[j].Value;
                        }
                        else if (elemList[i].Attributes[j].Name == "mp_Grade")
                        {
                            row.Cells["grade"].Value = elemList[i].Attributes[j].Value;
                        }
                        else if (elemList[i].Attributes[j].Name == "mp_Function")
                        {
                            row.Cells["function"].Value = elemList[i].Attributes[j].Value;
                        }
                        else if (elemList[i].Attributes[j].Name == "mp_Location")
                        {
                            row.Cells["location"].Value = elemList[i].Attributes[j].Value;
                        }
                        else if (elemList[i].Attributes[j].Name == "mp_ReptMngr")
                        {
                            row.Cells["reptManager"].Value = elemList[i].Attributes[j].Value;
                        }
                        else if (elemList[i].Attributes[j].Name == "mp_Cadre")
                        {
                            row.Cells["cadre"].Value = elemList[i].Attributes[j].Value;
                        }
                        else if (elemList[i].Attributes[j].Name == "mp_DOJ")
                        {
                            row.Cells["doj"].Value = DateTime.Parse(elemList[i].Attributes[j].Value).ToShortDateString();
                        }
                        else
                        {
                            row.Cells["rate"].Value = "0";
                        }
                    }

                }
                //fillDataGridForImage();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Something went wrong.");
            }
        }
        private void doSaveOrUpdate(bool isSave)
        {
            bool isValidate = checkValidation();
            if (isValidate)
            {
                Dictionary<string, string> d = new Dictionary<string, string>()
                {
                    {"invtName", invt_couNam_add_txt.Text},
                    {"invtBatch", invt_batch_add_txt.Text},
                    {"invtLocation", invt_trnLoc_add_txt.Text},
                    {"trainerName", invt_trnNme_add_txt.Text},
                    {"attdCount",invt_noOfPpl_add_txt.Text},
                    {"invtHours", checkForEmptyCost(invt_couHrs_add_txt.Text)},

                    {"venueCost", checkForEmptyCost(invt_vnuCst_add_txt.Text)},
                    {"trainerCost",checkForEmptyCost(invt_trnFee_add_txt.Text)},
                    {"trasportCost",checkForEmptyCost(invt_trp_add_txt.Text)},
                    {"acmdCost",checkForEmptyCost(invt_acm_add_txt.Text)},
                    {"miscCost",checkForEmptyCost(invt_misc_add_txt.Text)},
                    
                    {"invtMonth", getMonthFromDate(invt_couDtFrm_add_txt.Text)},

                    {"invtFromDate",appendSQLdateFormat(invt_couDtFrm_add_txt.Text)},
                    {"invtToDate",appendSQLdateFormat(invt_couDtTo_add_txt.Text)},
                    {"Search1",""},
                    {"Search2",""},
                    {"Search3",""},
                    {"Search4","0"},
                    {"Search5","0"}
                    
                };
                if (!isSave)
                {
                    d.Add("invtId", Convert.ToString(invtId));
                }
                
                try
                {
                    queryShooter query = new queryShooter();

                    if (!isSave)
                    {
                        int res = query.invt_invt_update_invt_add(d);
                        showAlert("*Intervention updated successfully.", true);
                    }
                    else
                    {
                        invtId = query.invt_invt_add_invt_add(d);
                        invt_updtInvt_add_btn.Visible = true;
                        invt_saveInvt_add_btn.Visible = false;
                        addNewRowToDataGrid();
                        showAlert("*Intervention saved successfully.", true);
                        
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oops! Something went wrong.");
                }
            }
        }
        private void insertParticipants()
        {
            string edpNo = generateCombineString("edpno");
            if (edpNo.Trim() != "")
            {
                Dictionary<string, string> d = new Dictionary<string, string>()
                {
                    {"invtNo", Convert.ToString(invtId)},
                    {"EDPNo", edpNo},
                    {"rate", generateCombineString("rate")},
                    {"Search1", ""},
                    {"Search2", ""},
                    {"Search3", ""},
                    {"Search4", "0"},
                    {"Search5", "0"}
                };

                try
                {
                    queryShooter query = new queryShooter();
                    int doc = 0;
                    doc = query.invt_invt_add_mp_add(d);
                    showAlert("*Participants saved successfully.", true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oops! Something went wrong.");
                }
            }
            else
            {
                showAlert("*Please add atleast one participant.",false);
            }
            
        }
        private void searchInterventions(Dictionary<string,string> d)
        {
            try
            {
                queryShooter query = new queryShooter();
                //int doc = 0;
               // doc = query.invt_invt_add_mp_add(xml);
                showAlert("*Participants saved successfully.", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Something went wrong.");
            }
        }
        /*------------------------------------------------------------  Form sql call end ---------------------------------------------------------------------*/
    }
}




//private void AddRow(string thing,string thingdesc)
//{
//   int idx = MyGrid.Rows.Add();
//   DataGridViewRow row = MyGrid.Rows[idx];
//   row.Cells["Selected"].Value = "Add";
//   row.Cells["Model"].Value = thing;
//   row.Cells["Description"].Value = thingdesc;
//   row.Cells["Scenario"].Value = "Basic";
//   row.Cells["ModelLoop"].Value = "1";
//   row.Cells["LaunchCount"].Value = "1";
//}