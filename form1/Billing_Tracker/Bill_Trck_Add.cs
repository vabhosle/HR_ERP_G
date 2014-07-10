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
    public partial class bil_trck_add_frm : Form
    {
        public bil_trck_add_frm()
        {
            InitializeComponent();
        }
//-------------------------------------------- DateTimePicker code --------------------------------------- 
        private void bil_dtOfBil_add_dtp_ValueChanged(object sender, EventArgs e)
        {
            bil_dtOfBil_add_txt.Text = bil_dtOfBil_add_dtp.Value.ToString("yyyy-MM-dd");
        }

        private void bil_senForPro_add_dtp_ValueChanged(object sender, EventArgs e)
        {
            bil_senForPro_add_txt.Text = bil_senForPro_add_dtp.Value.ToString("yyyy-MM-dd");
        }

        private bool checkDateRange()
        {
            DateTime frDate;
            DateTime.TryParse(bil_dtOfBil_add_txt.Text, out frDate);
            DateTime toDate;
            DateTime.TryParse(bil_senForPro_add_txt.Text, out toDate);
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
//--------------------------------------------- Clear button code -----------------------------------------
        private void bil_clr_add_btn_Click(object sender, EventArgs e)
        {
            bil_venNam_add_txt.Text = "";
            bil_dtOfBil_add_txt.Text = "";
            bil_bilTow_add_txt.Text = "";
            bil_senForPro_add_txt.Text = "";
            bil_status_add_txt.Text = "";
            bil_bilAmt_add_txt.Text = "";
            bil_balInAcc_add_txt.Text = "";
        }

    }
}
