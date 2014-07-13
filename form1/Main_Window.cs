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
    public partial class main_Window : Form
    {
        

        public main_Window()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InterventionTrackSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invt_trck_add_frm interventionTracker = new invt_trck_add_frm();
            interventionTracker.MdiParent = this;
            interventionTracker.Show();
        }

        private void TrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void ManpowerTrackSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp_trck_srch_frm ManpowerTrack_SearchRec = new mp_trck_srch_frm();
            ManpowerTrack_SearchRec.MdiParent = this;
            ManpowerTrack_SearchRec.Show();
        }

        private void ManpowerTrackAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp_tracker_frm ManpowerTrack_AddRec = new mp_tracker_frm();
            ManpowerTrack_AddRec.MdiParent = this;
            ManpowerTrack_AddRec.Show();
        }

        private void InterventionTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_Window_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

           
        }

        private void InterventionTrackAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp_tracker_frm manpowerTracker = new mp_tracker_frm();
            manpowerTracker.MdiParent = this;
            manpowerTracker.Show();
        }

        private void billingTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bil_Trck_Add_frm billingTracker = new bil_Trck_Add_frm();
            billingTracker.MdiParent = this;
            billingTracker.Show();
        }
    }
}
