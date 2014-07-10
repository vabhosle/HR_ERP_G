using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;

namespace form1
{
    public partial class invt_trck_srch_frm : Form
    {
        //Code for Water mark in DOJ text box
        
        public invt_trck_srch_frm()
        {
            InitializeComponent();
            //invt_doj_srch_txt.ForeColor = Color.Gray;
            //invt_doj_srch_txt.Text = "MM/DD/YY";
            //this.invt_doj_srch_txt.Leave += new System.EventHandler(this.invt_doj_srch_txt_Leave);
            //this.invt_doj_srch_txt.Enter += new System.EventHandler(this.invt_doj_srch_txt_Enter);
        }

        /*private void invt_doj_srch_txt_Leave(object sender, EventArgs e)
        {
            if (invt_doj_srch_txt.Text.Length == 0)
            {
                invt_doj_srch_txt.Text = "MM/DD/YY";
                invt_doj_srch_txt.ForeColor = Color.Gray;
            }
        }

        private void invt_doj_srch_txt_Enter(object sender, EventArgs e)
        {
            if (invt_doj_srch_txt.Text == "MM/DD/YY")
            {
                invt_doj_srch_txt.Text = "";
                invt_doj_srch_txt.ForeColor = Color.Black;
            }
        }*/
        // End of watermark code



   

        private void invt_EDPNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
        private void InterventionTrackTabManSearchBtn_Click(object sender, EventArgs e)
        {
            string cadInfo = "";
            if (invt_cad_srch_cmb.SelectedIndex != -1)
            {
                cadInfo = invt_cad_srch_cmb.Items[invt_cad_srch_cmb.SelectedIndex].ToString();
            }
            Dictionary<string, string> d = new Dictionary<string, string>()
            {
	            {"edpNo", invt_edpNo_srch_txt.Text},
	            {"name", invt_nam_srch_txt.Text},
	            {"grade", invt_grd_srch_txt.Text},
	            {"function", invt_fun_srch_txt.Text},
                {"cadre", cadInfo},
                {"rptMgr", invt_rptMgr_srch_txt.Text},
                {"location", invt_loc_srch_txt.Text},
                {"dojFrom",appendSQLdateFormat(invt_dojFr_srch_txt.Text)},
                {"dojTo",appendSQLdateFormat(invt_dojTo_srch_txt.Text)}
            };

            try
            {
                queryShooter query = new queryShooter();
                XmlDocument doc = new XmlDocument();
                doc = query.invt_trck_srach_mp_srch(d);

                invt_srch_dgv.Rows.Clear();
                invt_srch_dgv.Refresh();



                //MessageBox.Show(""+doc);

                
                int attrVal = 0;

                XmlNodeList elemList = doc.GetElementsByTagName("Intervention");
                if (elemList.Count == 0)
                {
                    showAlert("No result found. Please try with different search criteria.");
                }
                else
                {
                    removeAlert();
                }
                for (int i = 0; i < elemList.Count; i++)
                {
                    attrVal = elemList[i].Attributes.Count;
                    List<string> myCollection = new List<string>();
                    string s = Convert.ToString(i + 1);
                    myCollection.Add(s);
                    for (int j = 0; j < attrVal; j++)
                    {
                        if (elemList[i].Attributes[j].Name == "iv_invtFromDate" || elemList[i].Attributes[j].Name == "iv_invtToDate")
                        {
                            string str = DateTime.Parse(elemList[i].Attributes[j].Value).ToShortDateString();
                            myCollection.Add(str);
                        }
                        else if (elemList[i].Attributes[j].Name == "ivmp_rate")
                        {
                            myCollection.Add(Math.Round(Convert.ToSingle(elemList[i].Attributes[j].Value), 3).ToString());
                        }
                        else
                        {
                            myCollection.Add(elemList[i].Attributes[j].Value);
                        }

                    }
                    invt_srch_dgv.Rows.Add(myCollection.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Something went wrong.");
            }
            // Loop over pairs with foreach
            //foreach (KeyValuePair<string, int> pair in d)
            //{
            //    Console.WriteLine("{0}, {1}",
            //    pair.Key,
            //    pair.Value);
            //}
        }



        private void invt_clr_srch_btn_Click(object sender, EventArgs e)
        {
            invt_edpNo_srch_txt.Text = "";
            invt_nam_srch_txt.Text = "";
            invt_grd_srch_txt.Text = "";
            invt_fun_srch_txt.Text = "";
            invt_cad_srch_cmb.SelectedIndex = -1;
            invt_dojFr_srch_txt.Text = "";
            invt_dojTo_srch_txt.Text = "";
            invt_rptMgr_srch_txt.Text = "";
            invt_loc_srch_txt.Text = "";
            removeAlert();
        }
        //private void invt_srch_dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) //Code for num validation in datagridview
        //{
        //    try
        //    {
        //        e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        //    }
        //    catch (Exception ex){
        //    }
        //}

        //private void Control_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //    int columnInd = invt_srch_dgv.CurrentCell.ColumnIndex;

        //    if (columnInd == 0)
        //    {
        //        e.Handled = true;
        //    }
        //    else if (columnInd == 1 || columnInd == 8 || columnInd == 14 || columnInd == 17)
        //    {
        //        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }
        //    }
           
        //}
        private void invt_srch_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 19)
            {
                if (invt_srch_dgv[e.ColumnIndex, e.RowIndex].ReadOnly)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void invt_nam_srch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int ascii = Convert.ToInt16(e.KeyChar);

            //if ((ascii >= 97 && ascii <= 122) || (ascii >= 65 && ascii <= 90) || (ascii == 8) || (ascii == 32))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void invt_rptMgr_srch_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int ascii = Convert.ToInt16(e.KeyChar);

            //if ((ascii >= 97 && ascii <= 122) || (ascii >= 65 && ascii <= 90) || (ascii == 8) || (ascii == 32))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void invt_cad_srch_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void invt_cldg_srch_btn_Click(object sender, EventArgs e)
        {
            invt_srch_dgv.Rows.Clear();
            invt_srch_dgv.Refresh();
        }
        private void invt_dojFr_srch_dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime check;
            bool valid = DateTime.TryParse(invt_dojFr_srch_dtp.Text, out check);
            if (valid && (check > DateTime.Now))
            {
                showAlert("*Invalid from date selected. This may affect your search result.");
            }
            else
            {
                removeAlert();
            }
            invt_dojFr_srch_txt.Text = invt_dojFr_srch_dtp.Value.ToString("yyyy-MM-dd");
        }
        private void invt_dojTo_srch_dtp_ValueChanged(object sender, EventArgs e)
        {
            invt_dojTo_srch_txt.Text = invt_dojTo_srch_dtp.Value.ToString("yyyy-MM-dd");
        }
        private void invt_cldtTo_srch_btn_Click(object sender, EventArgs e)
        {
            invt_dojTo_srch_txt.Text = "";
            removeAlert();
        }
        private void showAlert(string msg)
        {
            invt_note_srch_lbl.Text = msg;
            invt_note_srch_lbl.ForeColor = System.Drawing.Color.Red;
        }
        private void removeAlert()
        {
            invt_note_srch_lbl.Text = "Note: Always make search with combination of multiple fields to get quick result.";
            invt_note_srch_lbl.ForeColor = System.Drawing.Color.Blue;
        }
    

        private void invt_cldt_srch_btn_Click(object sender, EventArgs e)
        {
            invt_dojFr_srch_txt.Text = "";
            removeAlert();
        }
        private string appendSQLdateFormat(string date)
        {
            if (date != "")
            {
                date += "T00:00:00.000";
            }
            else
            {
                date = null;
            }
            return date;
        }

        private void invt_expExl_srch_btn_Click(object sender, EventArgs e)
        {

            string excellSheetname = string.Empty;
            bool addDate = false;
            var connectionManagerDatabaseServers = ConfigurationManager.GetSection("excellFile") as NameValueCollection;
            if (connectionManagerDatabaseServers != null)
            {
                excellSheetname = connectionManagerDatabaseServers["excellSheetName"].ToString();
                addDate = Convert.ToBoolean(connectionManagerDatabaseServers["addDate"]);
            }
            int rowcount = Convert.ToInt32(invt_srch_dgv.Rows.Count);
            if (rowcount != 0)
            {
                removeAlert();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = excellSheetname;
                if (addDate)
                {
                    sfd.FileName += "_"+DateTime.Today.ToString("dd_MM_yyyy");
                }
                sfd.FileName += ".xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    excellExporter(invt_srch_dgv, sfd.FileName); // Here dataGridview1 is your grid view name 
                }
            }
            else
            {
                showAlert("*No record to export.");
            }
              
        }


        private void excellExporter(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
          
    }
}
