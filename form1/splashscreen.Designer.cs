namespace splashscreen
{
    partial class splashscreen
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
            this.loader = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // loader
            // 
            this.loader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loader.Location = new System.Drawing.Point(0, 315);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(570, 16);
            this.loader.TabIndex = 0;
            // 
            // splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::splashscreen.Properties.Resources._398px_Godrej_Logo_svg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(570, 331);
            this.Controls.Add(this.loader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.TopMost = true;
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar loader;
    }
}