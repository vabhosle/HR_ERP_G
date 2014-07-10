namespace form1
{
    partial class mp_trck_srch_frm
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
            this.mp_srch_dgv = new System.Windows.Forms.DataGridView();
            this.ManpowerAdd_EDP_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_ReptMngr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_DOJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mp_genRpt_srch_btn = new System.Windows.Forms.Button();
            this.mp_expExl_srch_btn = new System.Windows.Forms.Button();
            this.ManpowerDet_lblEdpNlo = new System.Windows.Forms.Label();
            this.ManpowerDet_lblName = new System.Windows.Forms.Label();
            this.ManpowerDet_lblGrade = new System.Windows.Forms.Label();
            this.ManpowerDet_lblFuction = new System.Windows.Forms.Label();
            this.ManpowerDet_LblReportingMgr = new System.Windows.Forms.Label();
            this.ManpowerDet_LblLocation = new System.Windows.Forms.Label();
            this.ManpowerDet_LblDOJ = new System.Windows.Forms.Label();
            this.mp_nam_srch_txt = new System.Windows.Forms.TextBox();
            this.mp_grd_srch_txt = new System.Windows.Forms.TextBox();
            this.mp_fun_srch_txt = new System.Windows.Forms.TextBox();
            this.mp_rptMgr_srch_txt = new System.Windows.Forms.TextBox();
            this.mp_loc_srch_txt = new System.Windows.Forms.TextBox();
            this.mp_doj_srch_txt = new System.Windows.Forms.TextBox();
            this.mp_edpNo_srch_txt = new System.Windows.Forms.TextBox();
            this.mp_srch_srch_btn = new System.Windows.Forms.Button();
            this.mp_clr_srch_bt = new System.Windows.Forms.Button();
            this.mp_srch_grb = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mp_srch_dgv)).BeginInit();
            this.mp_srch_grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // mp_srch_dgv
            // 
            this.mp_srch_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mp_srch_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mp_srch_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManpowerAdd_EDP_No,
            this.ManpowerAdd_Name,
            this.ManpowerAdd_Grade,
            this.ManpowerAdd_Function,
            this.ManpowerAdd_ReptMngr,
            this.ManpowerAdd_Location,
            this.ManpowerAdd_DOJ});
            this.mp_srch_dgv.Location = new System.Drawing.Point(11, 169);
            this.mp_srch_dgv.Name = "mp_srch_dgv";
            this.mp_srch_dgv.Size = new System.Drawing.Size(1253, 294);
            this.mp_srch_dgv.TabIndex = 32;
            this.mp_srch_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManpowerTrackSearchGrdVew_CellContentClick);
            // 
            // ManpowerAdd_EDP_No
            // 
            this.ManpowerAdd_EDP_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ManpowerAdd_EDP_No.HeaderText = "EDP No";
            this.ManpowerAdd_EDP_No.Name = "ManpowerAdd_EDP_No";
            this.ManpowerAdd_EDP_No.Width = 80;
            // 
            // ManpowerAdd_Name
            // 
            this.ManpowerAdd_Name.HeaderText = "Name";
            this.ManpowerAdd_Name.Name = "ManpowerAdd_Name";
            // 
            // ManpowerAdd_Grade
            // 
            this.ManpowerAdd_Grade.HeaderText = "Grade";
            this.ManpowerAdd_Grade.Name = "ManpowerAdd_Grade";
            // 
            // ManpowerAdd_Function
            // 
            this.ManpowerAdd_Function.HeaderText = "Function";
            this.ManpowerAdd_Function.Name = "ManpowerAdd_Function";
            // 
            // ManpowerAdd_ReptMngr
            // 
            this.ManpowerAdd_ReptMngr.HeaderText = "Reporting Manager";
            this.ManpowerAdd_ReptMngr.Name = "ManpowerAdd_ReptMngr";
            // 
            // ManpowerAdd_Location
            // 
            this.ManpowerAdd_Location.HeaderText = "Location";
            this.ManpowerAdd_Location.Name = "ManpowerAdd_Location";
            // 
            // ManpowerAdd_DOJ
            // 
            this.ManpowerAdd_DOJ.HeaderText = "Date of Joining";
            this.ManpowerAdd_DOJ.Name = "ManpowerAdd_DOJ";
            // 
            // mp_genRpt_srch_btn
            // 
            this.mp_genRpt_srch_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mp_genRpt_srch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_genRpt_srch_btn.Location = new System.Drawing.Point(834, 463);
            this.mp_genRpt_srch_btn.Name = "mp_genRpt_srch_btn";
            this.mp_genRpt_srch_btn.Size = new System.Drawing.Size(151, 32);
            this.mp_genRpt_srch_btn.TabIndex = 35;
            this.mp_genRpt_srch_btn.Text = "Generate Report";
            this.mp_genRpt_srch_btn.UseVisualStyleBackColor = false;
            // 
            // mp_expExl_srch_btn
            // 
            this.mp_expExl_srch_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mp_expExl_srch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_expExl_srch_btn.Location = new System.Drawing.Point(681, 463);
            this.mp_expExl_srch_btn.Name = "mp_expExl_srch_btn";
            this.mp_expExl_srch_btn.Size = new System.Drawing.Size(138, 32);
            this.mp_expExl_srch_btn.TabIndex = 34;
            this.mp_expExl_srch_btn.Text = "Export To Excel";
            this.mp_expExl_srch_btn.UseVisualStyleBackColor = false;
            // 
            // ManpowerDet_lblEdpNlo
            // 
            this.ManpowerDet_lblEdpNlo.AutoSize = true;
            this.ManpowerDet_lblEdpNlo.Location = new System.Drawing.Point(10, 29);
            this.ManpowerDet_lblEdpNlo.Name = "ManpowerDet_lblEdpNlo";
            this.ManpowerDet_lblEdpNlo.Size = new System.Drawing.Size(60, 16);
            this.ManpowerDet_lblEdpNlo.TabIndex = 0;
            this.ManpowerDet_lblEdpNlo.Text = "EDP No.";
            // 
            // ManpowerDet_lblName
            // 
            this.ManpowerDet_lblName.AutoSize = true;
            this.ManpowerDet_lblName.Location = new System.Drawing.Point(10, 70);
            this.ManpowerDet_lblName.Name = "ManpowerDet_lblName";
            this.ManpowerDet_lblName.Size = new System.Drawing.Size(45, 16);
            this.ManpowerDet_lblName.TabIndex = 1;
            this.ManpowerDet_lblName.Text = "Name";
            // 
            // ManpowerDet_lblGrade
            // 
            this.ManpowerDet_lblGrade.AutoSize = true;
            this.ManpowerDet_lblGrade.Location = new System.Drawing.Point(236, 110);
            this.ManpowerDet_lblGrade.Name = "ManpowerDet_lblGrade";
            this.ManpowerDet_lblGrade.Size = new System.Drawing.Size(46, 16);
            this.ManpowerDet_lblGrade.TabIndex = 3;
            this.ManpowerDet_lblGrade.Text = "Grade";
            // 
            // ManpowerDet_lblFuction
            // 
            this.ManpowerDet_lblFuction.AutoSize = true;
            this.ManpowerDet_lblFuction.Location = new System.Drawing.Point(499, 70);
            this.ManpowerDet_lblFuction.Name = "ManpowerDet_lblFuction";
            this.ManpowerDet_lblFuction.Size = new System.Drawing.Size(58, 16);
            this.ManpowerDet_lblFuction.TabIndex = 4;
            this.ManpowerDet_lblFuction.Text = "Function";
            // 
            // ManpowerDet_LblReportingMgr
            // 
            this.ManpowerDet_LblReportingMgr.AutoSize = true;
            this.ManpowerDet_LblReportingMgr.Location = new System.Drawing.Point(719, 70);
            this.ManpowerDet_LblReportingMgr.Name = "ManpowerDet_LblReportingMgr";
            this.ManpowerDet_LblReportingMgr.Size = new System.Drawing.Size(124, 16);
            this.ManpowerDet_LblReportingMgr.TabIndex = 6;
            this.ManpowerDet_LblReportingMgr.Text = "Reporting Manager";
            this.ManpowerDet_LblReportingMgr.Click += new System.EventHandler(this.ManpowerDet_LblReportingMgr_Click);
            // 
            // ManpowerDet_LblLocation
            // 
            this.ManpowerDet_LblLocation.AutoSize = true;
            this.ManpowerDet_LblLocation.Location = new System.Drawing.Point(10, 110);
            this.ManpowerDet_LblLocation.Name = "ManpowerDet_LblLocation";
            this.ManpowerDet_LblLocation.Size = new System.Drawing.Size(59, 16);
            this.ManpowerDet_LblLocation.TabIndex = 7;
            this.ManpowerDet_LblLocation.Text = "Location";
            // 
            // ManpowerDet_LblDOJ
            // 
            this.ManpowerDet_LblDOJ.AutoSize = true;
            this.ManpowerDet_LblDOJ.Location = new System.Drawing.Point(236, 70);
            this.ManpowerDet_LblDOJ.Name = "ManpowerDet_LblDOJ";
            this.ManpowerDet_LblDOJ.Size = new System.Drawing.Size(97, 16);
            this.ManpowerDet_LblDOJ.TabIndex = 9;
            this.ManpowerDet_LblDOJ.Text = "Date of Joining";
            // 
            // mp_nam_srch_txt
            // 
            this.mp_nam_srch_txt.Location = new System.Drawing.Point(88, 67);
            this.mp_nam_srch_txt.Name = "mp_nam_srch_txt";
            this.mp_nam_srch_txt.Size = new System.Drawing.Size(100, 22);
            this.mp_nam_srch_txt.TabIndex = 16;
            // 
            // mp_grd_srch_txt
            // 
            this.mp_grd_srch_txt.Location = new System.Drawing.Point(339, 107);
            this.mp_grd_srch_txt.Name = "mp_grd_srch_txt";
            this.mp_grd_srch_txt.Size = new System.Drawing.Size(100, 22);
            this.mp_grd_srch_txt.TabIndex = 18;
            // 
            // mp_fun_srch_txt
            // 
            this.mp_fun_srch_txt.Location = new System.Drawing.Point(566, 67);
            this.mp_fun_srch_txt.Name = "mp_fun_srch_txt";
            this.mp_fun_srch_txt.Size = new System.Drawing.Size(100, 22);
            this.mp_fun_srch_txt.TabIndex = 19;
            // 
            // mp_rptMgr_srch_txt
            // 
            this.mp_rptMgr_srch_txt.Location = new System.Drawing.Point(860, 67);
            this.mp_rptMgr_srch_txt.Name = "mp_rptMgr_srch_txt";
            this.mp_rptMgr_srch_txt.Size = new System.Drawing.Size(100, 22);
            this.mp_rptMgr_srch_txt.TabIndex = 21;
            this.mp_rptMgr_srch_txt.TextChanged += new System.EventHandler(this.mp_rptMgr_srch_txt_TextChanged);
            // 
            // mp_loc_srch_txt
            // 
            this.mp_loc_srch_txt.Location = new System.Drawing.Point(88, 107);
            this.mp_loc_srch_txt.Name = "mp_loc_srch_txt";
            this.mp_loc_srch_txt.Size = new System.Drawing.Size(100, 22);
            this.mp_loc_srch_txt.TabIndex = 22;
            // 
            // mp_doj_srch_txt
            // 
            this.mp_doj_srch_txt.Location = new System.Drawing.Point(339, 67);
            this.mp_doj_srch_txt.Name = "mp_doj_srch_txt";
            this.mp_doj_srch_txt.Size = new System.Drawing.Size(100, 22);
            this.mp_doj_srch_txt.TabIndex = 24;
            // 
            // mp_edpNo_srch_txt
            // 
            this.mp_edpNo_srch_txt.Location = new System.Drawing.Point(88, 29);
            this.mp_edpNo_srch_txt.Name = "mp_edpNo_srch_txt";
            this.mp_edpNo_srch_txt.Size = new System.Drawing.Size(100, 22);
            this.mp_edpNo_srch_txt.TabIndex = 15;
            // 
            // mp_srch_srch_btn
            // 
            this.mp_srch_srch_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mp_srch_srch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_srch_srch_btn.Location = new System.Drawing.Point(768, 105);
            this.mp_srch_srch_btn.Name = "mp_srch_srch_btn";
            this.mp_srch_srch_btn.Size = new System.Drawing.Size(75, 31);
            this.mp_srch_srch_btn.TabIndex = 29;
            this.mp_srch_srch_btn.Text = "Search";
            this.mp_srch_srch_btn.UseVisualStyleBackColor = false;
            // 
            // mp_clr_srch_bt
            // 
            this.mp_clr_srch_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mp_clr_srch_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_clr_srch_bt.Location = new System.Drawing.Point(885, 102);
            this.mp_clr_srch_bt.Name = "mp_clr_srch_bt";
            this.mp_clr_srch_bt.Size = new System.Drawing.Size(75, 32);
            this.mp_clr_srch_bt.TabIndex = 30;
            this.mp_clr_srch_bt.Text = "Clear";
            this.mp_clr_srch_bt.UseVisualStyleBackColor = false;
            // 
            // mp_srch_grb
            // 
            this.mp_srch_grb.Controls.Add(this.mp_clr_srch_bt);
            this.mp_srch_grb.Controls.Add(this.mp_srch_srch_btn);
            this.mp_srch_grb.Controls.Add(this.mp_edpNo_srch_txt);
            this.mp_srch_grb.Controls.Add(this.mp_doj_srch_txt);
            this.mp_srch_grb.Controls.Add(this.mp_loc_srch_txt);
            this.mp_srch_grb.Controls.Add(this.mp_rptMgr_srch_txt);
            this.mp_srch_grb.Controls.Add(this.mp_fun_srch_txt);
            this.mp_srch_grb.Controls.Add(this.mp_grd_srch_txt);
            this.mp_srch_grb.Controls.Add(this.mp_nam_srch_txt);
            this.mp_srch_grb.Controls.Add(this.ManpowerDet_LblDOJ);
            this.mp_srch_grb.Controls.Add(this.ManpowerDet_LblLocation);
            this.mp_srch_grb.Controls.Add(this.ManpowerDet_LblReportingMgr);
            this.mp_srch_grb.Controls.Add(this.ManpowerDet_lblFuction);
            this.mp_srch_grb.Controls.Add(this.ManpowerDet_lblGrade);
            this.mp_srch_grb.Controls.Add(this.ManpowerDet_lblName);
            this.mp_srch_grb.Controls.Add(this.ManpowerDet_lblEdpNlo);
            this.mp_srch_grb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_srch_grb.Location = new System.Drawing.Point(5, 10);
            this.mp_srch_grb.Name = "mp_srch_grb";
            this.mp_srch_grb.Size = new System.Drawing.Size(981, 153);
            this.mp_srch_grb.TabIndex = 31;
            this.mp_srch_grb.TabStop = false;
            this.mp_srch_grb.Text = "Search Record";
            // 
            // mp_trck_srch_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(998, 498);
            this.Controls.Add(this.mp_genRpt_srch_btn);
            this.Controls.Add(this.mp_expExl_srch_btn);
            this.Controls.Add(this.mp_srch_dgv);
            this.Controls.Add(this.mp_srch_grb);
            this.Name = "mp_trck_srch_frm";
            this.Text = "Manpower Tracker Search Record";
            ((System.ComponentModel.ISupportInitialize)(this.mp_srch_dgv)).EndInit();
            this.mp_srch_grb.ResumeLayout(false);
            this.mp_srch_grb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mp_srch_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_EDP_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_ReptMngr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_DOJ;
        private System.Windows.Forms.Button mp_genRpt_srch_btn;
        private System.Windows.Forms.Button mp_expExl_srch_btn;
        private System.Windows.Forms.Label ManpowerDet_lblEdpNlo;
        private System.Windows.Forms.Label ManpowerDet_lblName;
        private System.Windows.Forms.Label ManpowerDet_lblGrade;
        private System.Windows.Forms.Label ManpowerDet_lblFuction;
        private System.Windows.Forms.Label ManpowerDet_LblReportingMgr;
        private System.Windows.Forms.Label ManpowerDet_LblLocation;
        private System.Windows.Forms.Label ManpowerDet_LblDOJ;
        private System.Windows.Forms.TextBox mp_nam_srch_txt;
        private System.Windows.Forms.TextBox mp_grd_srch_txt;
        private System.Windows.Forms.TextBox mp_fun_srch_txt;
        private System.Windows.Forms.TextBox mp_rptMgr_srch_txt;
        private System.Windows.Forms.TextBox mp_loc_srch_txt;
        private System.Windows.Forms.TextBox mp_doj_srch_txt;
        private System.Windows.Forms.TextBox mp_edpNo_srch_txt;
        private System.Windows.Forms.Button mp_srch_srch_btn;
        private System.Windows.Forms.Button mp_clr_srch_bt;
        private System.Windows.Forms.GroupBox mp_srch_grb;

    }
}