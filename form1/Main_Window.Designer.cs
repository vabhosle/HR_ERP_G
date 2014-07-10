namespace form1
{
    partial class main_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Window));
            this.TrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InterventionTrackAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InterventionTrackSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillingTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillingTrackSearchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BillingTrackAddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionReportEmpWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManpowerTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_mnuStrp = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_mnuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrackerToolStripMenuItem
            // 
            this.TrackerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InterventionTrackAddToolStripMenuItem,
            this.InterventionTrackSearchToolStripMenuItem,
            this.billingTrackerToolStripMenuItem});
            this.TrackerToolStripMenuItem.Name = "TrackerToolStripMenuItem";
            this.TrackerToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.TrackerToolStripMenuItem.Text = "Trackers";
            this.TrackerToolStripMenuItem.ToolTipText = "Select Intervention Tracker";
            this.TrackerToolStripMenuItem.Click += new System.EventHandler(this.InterventionTrackToolStripMenuItem_Click);
            // 
            // InterventionTrackAddToolStripMenuItem
            // 
            this.InterventionTrackAddToolStripMenuItem.Name = "InterventionTrackAddToolStripMenuItem";
            this.InterventionTrackAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InterventionTrackAddToolStripMenuItem.Text = "Manpower Tracker";
            this.InterventionTrackAddToolStripMenuItem.ToolTipText = "Select Add Record";
            this.InterventionTrackAddToolStripMenuItem.Click += new System.EventHandler(this.InterventionTrackAddToolStripMenuItem_Click);
            // 
            // InterventionTrackSearchToolStripMenuItem
            // 
            this.InterventionTrackSearchToolStripMenuItem.Name = "InterventionTrackSearchToolStripMenuItem";
            this.InterventionTrackSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InterventionTrackSearchToolStripMenuItem.Text = "Intervention Tracker";
            this.InterventionTrackSearchToolStripMenuItem.ToolTipText = "Select Search";
            this.InterventionTrackSearchToolStripMenuItem.Click += new System.EventHandler(this.InterventionTrackSearchToolStripMenuItem_Click);
            // 
            // billingTrackerToolStripMenuItem
            // 
            this.billingTrackerToolStripMenuItem.Name = "billingTrackerToolStripMenuItem";
            this.billingTrackerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billingTrackerToolStripMenuItem.Text = "Billing Tracker";
            this.billingTrackerToolStripMenuItem.Click += new System.EventHandler(this.billingTrackerToolStripMenuItem_Click);
            // 
            // BillingTrackToolStripMenuItem
            // 
            this.BillingTrackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BillingTrackSearchToolStripMenuItem2,
            this.BillingTrackAddToolStripMenuItem2,
            this.interventionReportEmpWiseToolStripMenuItem,
            this.billingReportToolStripMenuItem});
            this.BillingTrackToolStripMenuItem.Name = "BillingTrackToolStripMenuItem";
            this.BillingTrackToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.BillingTrackToolStripMenuItem.Text = "Reports";
            this.BillingTrackToolStripMenuItem.ToolTipText = "Select Billing Tracker";
            // 
            // BillingTrackSearchToolStripMenuItem2
            // 
            this.BillingTrackSearchToolStripMenuItem2.Name = "BillingTrackSearchToolStripMenuItem2";
            this.BillingTrackSearchToolStripMenuItem2.Size = new System.Drawing.Size(237, 22);
            this.BillingTrackSearchToolStripMenuItem2.Text = "Manpower Report";
            this.BillingTrackSearchToolStripMenuItem2.ToolTipText = "Select Search";
            // 
            // BillingTrackAddToolStripMenuItem2
            // 
            this.BillingTrackAddToolStripMenuItem2.Name = "BillingTrackAddToolStripMenuItem2";
            this.BillingTrackAddToolStripMenuItem2.Size = new System.Drawing.Size(237, 22);
            this.BillingTrackAddToolStripMenuItem2.Text = "Intervention Report";
            this.BillingTrackAddToolStripMenuItem2.ToolTipText = "Select Add Record";
            // 
            // interventionReportEmpWiseToolStripMenuItem
            // 
            this.interventionReportEmpWiseToolStripMenuItem.Name = "interventionReportEmpWiseToolStripMenuItem";
            this.interventionReportEmpWiseToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.interventionReportEmpWiseToolStripMenuItem.Text = "Intervention Report (Emp wise)";
            // 
            // billingReportToolStripMenuItem
            // 
            this.billingReportToolStripMenuItem.Name = "billingReportToolStripMenuItem";
            this.billingReportToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.billingReportToolStripMenuItem.Text = "Billing Report";
            // 
            // ManpowerTrackToolStripMenuItem
            // 
            this.ManpowerTrackToolStripMenuItem.Name = "ManpowerTrackToolStripMenuItem";
            this.ManpowerTrackToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ManpowerTrackToolStripMenuItem.Text = "Help";
            this.ManpowerTrackToolStripMenuItem.ToolTipText = "Select Manpower Tracker";
            // 
            // main_mnuStrp
            // 
            this.main_mnuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrackerToolStripMenuItem,
            this.BillingTrackToolStripMenuItem,
            this.ManpowerTrackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.main_mnuStrp.Location = new System.Drawing.Point(0, 0);
            this.main_mnuStrp.Name = "main_mnuStrp";
            this.main_mnuStrp.Size = new System.Drawing.Size(1262, 24);
            this.main_mnuStrp.TabIndex = 0;
            this.main_mnuStrp.Text = "MenuStrip";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit to Window";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::form1.Properties.Resources._398px_Godrej_Logo_svg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1262, 453);
            this.Controls.Add(this.main_mnuStrp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_mnuStrp;
            this.Name = "main_Window";
            this.Text = "HR-Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Window_Load);
            this.main_mnuStrp.ResumeLayout(false);
            this.main_mnuStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem TrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InterventionTrackSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InterventionTrackAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BillingTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BillingTrackSearchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem BillingTrackAddToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ManpowerTrackToolStripMenuItem;
        private System.Windows.Forms.MenuStrip main_mnuStrp;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionReportEmpWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingReportToolStripMenuItem;

    }
}



