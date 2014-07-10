namespace form1
{
    partial class Classroom_Outbounds_Add_Record
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
            this.ClassOut_GrdVewAddRec = new System.Windows.Forms.DataGridView();
            this.Classroom_EDP_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Cadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Candidate_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Training_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classs_Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_From_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_To_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Trainer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Avg_Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassOut_btAddRec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClassOut_GrdVewAddRec)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassOut_GrdVewAddRec
            // 
            this.ClassOut_GrdVewAddRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassOut_GrdVewAddRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classroom_EDP_No,
            this.Class_Name,
            this.Class_Cadre,
            this.Class_Grade,
            this.Class_Function,
            this.Class_Candidate_Location,
            this.Class_Training_Location,
            this.Classs_Course_Name,
            this.Class_Month,
            this.Class_From_Date,
            this.Class_To_Date,
            this.Class_Hours,
            this.Class_Trainer_Name,
            this.Class_Avg_Rating});
            this.ClassOut_GrdVewAddRec.Location = new System.Drawing.Point(12, 2);
            this.ClassOut_GrdVewAddRec.Name = "ClassOut_GrdVewAddRec";
            this.ClassOut_GrdVewAddRec.Size = new System.Drawing.Size(1253, 461);
            this.ClassOut_GrdVewAddRec.TabIndex = 0;
            this.ClassOut_GrdVewAddRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassOut_GrdVewAddRec_CellContentClick);
            this.ClassOut_GrdVewAddRec.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ClassOut_GrdVewAddRec_CellValidating);
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
            this.Class_Name.Width = 150;
            // 
            // Class_Cadre
            // 
            this.Class_Cadre.HeaderText = "Cadre";
            this.Class_Cadre.Name = "Class_Cadre";
            this.Class_Cadre.Width = 86;
            // 
            // Class_Grade
            // 
            this.Class_Grade.HeaderText = "Grade";
            this.Class_Grade.Name = "Class_Grade";
            this.Class_Grade.Width = 87;
            // 
            // Class_Function
            // 
            this.Class_Function.HeaderText = "Function";
            this.Class_Function.Name = "Class_Function";
            this.Class_Function.Width = 86;
            // 
            // Class_Candidate_Location
            // 
            this.Class_Candidate_Location.HeaderText = "Candidate Location";
            this.Class_Candidate_Location.Name = "Class_Candidate_Location";
            this.Class_Candidate_Location.Width = 87;
            // 
            // Class_Training_Location
            // 
            this.Class_Training_Location.HeaderText = "Training Location";
            this.Class_Training_Location.Name = "Class_Training_Location";
            this.Class_Training_Location.Width = 86;
            // 
            // Classs_Course_Name
            // 
            this.Classs_Course_Name.HeaderText = "Course Name";
            this.Classs_Course_Name.Name = "Classs_Course_Name";
            this.Classs_Course_Name.Width = 86;
            // 
            // Class_Month
            // 
            this.Class_Month.HeaderText = "Month";
            this.Class_Month.Name = "Class_Month";
            this.Class_Month.Width = 87;
            // 
            // Class_From_Date
            // 
            this.Class_From_Date.HeaderText = "From Date";
            this.Class_From_Date.Name = "Class_From_Date";
            this.Class_From_Date.Width = 86;
            // 
            // Class_To_Date
            // 
            this.Class_To_Date.HeaderText = "To Date";
            this.Class_To_Date.Name = "Class_To_Date";
            this.Class_To_Date.Width = 87;
            // 
            // Class_Hours
            // 
            this.Class_Hours.HeaderText = "Hours";
            this.Class_Hours.Name = "Class_Hours";
            this.Class_Hours.Width = 40;
            // 
            // Class_Trainer_Name
            // 
            this.Class_Trainer_Name.HeaderText = "Trainer\'s Name";
            this.Class_Trainer_Name.Name = "Class_Trainer_Name";
            this.Class_Trainer_Name.Width = 120;
            // 
            // Class_Avg_Rating
            // 
            this.Class_Avg_Rating.HeaderText = "Avg Rating";
            this.Class_Avg_Rating.Name = "Class_Avg_Rating";
            this.Class_Avg_Rating.Width = 40;
            // 
            // ClassOut_btAddRec
            // 
            this.ClassOut_btAddRec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClassOut_btAddRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassOut_btAddRec.Location = new System.Drawing.Point(1109, 463);
            this.ClassOut_btAddRec.Name = "ClassOut_btAddRec";
            this.ClassOut_btAddRec.Size = new System.Drawing.Size(156, 36);
            this.ClassOut_btAddRec.TabIndex = 1;
            this.ClassOut_btAddRec.Text = "Add Record";
            this.ClassOut_btAddRec.UseVisualStyleBackColor = false;
            // 
            // Classroom_Outbounds_Add_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 498);
            this.Controls.Add(this.ClassOut_btAddRec);
            this.Controls.Add(this.ClassOut_GrdVewAddRec);
            this.Name = "Classroom_Outbounds_Add_Record";
            this.Text = "Classroom_Outbounds_Add_Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Classroom_Outbounds_Add_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassOut_GrdVewAddRec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassOut_GrdVewAddRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classroom_EDP_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Cadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Candidate_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Training_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classs_Course_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_From_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_To_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Trainer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Avg_Rating;
        private System.Windows.Forms.Button ClassOut_btAddRec;

    }
}