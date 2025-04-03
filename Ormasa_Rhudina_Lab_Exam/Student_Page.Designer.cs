namespace Ormasa_Rhudina_Lab_Exam
{
    partial class Student_Page
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.Panel StudentsPanel;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.StudentsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(734, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STUDENT RECORDS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // StudentsPanel
            this.StudentsPanel.AutoScroll = true;
            this.StudentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.StudentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsPanel.Location = new System.Drawing.Point(0, 60);
            this.StudentsPanel.Name = "StudentsPanel";
            this.StudentsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.StudentsPanel.Size = new System.Drawing.Size(734, 451);
            this.StudentsPanel.TabIndex = 1;

            // Student_Page
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.StudentsPanel);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Student_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Records Management System";
            this.ResumeLayout(false);
        }
    }
}