namespace form1
{
    partial class mp_trck_add_frm
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
            this.mt_tab_main = new System.Windows.Forms.TabControl();
            this.mt_tab_add = new System.Windows.Forms.TabPage();
            this.mt_add_addRecord_grb = new System.Windows.Forms.GroupBox();
            this.mt_add_addRecord_btn = new System.Windows.Forms.Button();
            this.mt_add_addRecord_gdv = new System.Windows.Forms.DataGridView();
            this.ManpowerAdd_EDP_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_ReptMngr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_DOJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mt_tab_search = new System.Windows.Forms.TabPage();
            this.mt_srch_searchRecord_grb = new System.Windows.Forms.GroupBox();
            this.mt_srch_clear_bt = new System.Windows.Forms.Button();
            this.mt_srch_search_btn = new System.Windows.Forms.Button();
            this.mt_srch_edpNo_txt = new System.Windows.Forms.TextBox();
            this.mt_srch_dateOfJoining_txt = new System.Windows.Forms.TextBox();
            this.mt_srch_location_txt = new System.Windows.Forms.TextBox();
            this.mt_srch_reportingManager_txt = new System.Windows.Forms.TextBox();
            this.mt_srch_function_txt = new System.Windows.Forms.TextBox();
            this.mt_srch_grade_txt = new System.Windows.Forms.TextBox();
            this.mt_srch_name_txt = new System.Windows.Forms.TextBox();
            this.ManpowerDet_LblDOJ = new System.Windows.Forms.Label();
            this.ManpowerDet_LblLocation = new System.Windows.Forms.Label();
            this.ManpowerDet_LblReportingMgr = new System.Windows.Forms.Label();
            this.ManpowerDet_lblFuction = new System.Windows.Forms.Label();
            this.ManpowerDet_lblGrade = new System.Windows.Forms.Label();
            this.ManpowerDet_lblName = new System.Windows.Forms.Label();
            this.ManpowerDet_lblEdpNlo = new System.Windows.Forms.Label();
            this.mt_tab_result = new System.Windows.Forms.TabPage();
            this.mt_res_result_grb = new System.Windows.Forms.GroupBox();
            this.mt_res_clearSearch_btn = new System.Windows.Forms.Button();
            this.mt_res_result_gdv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mt_tab_update = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mt_updt_update_btn = new System.Windows.Forms.Button();
            this.mt_updt_clear_btn = new System.Windows.Forms.Button();
            this.mt_updt_edpNo_txt = new System.Windows.Forms.TextBox();
            this.mt_updt_dateOfJoining_txt = new System.Windows.Forms.TextBox();
            this.mt_updt_location_txt = new System.Windows.Forms.TextBox();
            this.mt_updt_reportingManager_txt = new System.Windows.Forms.TextBox();
            this.mt_updt_function_txt = new System.Windows.Forms.TextBox();
            this.mt_updt_grade_txt = new System.Windows.Forms.TextBox();
            this.mt_updt_name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mt_tab_main.SuspendLayout();
            this.mt_tab_add.SuspendLayout();
            this.mt_add_addRecord_grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mt_add_addRecord_gdv)).BeginInit();
            this.mt_tab_search.SuspendLayout();
            this.mt_srch_searchRecord_grb.SuspendLayout();
            this.mt_tab_result.SuspendLayout();
            this.mt_res_result_grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mt_res_result_gdv)).BeginInit();
            this.mt_tab_update.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mt_tab_main
            // 
            this.mt_tab_main.Controls.Add(this.mt_tab_add);
            this.mt_tab_main.Controls.Add(this.mt_tab_search);
            this.mt_tab_main.Controls.Add(this.mt_tab_result);
            this.mt_tab_main.Controls.Add(this.mt_tab_update);
            this.mt_tab_main.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_tab_main.Location = new System.Drawing.Point(12, 7);
            this.mt_tab_main.Name = "mt_tab_main";
            this.mt_tab_main.SelectedIndex = 0;
            this.mt_tab_main.Size = new System.Drawing.Size(1202, 624);
            this.mt_tab_main.TabIndex = 4;
            // 
            // mt_tab_add
            // 
            this.mt_tab_add.Controls.Add(this.mt_add_addRecord_grb);
            this.mt_tab_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_tab_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mt_tab_add.Location = new System.Drawing.Point(4, 28);
            this.mt_tab_add.Name = "mt_tab_add";
            this.mt_tab_add.Padding = new System.Windows.Forms.Padding(3);
            this.mt_tab_add.Size = new System.Drawing.Size(1194, 592);
            this.mt_tab_add.TabIndex = 0;
            this.mt_tab_add.Text = "Add Record";
            this.mt_tab_add.UseVisualStyleBackColor = true;
            // 
            // mt_add_addRecord_grb
            // 
            this.mt_add_addRecord_grb.Controls.Add(this.mt_add_addRecord_btn);
            this.mt_add_addRecord_grb.Controls.Add(this.mt_add_addRecord_gdv);
            this.mt_add_addRecord_grb.Location = new System.Drawing.Point(8, 6);
            this.mt_add_addRecord_grb.Name = "mt_add_addRecord_grb";
            this.mt_add_addRecord_grb.Size = new System.Drawing.Size(1180, 589);
            this.mt_add_addRecord_grb.TabIndex = 4;
            this.mt_add_addRecord_grb.TabStop = false;
            this.mt_add_addRecord_grb.Text = "Add Employee Record";
            this.mt_add_addRecord_grb.Enter += new System.EventHandler(this.mt_add_addRecord_grb_Enter);
            // 
            // mt_add_addRecord_btn
            // 
            this.mt_add_addRecord_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mt_add_addRecord_btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_add_addRecord_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mt_add_addRecord_btn.Location = new System.Drawing.Point(1006, 536);
            this.mt_add_addRecord_btn.Name = "mt_add_addRecord_btn";
            this.mt_add_addRecord_btn.Size = new System.Drawing.Size(180, 40);
            this.mt_add_addRecord_btn.TabIndex = 5;
            this.mt_add_addRecord_btn.Text = "Add Record";
            this.mt_add_addRecord_btn.UseVisualStyleBackColor = false;
            // 
            // mt_add_addRecord_gdv
            // 
            this.mt_add_addRecord_gdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mt_add_addRecord_gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mt_add_addRecord_gdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManpowerAdd_EDP_No,
            this.ManpowerAdd_Name,
            this.ManpowerAdd_Grade,
            this.ManpowerAdd_Function,
            this.ManpowerAdd_ReptMngr,
            this.ManpowerAdd_Location,
            this.ManpowerAdd_DOJ});
            this.mt_add_addRecord_gdv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mt_add_addRecord_gdv.Location = new System.Drawing.Point(6, 26);
            this.mt_add_addRecord_gdv.Name = "mt_add_addRecord_gdv";
            this.mt_add_addRecord_gdv.Size = new System.Drawing.Size(1168, 506);
            this.mt_add_addRecord_gdv.TabIndex = 4;
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
            // mt_tab_search
            // 
            this.mt_tab_search.Controls.Add(this.mt_srch_searchRecord_grb);
            this.mt_tab_search.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_tab_search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mt_tab_search.Location = new System.Drawing.Point(4, 28);
            this.mt_tab_search.Name = "mt_tab_search";
            this.mt_tab_search.Padding = new System.Windows.Forms.Padding(3);
            this.mt_tab_search.Size = new System.Drawing.Size(1194, 592);
            this.mt_tab_search.TabIndex = 1;
            this.mt_tab_search.Text = "Search Record";
            this.mt_tab_search.UseVisualStyleBackColor = true;
            // 
            // mt_srch_searchRecord_grb
            // 
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_clear_bt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_search_btn);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_edpNo_txt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_dateOfJoining_txt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_location_txt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_reportingManager_txt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_function_txt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_grade_txt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.mt_srch_name_txt);
            this.mt_srch_searchRecord_grb.Controls.Add(this.ManpowerDet_LblDOJ);
            this.mt_srch_searchRecord_grb.Controls.Add(this.ManpowerDet_LblLocation);
            this.mt_srch_searchRecord_grb.Controls.Add(this.ManpowerDet_LblReportingMgr);
            this.mt_srch_searchRecord_grb.Controls.Add(this.ManpowerDet_lblFuction);
            this.mt_srch_searchRecord_grb.Controls.Add(this.ManpowerDet_lblGrade);
            this.mt_srch_searchRecord_grb.Controls.Add(this.ManpowerDet_lblName);
            this.mt_srch_searchRecord_grb.Controls.Add(this.ManpowerDet_lblEdpNlo);
            this.mt_srch_searchRecord_grb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_srch_searchRecord_grb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mt_srch_searchRecord_grb.Location = new System.Drawing.Point(8, 6);
            this.mt_srch_searchRecord_grb.Name = "mt_srch_searchRecord_grb";
            this.mt_srch_searchRecord_grb.Size = new System.Drawing.Size(1190, 129);
            this.mt_srch_searchRecord_grb.TabIndex = 32;
            this.mt_srch_searchRecord_grb.TabStop = false;
            this.mt_srch_searchRecord_grb.Text = "Search Employee Record";
            // 
            // mt_srch_clear_bt
            // 
            this.mt_srch_clear_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mt_srch_clear_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_srch_clear_bt.Location = new System.Drawing.Point(1093, 65);
            this.mt_srch_clear_bt.Name = "mt_srch_clear_bt";
            this.mt_srch_clear_bt.Size = new System.Drawing.Size(75, 32);
            this.mt_srch_clear_bt.TabIndex = 30;
            this.mt_srch_clear_bt.Text = "Clear";
            this.mt_srch_clear_bt.UseVisualStyleBackColor = false;
            // 
            // mt_srch_search_btn
            // 
            this.mt_srch_search_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mt_srch_search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_srch_search_btn.Location = new System.Drawing.Point(976, 68);
            this.mt_srch_search_btn.Name = "mt_srch_search_btn";
            this.mt_srch_search_btn.Size = new System.Drawing.Size(75, 31);
            this.mt_srch_search_btn.TabIndex = 29;
            this.mt_srch_search_btn.Text = "Search";
            this.mt_srch_search_btn.UseVisualStyleBackColor = false;
            // 
            // mt_srch_edpNo_txt
            // 
            this.mt_srch_edpNo_txt.Location = new System.Drawing.Point(75, 29);
            this.mt_srch_edpNo_txt.Name = "mt_srch_edpNo_txt";
            this.mt_srch_edpNo_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_srch_edpNo_txt.TabIndex = 15;
            // 
            // mt_srch_dateOfJoining_txt
            // 
            this.mt_srch_dateOfJoining_txt.Location = new System.Drawing.Point(746, 26);
            this.mt_srch_dateOfJoining_txt.Name = "mt_srch_dateOfJoining_txt";
            this.mt_srch_dateOfJoining_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_srch_dateOfJoining_txt.TabIndex = 24;
            // 
            // mt_srch_location_txt
            // 
            this.mt_srch_location_txt.Location = new System.Drawing.Point(1018, 23);
            this.mt_srch_location_txt.Name = "mt_srch_location_txt";
            this.mt_srch_location_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_srch_location_txt.TabIndex = 22;
            // 
            // mt_srch_reportingManager_txt
            // 
            this.mt_srch_reportingManager_txt.Location = new System.Drawing.Point(746, 70);
            this.mt_srch_reportingManager_txt.Name = "mt_srch_reportingManager_txt";
            this.mt_srch_reportingManager_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_srch_reportingManager_txt.TabIndex = 21;
            // 
            // mt_srch_function_txt
            // 
            this.mt_srch_function_txt.Location = new System.Drawing.Point(75, 70);
            this.mt_srch_function_txt.Name = "mt_srch_function_txt";
            this.mt_srch_function_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_srch_function_txt.TabIndex = 19;
            // 
            // mt_srch_grade_txt
            // 
            this.mt_srch_grade_txt.Location = new System.Drawing.Point(364, 70);
            this.mt_srch_grade_txt.Name = "mt_srch_grade_txt";
            this.mt_srch_grade_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_srch_grade_txt.TabIndex = 18;
            // 
            // mt_srch_name_txt
            // 
            this.mt_srch_name_txt.Location = new System.Drawing.Point(364, 26);
            this.mt_srch_name_txt.Name = "mt_srch_name_txt";
            this.mt_srch_name_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_srch_name_txt.TabIndex = 16;
            // 
            // ManpowerDet_LblDOJ
            // 
            this.ManpowerDet_LblDOJ.AutoSize = true;
            this.ManpowerDet_LblDOJ.Location = new System.Drawing.Point(617, 29);
            this.ManpowerDet_LblDOJ.Name = "ManpowerDet_LblDOJ";
            this.ManpowerDet_LblDOJ.Size = new System.Drawing.Size(97, 16);
            this.ManpowerDet_LblDOJ.TabIndex = 9;
            this.ManpowerDet_LblDOJ.Text = "Date of Joining";
            // 
            // ManpowerDet_LblLocation
            // 
            this.ManpowerDet_LblLocation.AutoSize = true;
            this.ManpowerDet_LblLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManpowerDet_LblLocation.Location = new System.Drawing.Point(952, 26);
            this.ManpowerDet_LblLocation.Name = "ManpowerDet_LblLocation";
            this.ManpowerDet_LblLocation.Size = new System.Drawing.Size(59, 16);
            this.ManpowerDet_LblLocation.TabIndex = 7;
            this.ManpowerDet_LblLocation.Text = "Location";
            // 
            // ManpowerDet_LblReportingMgr
            // 
            this.ManpowerDet_LblReportingMgr.AutoSize = true;
            this.ManpowerDet_LblReportingMgr.Location = new System.Drawing.Point(617, 73);
            this.ManpowerDet_LblReportingMgr.Name = "ManpowerDet_LblReportingMgr";
            this.ManpowerDet_LblReportingMgr.Size = new System.Drawing.Size(124, 16);
            this.ManpowerDet_LblReportingMgr.TabIndex = 6;
            this.ManpowerDet_LblReportingMgr.Text = "Reporting Manager";
            // 
            // ManpowerDet_lblFuction
            // 
            this.ManpowerDet_lblFuction.AutoSize = true;
            this.ManpowerDet_lblFuction.Location = new System.Drawing.Point(10, 73);
            this.ManpowerDet_lblFuction.Name = "ManpowerDet_lblFuction";
            this.ManpowerDet_lblFuction.Size = new System.Drawing.Size(58, 16);
            this.ManpowerDet_lblFuction.TabIndex = 4;
            this.ManpowerDet_lblFuction.Text = "Function";
            // 
            // ManpowerDet_lblGrade
            // 
            this.ManpowerDet_lblGrade.AutoSize = true;
            this.ManpowerDet_lblGrade.Location = new System.Drawing.Point(314, 73);
            this.ManpowerDet_lblGrade.Name = "ManpowerDet_lblGrade";
            this.ManpowerDet_lblGrade.Size = new System.Drawing.Size(46, 16);
            this.ManpowerDet_lblGrade.TabIndex = 3;
            this.ManpowerDet_lblGrade.Text = "Grade";
            // 
            // ManpowerDet_lblName
            // 
            this.ManpowerDet_lblName.AutoSize = true;
            this.ManpowerDet_lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManpowerDet_lblName.Location = new System.Drawing.Point(314, 29);
            this.ManpowerDet_lblName.Name = "ManpowerDet_lblName";
            this.ManpowerDet_lblName.Size = new System.Drawing.Size(45, 16);
            this.ManpowerDet_lblName.TabIndex = 1;
            this.ManpowerDet_lblName.Text = "Name";
            // 
            // ManpowerDet_lblEdpNlo
            // 
            this.ManpowerDet_lblEdpNlo.AutoSize = true;
            this.ManpowerDet_lblEdpNlo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManpowerDet_lblEdpNlo.Location = new System.Drawing.Point(10, 29);
            this.ManpowerDet_lblEdpNlo.Name = "ManpowerDet_lblEdpNlo";
            this.ManpowerDet_lblEdpNlo.Size = new System.Drawing.Size(60, 16);
            this.ManpowerDet_lblEdpNlo.TabIndex = 0;
            this.ManpowerDet_lblEdpNlo.Text = "EDP No.";
            // 
            // mt_tab_result
            // 
            this.mt_tab_result.Controls.Add(this.mt_res_result_grb);
            this.mt_tab_result.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_tab_result.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mt_tab_result.Location = new System.Drawing.Point(4, 28);
            this.mt_tab_result.Name = "mt_tab_result";
            this.mt_tab_result.Size = new System.Drawing.Size(1194, 592);
            this.mt_tab_result.TabIndex = 2;
            this.mt_tab_result.Text = "Result";
            this.mt_tab_result.UseVisualStyleBackColor = true;
            // 
            // mt_res_result_grb
            // 
            this.mt_res_result_grb.Controls.Add(this.mt_res_clearSearch_btn);
            this.mt_res_result_grb.Controls.Add(this.mt_res_result_gdv);
            this.mt_res_result_grb.Location = new System.Drawing.Point(8, 10);
            this.mt_res_result_grb.Name = "mt_res_result_grb";
            this.mt_res_result_grb.Size = new System.Drawing.Size(1190, 581);
            this.mt_res_result_grb.TabIndex = 4;
            this.mt_res_result_grb.TabStop = false;
            this.mt_res_result_grb.Text = "Result";
            // 
            // mt_res_clearSearch_btn
            // 
            this.mt_res_clearSearch_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mt_res_clearSearch_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_res_clearSearch_btn.ForeColor = System.Drawing.Color.Black;
            this.mt_res_clearSearch_btn.Location = new System.Drawing.Point(1058, 537);
            this.mt_res_clearSearch_btn.Name = "mt_res_clearSearch_btn";
            this.mt_res_clearSearch_btn.Size = new System.Drawing.Size(120, 34);
            this.mt_res_clearSearch_btn.TabIndex = 22;
            this.mt_res_clearSearch_btn.Text = "Clear Search";
            this.mt_res_clearSearch_btn.UseVisualStyleBackColor = false;
            // 
            // mt_res_result_gdv
            // 
            this.mt_res_result_gdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mt_res_result_gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mt_res_result_gdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mt_res_result_gdv.Location = new System.Drawing.Point(6, 26);
            this.mt_res_result_gdv.Name = "mt_res_result_gdv";
            this.mt_res_result_gdv.Size = new System.Drawing.Size(1172, 506);
            this.mt_res_result_gdv.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "EDP No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Function";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Reporting Manager";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Location";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Date of Joining";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // mt_tab_update
            // 
            this.mt_tab_update.Controls.Add(this.groupBox3);
            this.mt_tab_update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_tab_update.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mt_tab_update.Location = new System.Drawing.Point(4, 28);
            this.mt_tab_update.Name = "mt_tab_update";
            this.mt_tab_update.Size = new System.Drawing.Size(1194, 592);
            this.mt_tab_update.TabIndex = 3;
            this.mt_tab_update.Text = "Update Record";
            this.mt_tab_update.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mt_updt_update_btn);
            this.groupBox3.Controls.Add(this.mt_updt_clear_btn);
            this.groupBox3.Controls.Add(this.mt_updt_edpNo_txt);
            this.groupBox3.Controls.Add(this.mt_updt_dateOfJoining_txt);
            this.groupBox3.Controls.Add(this.mt_updt_location_txt);
            this.groupBox3.Controls.Add(this.mt_updt_reportingManager_txt);
            this.groupBox3.Controls.Add(this.mt_updt_function_txt);
            this.groupBox3.Controls.Add(this.mt_updt_grade_txt);
            this.groupBox3.Controls.Add(this.mt_updt_name_txt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1183, 180);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Employee Recored";
            // 
            // mt_updt_update_btn
            // 
            this.mt_updt_update_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mt_updt_update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_updt_update_btn.ForeColor = System.Drawing.Color.Black;
            this.mt_updt_update_btn.Location = new System.Drawing.Point(407, 125);
            this.mt_updt_update_btn.Name = "mt_updt_update_btn";
            this.mt_updt_update_btn.Size = new System.Drawing.Size(120, 34);
            this.mt_updt_update_btn.TabIndex = 39;
            this.mt_updt_update_btn.Text = "Update";
            this.mt_updt_update_btn.UseVisualStyleBackColor = false;
            // 
            // mt_updt_clear_btn
            // 
            this.mt_updt_clear_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mt_updt_clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_updt_clear_btn.ForeColor = System.Drawing.Color.Black;
            this.mt_updt_clear_btn.Location = new System.Drawing.Point(555, 125);
            this.mt_updt_clear_btn.Name = "mt_updt_clear_btn";
            this.mt_updt_clear_btn.Size = new System.Drawing.Size(120, 34);
            this.mt_updt_clear_btn.TabIndex = 40;
            this.mt_updt_clear_btn.Text = "Clear";
            this.mt_updt_clear_btn.UseVisualStyleBackColor = false;
            // 
            // mt_updt_edpNo_txt
            // 
            this.mt_updt_edpNo_txt.Location = new System.Drawing.Point(69, 36);
            this.mt_updt_edpNo_txt.Name = "mt_updt_edpNo_txt";
            this.mt_updt_edpNo_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_updt_edpNo_txt.TabIndex = 32;
            // 
            // mt_updt_dateOfJoining_txt
            // 
            this.mt_updt_dateOfJoining_txt.Location = new System.Drawing.Point(740, 33);
            this.mt_updt_dateOfJoining_txt.Name = "mt_updt_dateOfJoining_txt";
            this.mt_updt_dateOfJoining_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_updt_dateOfJoining_txt.TabIndex = 38;
            // 
            // mt_updt_location_txt
            // 
            this.mt_updt_location_txt.Location = new System.Drawing.Point(1014, 30);
            this.mt_updt_location_txt.Name = "mt_updt_location_txt";
            this.mt_updt_location_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_updt_location_txt.TabIndex = 37;
            // 
            // mt_updt_reportingManager_txt
            // 
            this.mt_updt_reportingManager_txt.Location = new System.Drawing.Point(740, 77);
            this.mt_updt_reportingManager_txt.Name = "mt_updt_reportingManager_txt";
            this.mt_updt_reportingManager_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_updt_reportingManager_txt.TabIndex = 36;
            // 
            // mt_updt_function_txt
            // 
            this.mt_updt_function_txt.Location = new System.Drawing.Point(69, 77);
            this.mt_updt_function_txt.Name = "mt_updt_function_txt";
            this.mt_updt_function_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_updt_function_txt.TabIndex = 35;
            // 
            // mt_updt_grade_txt
            // 
            this.mt_updt_grade_txt.Location = new System.Drawing.Point(358, 77);
            this.mt_updt_grade_txt.Name = "mt_updt_grade_txt";
            this.mt_updt_grade_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_updt_grade_txt.TabIndex = 34;
            // 
            // mt_updt_name_txt
            // 
            this.mt_updt_name_txt.Location = new System.Drawing.Point(358, 33);
            this.mt_updt_name_txt.Name = "mt_updt_name_txt";
            this.mt_updt_name_txt.Size = new System.Drawing.Size(154, 22);
            this.mt_updt_name_txt.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date of Joining";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(946, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Reporting Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Function";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(308, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(4, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "EDP No.";
            // 
            // mp_trck_add_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1214, 637);
            this.Controls.Add(this.mt_tab_main);
            this.Name = "mp_trck_add_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manpower Tracker";
            this.Load += new System.EventHandler(this.Manpower_Tracker_Add_Record_Load);
            this.mt_tab_main.ResumeLayout(false);
            this.mt_tab_add.ResumeLayout(false);
            this.mt_add_addRecord_grb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mt_add_addRecord_gdv)).EndInit();
            this.mt_tab_search.ResumeLayout(false);
            this.mt_srch_searchRecord_grb.ResumeLayout(false);
            this.mt_srch_searchRecord_grb.PerformLayout();
            this.mt_tab_result.ResumeLayout(false);
            this.mt_res_result_grb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mt_res_result_gdv)).EndInit();
            this.mt_tab_update.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mt_tab_main;
        private System.Windows.Forms.TabPage mt_tab_add;
        private System.Windows.Forms.TabPage mt_tab_search;
        private System.Windows.Forms.TabPage mt_tab_result;
        private System.Windows.Forms.TabPage mt_tab_update;
        private System.Windows.Forms.GroupBox mt_srch_searchRecord_grb;
        private System.Windows.Forms.Button mt_srch_clear_bt;
        private System.Windows.Forms.Button mt_srch_search_btn;
        private System.Windows.Forms.TextBox mt_srch_edpNo_txt;
        private System.Windows.Forms.TextBox mt_srch_dateOfJoining_txt;
        private System.Windows.Forms.TextBox mt_srch_location_txt;
        private System.Windows.Forms.TextBox mt_srch_reportingManager_txt;
        private System.Windows.Forms.TextBox mt_srch_function_txt;
        private System.Windows.Forms.TextBox mt_srch_grade_txt;
        private System.Windows.Forms.TextBox mt_srch_name_txt;
        private System.Windows.Forms.Label ManpowerDet_LblDOJ;
        private System.Windows.Forms.Label ManpowerDet_LblLocation;
        private System.Windows.Forms.Label ManpowerDet_LblReportingMgr;
        private System.Windows.Forms.Label ManpowerDet_lblFuction;
        private System.Windows.Forms.Label ManpowerDet_lblGrade;
        private System.Windows.Forms.Label ManpowerDet_lblName;
        private System.Windows.Forms.Label ManpowerDet_lblEdpNlo;
        private System.Windows.Forms.GroupBox mt_res_result_grb;
        private System.Windows.Forms.DataGridView mt_res_result_gdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox mt_add_addRecord_grb;
        private System.Windows.Forms.Button mt_add_addRecord_btn;
        private System.Windows.Forms.DataGridView mt_add_addRecord_gdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_EDP_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_ReptMngr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_DOJ;
        private System.Windows.Forms.Button mt_res_clearSearch_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox mt_updt_edpNo_txt;
        private System.Windows.Forms.TextBox mt_updt_dateOfJoining_txt;
        private System.Windows.Forms.TextBox mt_updt_location_txt;
        private System.Windows.Forms.TextBox mt_updt_reportingManager_txt;
        private System.Windows.Forms.TextBox mt_updt_function_txt;
        private System.Windows.Forms.TextBox mt_updt_grade_txt;
        private System.Windows.Forms.TextBox mt_updt_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button mt_updt_update_btn;
        private System.Windows.Forms.Button mt_updt_clear_btn;
    }
}