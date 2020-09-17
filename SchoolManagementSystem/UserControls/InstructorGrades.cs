using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.UserControls
{
    public partial class InstructorGrades : UserControl
    {
        private static InstructorGrades _instance;

        public static InstructorGrades Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InstructorGrades();
                return _instance;
            }
        }

        public InstructorGrades()
        {
            InitializeComponent();
        }

        private void InstructorGrades_Load(object sender, EventArgs e)
        {
            Client.Instance.AcceptButton = BtnAddGrade;

            DataGridViewGrades.DataSource = new SchoolEntities().StudentGrade.ToList();

            using (var db = new SchoolEntities())
            {
                var studentNames = from o in db.Person
                            where o.Discriminator.Equals("Student")
                            select o.FirstName + " " + o.LastName;

                ComboBoxStudents.Items.AddRange(studentNames.ToArray());

                var courses = from o in db.Course
                              select o.Title;

                ComboBoxCourse.Items.AddRange(courses.ToArray());
            }

        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            if (ComboBoxCourse.Text != null && ComboBoxGrades.Text != null && ComboBoxStudents.Text != null)
            {
                using (var db = new SchoolEntities())
                {

                    var getCourse = from o in db.Course
                                    where o.Title.Equals(ComboBoxCourse.Text)
                                    select o.CourseID;
                    
                    int courseID = default;

                    if (getCourse.Any())
                    {
                        courseID = getCourse.First();
                    }

                    var getStudent = from o in db.Person
                                     where (o.FirstName + " " + o.LastName).Equals(ComboBoxStudents.Text)
                                     select o.PersonID;

                    int studentID = default;

                    if(getStudent.Any())
                    {
                        studentID = getStudent.First();
                    }

                    decimal.TryParse(ComboBoxGrades.Text, out decimal studentGrade);


                    var grade = new StudentGrade()
                    {
                        CourseID = courseID,
                        StudentID = studentID,
                        Grade = studentGrade
                    };

                    
                    db.StudentGrade.Add(grade);

                    db.SaveChanges();

                    DataGridViewGrades.DataSource = db.StudentGrade.ToList();

                    ComboBoxCourse.SelectedItem = null;
                    ComboBoxGrades.SelectedItem = null;
                    ComboBoxStudents.SelectedItem = null;

                    DataGridViewGrades.Rows[DataGridViewGrades.Rows.Count - 1].Selected = true;
                    DataGridViewGrades.FirstDisplayedCell = DataGridViewGrades.Rows[DataGridViewGrades.Rows.Count - 1].Cells[0];
                }
            }
            else
            {
                MessageBox.Show("Please provide all required information.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridViewGrades_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                if(MessageBox.Show("Do you really want to delete this row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var selectedRow = DataGridViewGrades.SelectedRows[0].Cells[0].Value.ToString();

                    using (var db = new SchoolEntities())
                    {
                        var query = from o in db.StudentGrade
                                    where o.EnrollmentID.ToString().Equals(selectedRow)
                                    select o;

                        db.StudentGrade.Remove(query.First());

                        db.SaveChanges();

                        DataGridViewGrades.DataSource = db.StudentGrade.ToList();

                        DataGridViewGrades.FirstDisplayedCell = DataGridViewGrades.Rows[DataGridViewGrades.Rows.Count - 1].Cells[0];
                    }
                }
            }
        }

        private void InstructorGrades_Leave(object sender, EventArgs e)
        {
            DataGridViewGrades.EndEdit();
            Client.Instance.AcceptButton = null;
        }
    }
}
