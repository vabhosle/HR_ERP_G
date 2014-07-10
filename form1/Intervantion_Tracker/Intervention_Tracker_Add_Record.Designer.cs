namespace form1
{
    partial class Intervention_Tracker_Add_Record
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
            this.InterventionTrackAddGrdVew = new System.Windows.Forms.DataGridView();
            this.Classroom_EDP_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Candidate_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.VenueCostAddTxt = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.InterventionTrackAddInterventionIdTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddGrpBox = new System.Windows.Forms.GroupBox();
            this.InterventionTrackClearBtn = new System.Windows.Forms.Button();
            this.InterventionTrackAdd1Btn = new System.Windows.Forms.Button();
            this.InterventionTrackAddCostPerPersonTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddTotalTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddAccomodationTxt = new System.Windows.Forms.TextBox();
            this.TrasportationAddTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddTrainerFeesTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddVenueCostTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddNoOfPeopleTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddNPSTxt = new System.Windows.Forms.TextBox();
            this.AvgRatingAddTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddTrainerNameTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddCourseHoursTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddCourseDateToTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddCourseDateFromTxt = new System.Windows.Forms.TextBox();
            this.MonthAddTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddCourseNameTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddTrainingLocationTxt = new System.Windows.Forms.TextBox();
            this.InterventionTrackAddCadreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InterventionTrackAddRec2Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InterventionTrackAddGrdVew)).BeginInit();
            this.InterventionTrackAddGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InterventionTrackAddGrdVew
            // 
            this.InterventionTrackAddGrdVew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InterventionTrackAddGrdVew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InterventionTrackAddGrdVew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classroom_EDP_No,
            this.Class_Name,
            this.Class_Grade,
            this.Class_Function,
            this.Class_Candidate_Location});
            this.InterventionTrackAddGrdVew.Location = new System.Drawing.Point(2, 264);
            this.InterventionTrackAddGrdVew.Name = "InterventionTrackAddGrdVew";
            this.InterventionTrackAddGrdVew.Size = new System.Drawing.Size(1262, 201);
            this.InterventionTrackAddGrdVew.TabIndex = 21;
            this.InterventionTrackAddGrdVew.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.InterventionTrackAddGrdVew_CellValidating);
            // 
            // Classroom_EDP_No
            // 
            this.Classroom_EDP_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Classroom_EDP_No.HeaderText = "EDP No";
            this.Classroom_EDP_No.Name = "Classroom_EDP_No";
            this.Classroom_EDP_No.Width = 80;
            // 
            // Class_Name
            // 
            this.Class_Name.HeaderText = "Name";
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.ReadOnly = true;
            // 
            // Class_Grade
            // 
            this.Class_Grade.HeaderText = "Grade";
            this.Class_Grade.Name = "Class_Grade";
            this.Class_Grade.ReadOnly = true;
            // 
            // Class_Function
            // 
            this.Class_Function.HeaderText = "Function";
            this.Class_Function.Name = "Class_Function";
            this.Class_Function.ReadOnly = true;
            // 
            // Class_Candidate_Location
            // 
            this.Class_Candidate_Location.HeaderText = "Candidate Location";
            this.Class_Candidate_Location.Name = "Class_Candidate_Location";
            this.Class_Candidate_Location.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intervention ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cadre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cost Per Person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(807, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Trainer Fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1068, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trasportation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "No. of People";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(807, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Trainer\'s Name";
            // 
            // VenueCostAddTxt
            // 
            this.VenueCostAddTxt.AutoSize = true;
            this.VenueCostAddTxt.Location = new System.Drawing.Point(526, 132);
            this.VenueCostAddTxt.Name = "VenueCostAddTxt";
            this.VenueCostAddTxt.Size = new System.Drawing.Size(77, 16);
            this.VenueCostAddTxt.TabIndex = 18;
            this.VenueCostAddTxt.Text = "Venue Cost";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(273, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 16);
            this.label19.TabIndex = 19;
            this.label19.Text = "Course Date To";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(526, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Training Location";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1068, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 16);
            this.label21.TabIndex = 21;
            this.label21.Text = "Month";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(526, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 16);
            this.label22.TabIndex = 22;
            this.label22.Text = "Course Hours";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 132);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 16);
            this.label23.TabIndex = 23;
            this.label23.Text = "NPS";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(807, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 16);
            this.label24.TabIndex = 24;
            this.label24.Text = "Course Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1068, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 16);
            this.label25.TabIndex = 25;
            this.label25.Text = "Avg Rating";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 185);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 16);
            this.label26.TabIndex = 26;
            this.label26.Text = "Accomodation";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 16);
            this.label27.TabIndex = 27;
            this.label27.Text = "Course Date From";
            // 
            // InterventionTrackAddInterventionIdTxt
            // 
            this.InterventionTrackAddInterventionIdTxt.Location = new System.Drawing.Point(133, 28);
            this.InterventionTrackAddInterventionIdTxt.Name = "InterventionTrackAddInterventionIdTxt";
            this.InterventionTrackAddInterventionIdTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddInterventionIdTxt.TabIndex = 1;
            this.InterventionTrackAddInterventionIdTxt.TextChanged += new System.EventHandler(this.InterventionIDAddTxt_TextChanged);
            // 
            // InterventionTrackAddGrpBox
            // 
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackClearBtn);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAdd1Btn);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddCostPerPersonTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddTotalTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddAccomodationTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.TrasportationAddTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label26);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddTrainerFeesTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label12);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label7);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddVenueCostTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddNoOfPeopleTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddNPSTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.VenueCostAddTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.AvgRatingAddTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddTrainerNameTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label23);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label9);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddCourseHoursTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label14);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label8);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label25);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddCourseDateToTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddCourseDateFromTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.MonthAddTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label27);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label22);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddCourseNameTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label15);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddTrainingLocationTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label19);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddCadreTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label1);
            this.InterventionTrackAddGrpBox.Controls.Add(this.InterventionTrackAddInterventionIdTxt);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label3);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label21);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label24);
            this.InterventionTrackAddGrpBox.Controls.Add(this.label20);
            this.InterventionTrackAddGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterventionTrackAddGrpBox.Location = new System.Drawing.Point(2, 12);
            this.InterventionTrackAddGrpBox.Name = "InterventionTrackAddGrpBox";
            this.InterventionTrackAddGrpBox.Size = new System.Drawing.Size(1272, 220);
            this.InterventionTrackAddGrpBox.TabIndex = 29;
            this.InterventionTrackAddGrpBox.TabStop = false;
            this.InterventionTrackAddGrpBox.Text = "Add Record";
            this.InterventionTrackAddGrpBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // InterventionTrackClearBtn
            // 
            this.InterventionTrackClearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InterventionTrackClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterventionTrackClearBtn.Location = new System.Drawing.Point(1117, 170);
            this.InterventionTrackClearBtn.Name = "InterventionTrackClearBtn";
            this.InterventionTrackClearBtn.Size = new System.Drawing.Size(146, 34);
            this.InterventionTrackClearBtn.TabIndex = 20;
            this.InterventionTrackClearBtn.Text = "Clear";
            this.InterventionTrackClearBtn.UseVisualStyleBackColor = false;
            // 
            // InterventionTrackAdd1Btn
            // 
            this.InterventionTrackAdd1Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InterventionTrackAdd1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterventionTrackAdd1Btn.Location = new System.Drawing.Point(866, 170);
            this.InterventionTrackAdd1Btn.Name = "InterventionTrackAdd1Btn";
            this.InterventionTrackAdd1Btn.Size = new System.Drawing.Size(146, 34);
            this.InterventionTrackAdd1Btn.TabIndex = 19;
            this.InterventionTrackAdd1Btn.Text = "Add Record";
            this.InterventionTrackAdd1Btn.UseVisualStyleBackColor = false;
            // 
            // InterventionTrackAddCostPerPersonTxt
            // 
            this.InterventionTrackAddCostPerPersonTxt.Location = new System.Drawing.Point(648, 182);
            this.InterventionTrackAddCostPerPersonTxt.Name = "InterventionTrackAddCostPerPersonTxt";
            this.InterventionTrackAddCostPerPersonTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddCostPerPersonTxt.TabIndex = 18;
            // 
            // InterventionTrackAddTotalTxt
            // 
            this.InterventionTrackAddTotalTxt.Location = new System.Drawing.Point(382, 182);
            this.InterventionTrackAddTotalTxt.Name = "InterventionTrackAddTotalTxt";
            this.InterventionTrackAddTotalTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddTotalTxt.TabIndex = 17;
            // 
            // InterventionTrackAddAccomodationTxt
            // 
            this.InterventionTrackAddAccomodationTxt.Location = new System.Drawing.Point(133, 182);
            this.InterventionTrackAddAccomodationTxt.Name = "InterventionTrackAddAccomodationTxt";
            this.InterventionTrackAddAccomodationTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddAccomodationTxt.TabIndex = 16;
            // 
            // TrasportationAddTxt
            // 
            this.TrasportationAddTxt.Location = new System.Drawing.Point(1163, 129);
            this.TrasportationAddTxt.Name = "TrasportationAddTxt";
            this.TrasportationAddTxt.Size = new System.Drawing.Size(100, 22);
            this.TrasportationAddTxt.TabIndex = 15;
            // 
            // InterventionTrackAddTrainerFeesTxt
            // 
            this.InterventionTrackAddTrainerFeesTxt.Location = new System.Drawing.Point(912, 129);
            this.InterventionTrackAddTrainerFeesTxt.Name = "InterventionTrackAddTrainerFeesTxt";
            this.InterventionTrackAddTrainerFeesTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddTrainerFeesTxt.TabIndex = 14;
            // 
            // InterventionTrackAddVenueCostTxt
            // 
            this.InterventionTrackAddVenueCostTxt.Location = new System.Drawing.Point(648, 129);
            this.InterventionTrackAddVenueCostTxt.Name = "InterventionTrackAddVenueCostTxt";
            this.InterventionTrackAddVenueCostTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddVenueCostTxt.TabIndex = 13;
            // 
            // InterventionTrackAddNoOfPeopleTxt
            // 
            this.InterventionTrackAddNoOfPeopleTxt.Location = new System.Drawing.Point(382, 127);
            this.InterventionTrackAddNoOfPeopleTxt.Name = "InterventionTrackAddNoOfPeopleTxt";
            this.InterventionTrackAddNoOfPeopleTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddNoOfPeopleTxt.TabIndex = 12;
            // 
            // InterventionTrackAddNPSTxt
            // 
            this.InterventionTrackAddNPSTxt.Location = new System.Drawing.Point(133, 129);
            this.InterventionTrackAddNPSTxt.Name = "InterventionTrackAddNPSTxt";
            this.InterventionTrackAddNPSTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddNPSTxt.TabIndex = 11;
            // 
            // AvgRatingAddTxt
            // 
            this.AvgRatingAddTxt.Location = new System.Drawing.Point(1163, 78);
            this.AvgRatingAddTxt.Name = "AvgRatingAddTxt";
            this.AvgRatingAddTxt.Size = new System.Drawing.Size(100, 22);
            this.AvgRatingAddTxt.TabIndex = 10;
            // 
            // InterventionTrackAddTrainerNameTxt
            // 
            this.InterventionTrackAddTrainerNameTxt.Location = new System.Drawing.Point(912, 78);
            this.InterventionTrackAddTrainerNameTxt.Name = "InterventionTrackAddTrainerNameTxt";
            this.InterventionTrackAddTrainerNameTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddTrainerNameTxt.TabIndex = 9;
            // 
            // InterventionTrackAddCourseHoursTxt
            // 
            this.InterventionTrackAddCourseHoursTxt.Location = new System.Drawing.Point(648, 78);
            this.InterventionTrackAddCourseHoursTxt.Name = "InterventionTrackAddCourseHoursTxt";
            this.InterventionTrackAddCourseHoursTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddCourseHoursTxt.TabIndex = 8;
            // 
            // InterventionTrackAddCourseDateToTxt
            // 
            this.InterventionTrackAddCourseDateToTxt.Location = new System.Drawing.Point(382, 78);
            this.InterventionTrackAddCourseDateToTxt.Name = "InterventionTrackAddCourseDateToTxt";
            this.InterventionTrackAddCourseDateToTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddCourseDateToTxt.TabIndex = 7;
            // 
            // InterventionTrackAddCourseDateFromTxt
            // 
            this.InterventionTrackAddCourseDateFromTxt.Location = new System.Drawing.Point(133, 78);
            this.InterventionTrackAddCourseDateFromTxt.Name = "InterventionTrackAddCourseDateFromTxt";
            this.InterventionTrackAddCourseDateFromTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddCourseDateFromTxt.TabIndex = 6;
            // 
            // MonthAddTxt
            // 
            this.MonthAddTxt.Location = new System.Drawing.Point(1163, 28);
            this.MonthAddTxt.Name = "MonthAddTxt";
            this.MonthAddTxt.Size = new System.Drawing.Size(100, 22);
            this.MonthAddTxt.TabIndex = 5;
            // 
            // InterventionTrackAddCourseNameTxt
            // 
            this.InterventionTrackAddCourseNameTxt.Location = new System.Drawing.Point(912, 28);
            this.InterventionTrackAddCourseNameTxt.Name = "InterventionTrackAddCourseNameTxt";
            this.InterventionTrackAddCourseNameTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddCourseNameTxt.TabIndex = 4;
            // 
            // InterventionTrackAddTrainingLocationTxt
            // 
            this.InterventionTrackAddTrainingLocationTxt.Location = new System.Drawing.Point(648, 28);
            this.InterventionTrackAddTrainingLocationTxt.Name = "InterventionTrackAddTrainingLocationTxt";
            this.InterventionTrackAddTrainingLocationTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddTrainingLocationTxt.TabIndex = 3;
            // 
            // InterventionTrackAddCadreTxt
            // 
            this.InterventionTrackAddCadreTxt.Location = new System.Drawing.Point(382, 28);
            this.InterventionTrackAddCadreTxt.Name = "InterventionTrackAddCadreTxt";
            this.InterventionTrackAddCadreTxt.Size = new System.Drawing.Size(100, 22);
            this.InterventionTrackAddCadreTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "People who have Paticipate";
            // 
            // InterventionTrackAddRec2Btn
            // 
            this.InterventionTrackAddRec2Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InterventionTrackAddRec2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterventionTrackAddRec2Btn.Location = new System.Drawing.Point(1119, 465);
            this.InterventionTrackAddRec2Btn.Name = "InterventionTrackAddRec2Btn";
            this.InterventionTrackAddRec2Btn.Size = new System.Drawing.Size(146, 35);
            this.InterventionTrackAddRec2Btn.TabIndex = 22;
            this.InterventionTrackAddRec2Btn.Text = "Add Record";
            this.InterventionTrackAddRec2Btn.UseVisualStyleBackColor = false;
            // 
            // Intervention_Tracker_Add_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 500);
            this.Controls.Add(this.InterventionTrackAddRec2Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InterventionTrackAddGrpBox);
            this.Controls.Add(this.InterventionTrackAddGrdVew);
            this.Name = "Intervention_Tracker_Add_Record";
            this.Text = "Intervention Tracker Add Record";
            ((System.ComponentModel.ISupportInitialize)(this.InterventionTrackAddGrdVew)).EndInit();
            this.InterventionTrackAddGrpBox.ResumeLayout(false);
            this.InterventionTrackAddGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InterventionTrackAddGrdVew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label VenueCostAddTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox InterventionTrackAddInterventionIdTxt;
        private System.Windows.Forms.GroupBox InterventionTrackAddGrpBox;
        private System.Windows.Forms.TextBox InterventionTrackAddNPSTxt;
        private System.Windows.Forms.TextBox AvgRatingAddTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddTrainerNameTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddCourseHoursTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddCourseDateToTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddCourseDateFromTxt;
        private System.Windows.Forms.TextBox MonthAddTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddCourseNameTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddTrainingLocationTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddCadreTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddCostPerPersonTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddTotalTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddAccomodationTxt;
        private System.Windows.Forms.TextBox TrasportationAddTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddTrainerFeesTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddVenueCostTxt;
        private System.Windows.Forms.TextBox InterventionTrackAddNoOfPeopleTxt;
        private System.Windows.Forms.Button InterventionTrackAdd1Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InterventionTrackAddRec2Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classroom_EDP_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Candidate_Location;
        private System.Windows.Forms.Button InterventionTrackClearBtn;

    }
}