namespace Ormasa_Rhudina_Lab_Exam
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;

        // Section Headers
        private Label lblPersonalInfoHeader;
        private Label lblContactInfoHeader;
        private Label lblAddressInfoHeader;
        private Label lblGuardianInfoHeader;
        private Label lblAcademicInfoHeader;

        // Personal Information
        private Label lblStudentId;
        private Label lblStudentIdValue;
        private Label lblFirstName;
        private Label lblFirstNameValue;
        private Label lblMiddleName;
        private Label lblMiddleNameValue;
        private Label lblLastName;
        private Label lblLastNameValue;
        private Label lblNickname;
        private Label lblNicknameValue;
        private Label lblBirthdate;
        private Label lblBirthdateValue;
        private Label lblAge;
        private Label lblAgeValue;

        // Contact Information
        private Label lblContact;
        private Label lblContactValue;
        private Label lblEmail;
        private Label lblEmailValue;
        private Label lblHobbies;
        private Label lblHobbiesValue;

        // Address Information
        private Label lblHouseNo;
        private Label lblHouseNoValue;
        private Label lblBrgy;
        private Label lblBrgyValue;
        private Label lblMunicipality;
        private Label lblMunicipalityValue;
        private Label lblProvince;
        private Label lblProvinceValue;
        private Label lblRegion;
        private Label lblRegionValue;
        private Label lblCountry;
        private Label lblCountryValue;

        // Guardian Information
        private Label lblGuardianFirstName;
        private Label lblGuardianFirstNameValue;
        private Label lblGuardianLastName;
        private Label lblGuardianLastNameValue;

        // Academic Information
        private Label lblCourse;
        private Label lblCourseValue;
        private Label lblYearLevel;
        private Label lblYearLevelValue;

        // Close Button
        private Button btnClose;

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
            // Form styling
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentPage_Individual";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";

            // ========== SECTION HEADERS ==========
            // Personal Information Header
            this.lblPersonalInfoHeader = new Label();
            this.lblPersonalInfoHeader.AutoSize = true;
            this.lblPersonalInfoHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblPersonalInfoHeader.ForeColor = Color.FromArgb(0, 114, 198);
            this.lblPersonalInfoHeader.Location = new Point(20, 20);
            this.lblPersonalInfoHeader.Name = "lblPersonalInfoHeader";
            this.lblPersonalInfoHeader.Size = new Size(148, 21);
            this.lblPersonalInfoHeader.TabIndex = 0;
            this.lblPersonalInfoHeader.Text = "Personal Information";
            this.Controls.Add(this.lblPersonalInfoHeader);

            // Contact Information Header
            this.lblContactInfoHeader = new Label();
            this.lblContactInfoHeader.AutoSize = true;
            this.lblContactInfoHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblContactInfoHeader.ForeColor = Color.FromArgb(0, 114, 198);
            this.lblContactInfoHeader.Location = new Point(350, 20);
            this.lblContactInfoHeader.Name = "lblContactInfoHeader";
            this.lblContactInfoHeader.Size = new Size(143, 21);
            this.lblContactInfoHeader.TabIndex = 1;
            this.lblContactInfoHeader.Text = "Contact Information";
            this.Controls.Add(this.lblContactInfoHeader);

            // Address Information Header
            this.lblAddressInfoHeader = new Label();
            this.lblAddressInfoHeader.AutoSize = true;
            this.lblAddressInfoHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblAddressInfoHeader.ForeColor = Color.FromArgb(0, 114, 198);
            this.lblAddressInfoHeader.Location = new Point(20, 250);
            this.lblAddressInfoHeader.Name = "lblAddressInfoHeader";
            this.lblAddressInfoHeader.Size = new Size(141, 21);
            this.lblAddressInfoHeader.TabIndex = 2;
            this.lblAddressInfoHeader.Text = "Address Information";
            this.Controls.Add(this.lblAddressInfoHeader);

            // Guardian Information Header
            this.lblGuardianInfoHeader = new Label();
            this.lblGuardianInfoHeader.AutoSize = true;
            this.lblGuardianInfoHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblGuardianInfoHeader.ForeColor = Color.FromArgb(0, 114, 198);
            this.lblGuardianInfoHeader.Location = new Point(350, 250);
            this.lblGuardianInfoHeader.Name = "lblGuardianInfoHeader";
            this.lblGuardianInfoHeader.Size = new Size(150, 21);
            this.lblGuardianInfoHeader.TabIndex = 3;
            this.lblGuardianInfoHeader.Text = "Guardian Information";
            this.Controls.Add(this.lblGuardianInfoHeader);

            // Academic Information Header
            this.lblAcademicInfoHeader = new Label();
            this.lblAcademicInfoHeader.AutoSize = true;
            this.lblAcademicInfoHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblAcademicInfoHeader.ForeColor = Color.FromArgb(0, 114, 198);
            this.lblAcademicInfoHeader.Location = new Point(20, 450);
            this.lblAcademicInfoHeader.Name = "lblAcademicInfoHeader";
            this.lblAcademicInfoHeader.Size = new Size(150, 21);
            this.lblAcademicInfoHeader.TabIndex = 4;
            this.lblAcademicInfoHeader.Text = "Academic Information";
            this.Controls.Add(this.lblAcademicInfoHeader);

            // ========== PERSONAL INFORMATION ==========
            // Student ID
            this.lblStudentId = CreateLabel("Student ID:", 20, 50);
            this.lblStudentIdValue = CreateValueLabel("", 150, 50);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblStudentIdValue);

            // First Name
            this.lblFirstName = CreateLabel("First Name:", 20, 80);
            this.lblFirstNameValue = CreateValueLabel("", 150, 80);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblFirstNameValue);

            // Middle Name
            this.lblMiddleName = CreateLabel("Middle Name:", 20, 110);
            this.lblMiddleNameValue = CreateValueLabel("", 150, 110);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblMiddleNameValue);

            // Last Name
            this.lblLastName = CreateLabel("Last Name:", 20, 140);
            this.lblLastNameValue = CreateValueLabel("", 150, 140);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLastNameValue);

            // Nickname
            this.lblNickname = CreateLabel("Nickname:", 20, 170);
            this.lblNicknameValue = CreateValueLabel("", 150, 170);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.lblNicknameValue);

            // Birthdate
            this.lblBirthdate = CreateLabel("Birthdate:", 20, 200);
            this.lblBirthdateValue = CreateValueLabel("", 150, 200);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblBirthdateValue);

            // Age
            this.lblAge = CreateLabel("Age:", 20, 230);
            this.lblAgeValue = CreateValueLabel("", 150, 230);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAgeValue);

            // ========== CONTACT INFORMATION ==========
            // Contact
            this.lblContact = CreateLabel("Contact:", 350, 50);
            this.lblContactValue = CreateValueLabel("", 480, 50);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblContactValue);

            // Email
            this.lblEmail = CreateLabel("Email:", 350, 80);
            this.lblEmailValue = CreateValueLabel("", 480, 80);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmailValue);

            // Hobbies
            this.lblHobbies = CreateLabel("Hobbies:", 350, 110);
            this.lblHobbiesValue = CreateValueLabel("", 480, 110, 200, true);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblHobbiesValue);

            // ========== ADDRESS INFORMATION ==========
            // House No
            this.lblHouseNo = CreateLabel("House No:", 20, 280);
            this.lblHouseNoValue = CreateValueLabel("", 150, 280);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblHouseNoValue);

            // Barangay
            this.lblBrgy = CreateLabel("Barangay:", 20, 310);
            this.lblBrgyValue = CreateValueLabel("", 150, 310);
            this.Controls.Add(this.lblBrgy);
            this.Controls.Add(this.lblBrgyValue);

            // Municipality
            this.lblMunicipality = CreateLabel("Municipality:", 20, 340);
            this.lblMunicipalityValue = CreateValueLabel("", 150, 340);
            this.Controls.Add(this.lblMunicipality);
            this.Controls.Add(this.lblMunicipalityValue);

            // Province
            this.lblProvince = CreateLabel("Province:", 20, 370);
            this.lblProvinceValue = CreateValueLabel("", 150, 370);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblProvinceValue);

            // Region
            this.lblRegion = CreateLabel("Region:", 20, 400);
            this.lblRegionValue = CreateValueLabel("", 150, 400);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblRegionValue);

            // Country
            this.lblCountry = CreateLabel("Country:", 20, 430);
            this.lblCountryValue = CreateValueLabel("", 150, 430);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCountryValue);

            // ========== GUARDIAN INFORMATION ==========
            // Guardian First Name
            this.lblGuardianFirstName = CreateLabel("First Name:", 350, 280);
            this.lblGuardianFirstNameValue = CreateValueLabel("", 480, 280);
            this.Controls.Add(this.lblGuardianFirstName);
            this.Controls.Add(this.lblGuardianFirstNameValue);

            // Guardian Last Name
            this.lblGuardianLastName = CreateLabel("Last Name:", 350, 310);
            this.lblGuardianLastNameValue = CreateValueLabel("", 480, 310);
            this.Controls.Add(this.lblGuardianLastName);
            this.Controls.Add(this.lblGuardianLastNameValue);

            // ========== ACADEMIC INFORMATION ==========
            // Course
            this.lblCourse = CreateLabel("Course:", 20, 480);
            this.lblCourseValue = CreateValueLabel("", 150, 480);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblCourseValue);

            // Year Level
            this.lblYearLevel = CreateLabel("Year Level:", 20, 510);
            this.lblYearLevelValue = CreateValueLabel("", 150, 510);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.lblYearLevelValue);

            // ========== CLOSE BUTTON ==========
            this.btnClose = new Button();
            this.btnClose.Location = new Point(550, 550);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(100, 30);
            this.btnClose.TabIndex = 100;
            this.btnClose.Text = "Close";
            this.btnClose.BackColor = Color.FromArgb(0, 114, 198);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label CreateLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label.Location = new Point(x, y);
            label.Name = "lbl" + text.Replace(" ", "").Replace(":", "");
            label.Size = new Size(100, 15);
            label.TabIndex = 0;
            label.Text = text;
            return label;
        }

        private Label CreateValueLabel(string text, int x, int y, int width = 200, bool multiLine = false)
        {
            Label label = new Label();
            label.AutoSize = !multiLine;
            if (!multiLine)
            {
                label.Location = new Point(x, y);
                label.Size = new Size(width, 15);
            }
            else
            {
                label.Location = new Point(x, y);
                label.Size = new Size(width, 60);
                label.MaximumSize = new Size(width, 0);
            }
            label.Name = "lbl" + text.Replace(" ", "").Replace(":", "") + "Value";
            label.TabIndex = 0;
            label.Text = text;
            return label;
        }
    }
}