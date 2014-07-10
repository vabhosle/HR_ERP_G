namespace form1
{
    partial class mp_trck_tdd_frm
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
            this.mp_add_dgv = new System.Windows.Forms.DataGridView();
            this.ManpowerAdd_EDP_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_ReptMngr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManpowerAdd_DOJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mp_addRec_add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mp_add_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mp_add_dgv
            // 
            this.mp_add_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mp_add_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mp_add_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManpowerAdd_EDP_No,
            this.ManpowerAdd_Name,
            this.ManpowerAdd_Grade,
            this.ManpowerAdd_Function,
            this.ManpowerAdd_ReptMngr,
            this.ManpowerAdd_Location,
            this.ManpowerAdd_DOJ});
            this.mp_add_dgv.Location = new System.Drawing.Point(0, 0);
            this.mp_add_dgv.Name = "mp_add_dgv";
            this.mp_add_dgv.Size = new System.Drawing.Size(932, 464);
            this.mp_add_dgv.TabIndex = 2;
            this.mp_add_dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.mp_add_dgv_EditingControlShowing);
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
            // mp_addRec_add_btn
            // 
            this.mp_addRec_add_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mp_addRec_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp_addRec_add_btn.Location = new System.Drawing.Point(826, 464);
            this.mp_addRec_add_btn.Name = "mp_addRec_add_btn";
            this.mp_addRec_add_btn.Size = new System.Drawing.Size(106, 36);
            this.mp_addRec_add_btn.TabIndex = 3;
            this.mp_addRec_add_btn.Text = "Add Record";
            this.mp_addRec_add_btn.UseVisualStyleBackColor = false;
            // 
            // mp_trck_tdd_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 501);
            this.Controls.Add(this.mp_addRec_add_btn);
            this.Controls.Add(this.mp_add_dgv);
            this.Name = "mp_trck_tdd_frm";
            this.Text = "Manpower Tracker Add Record";
            this.Load += new System.EventHandler(this.Manpower_Tracker_Add_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mp_add_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mp_add_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_EDP_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_ReptMngr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManpowerAdd_DOJ;
        private System.Windows.Forms.Button mp_addRec_add_btn;
    }
}