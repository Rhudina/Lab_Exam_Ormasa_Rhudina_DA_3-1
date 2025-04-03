using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Ormasa_Rhudina_Lab_Exam
{
    public partial class Student_Page : Form
    {
        private string connectionString = "server=localhost;user=root;database=studentinfodb;password=;";

        public Student_Page()
        {
            InitializeComponent();
            ApplyModernTheme();
            LoadStudents();
        }

        private void ApplyModernTheme()
        {
            
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9);
            this.Text = "List of Students";
            this.StartPosition = FormStartPosition.CenterScreen;

          
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 120, 215);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 60;
            lblTitle.BackColor = Color.White;

         
            StudentsPanel.BackColor = Color.FromArgb(240, 240, 240);
            StudentsPanel.Padding = new Padding(10);
        }

        private void LoadStudents()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT studentId, CONCAT(firstName, ' ', lastName) AS fullName FROM StudentRecordTB";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    StudentsPanel.Controls.Clear();

                    int topPosition = 15;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        
                        var studentPanel = new Panel
                        {
                            Width = StudentsPanel.Width - 40,
                            Height = 60,
                            Top = topPosition,
                            Left = 10,
                            BackColor = Color.White,
                            BorderStyle = BorderStyle.None,
                            Cursor = Cursors.Hand,
                            Margin = new Padding(0, 0, 0, 15)
                        };

                        
                        studentPanel.Paint += (sender, e) => {
                            ControlPaint.DrawBorder(e.Graphics, studentPanel.ClientRectangle,
                                Color.FromArgb(220, 220, 220), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(220, 220, 220), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(220, 220, 220), 1, ButtonBorderStyle.Solid,
                                Color.FromArgb(220, 220, 220), 1, ButtonBorderStyle.Solid);
                            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(240, 240, 240)),
                                new Rectangle(0, 0, studentPanel.Width - 1, studentPanel.Height - 1));
                        };

                        
                        var lblInfo = new Label
                        {
                            Text = $"ID: {row["studentId"]} - {row["fullName"]}",
                            Font = new Font("Segoe UI", 11, FontStyle.Regular),
                            ForeColor = Color.FromArgb(64, 64, 64),
                            AutoSize = true,
                            Top = 20,
                            Left = 20
                        };

                        
                        var btnView = new Button
                        {
                            Text = "VIEW DETAILS",
                            Tag = row["studentId"],
                            Top = 15,
                            Left = studentPanel.Width - 160,
                            Width = 140,
                            Height = 30,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.FromArgb(0, 120, 215),
                            ForeColor = Color.White,
                            Cursor = Cursors.Hand,
                            Font = new Font("Segoe UI", 9, FontStyle.Bold)
                        };
                        btnView.FlatAppearance.BorderSize = 0;
                        btnView.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 90, 180);

                        btnView.Click += (sender, e) => {
                            var individualForm = new StudentPage_Individual(Convert.ToInt32(btnView.Tag));
                            individualForm.Show();
                        };

                        studentPanel.Controls.Add(lblInfo);
                        studentPanel.Controls.Add(btnView);
                        StudentsPanel.Controls.Add(studentPanel);

                        topPosition += 75;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}