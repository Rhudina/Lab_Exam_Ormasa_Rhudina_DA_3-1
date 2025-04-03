using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ormasa_Rhudina_Lab_Exam
{
    public partial class StudentPage_Individual : Form
    {
        private string connectionString = "server=localhost;user=root;database=studentinfodb;password=;";
        private int studentId;

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
            ApplyModernStyling();
        }

        private void LoadStudentDetails()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT sr.*, c.courseName, y.yearLvl 
                                  FROM StudentRecordTB sr
                                  JOIN CourseTB c ON sr.courseId = c.courseId
                                  JOIN YearTB y ON sr.yearId = y.yearId
                                  WHERE sr.studentId = @studentId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@studentId", studentId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Personal Information
                            lblStudentIdValue.Text = reader["studentId"].ToString();
                            lblFirstNameValue.Text = reader["firstName"].ToString();
                            lblMiddleNameValue.Text = reader["middleName"]?.ToString() ?? "N/A";
                            lblLastNameValue.Text = reader["lastName"].ToString();
                            lblNicknameValue.Text = reader["nickname"]?.ToString() ?? "N/A";
                            lblBirthdateValue.Text = Convert.ToDateTime(reader["birthdate"]).ToString("yyyy-MM-dd");
                            lblAgeValue.Text = reader["age"].ToString();

                            // Contact Information
                            lblContactValue.Text = reader["studContactNo"]?.ToString() ?? "N/A";
                            lblEmailValue.Text = reader["emailAddress"]?.ToString() ?? "N/A";

                            // Fix for hobbies display
                            string hobbies = reader["hobbies"]?.ToString() ?? "N/A";
                            lblHobbiesValue.Text = hobbies;
                            lblHobbiesValue.AutoSize = false;
                            lblHobbiesValue.Size = new Size(200, CalculateTextHeight(hobbies, lblHobbiesValue.Font, 200));

                            // Address Information
                            lblHouseNoValue.Text = reader["houseNo"].ToString();
                            lblBrgyValue.Text = reader["brgyName"].ToString();
                            lblMunicipalityValue.Text = reader["municipality"].ToString();
                            lblProvinceValue.Text = reader["province"].ToString();
                            lblRegionValue.Text = reader["region"].ToString();
                            lblCountryValue.Text = reader["country"].ToString();

                            // Guardian Information
                            lblGuardianFirstNameValue.Text = reader["guardianFirstName"].ToString();
                            lblGuardianLastNameValue.Text = reader["guardianLastName"].ToString();

                            // Academic Information
                            lblCourseValue.Text = reader["courseName"].ToString();
                            lblYearLevelValue.Text = reader["yearLvl"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Student record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private int CalculateTextHeight(string text, Font font, int width)
        {
            if (string.IsNullOrEmpty(text)) return 20;

            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(text, font, width);
                return (int)Math.Ceiling(size.Height) + 10; 
            }
        }

        private void ApplyModernStyling()
        {
            
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9);
            this.Padding = new Padding(10);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}