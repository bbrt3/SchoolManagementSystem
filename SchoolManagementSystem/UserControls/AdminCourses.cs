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
    public partial class AdminCourses : UserControl
    {
        private static AdminCourses _instance;
        public static AdminCourses Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminCourses();
                return _instance;
            }
        }


        public AdminCourses()
        {
            InitializeComponent();
        }

        private void AdminCourses_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolEntities())
            {
                dataGridView1.DataSource = db.Course.ToList();

                var departments = from o in db.Department
                            select o.Name;

                var instructors = from o in db.Person
                                  where o.Discriminator.Equals("Instructor")
                                  select o.FirstName + " " + o.LastName;

                comboBoxDepartments.Items.AddRange(departments.ToArray());
                comboBoxInstructors.Items.AddRange(instructors.ToArray());
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTitle.Text) && !string.IsNullOrEmpty(TxtID.Text) && comboBoxCredits.Text != null && comboBoxDepartments.Text != null && comboBoxInstructors.Text != null)
            {
                using (var db = new SchoolEntities())
                {
                    // converting id text to number

                    Int32 ID;
                    Int32.TryParse(TxtID.Text, out ID);

                    // converting department name to department id

                    var deptID = from o in db.Department
                                 where o.Name.Equals(comboBoxDepartments.SelectedItem.ToString())
                                 select o.DepartmentID;

                    Int32 finalDeptID;
                    Int32.TryParse(deptID.First().ToString(), out finalDeptID);


                    // converting credits from combobox selection to number

                    Int32 credits;
                    Int32.TryParse(comboBoxCredits.SelectedItem.ToString(), out credits);


                    var course = new Course { CourseID = ID, Title = TxtTitle.Text, Credits = credits, DepartmentID = finalDeptID };
                    db.Course.Add(course);

                    // course instructor part
                    // missing from model (?)
                    //var courseInstructor = db.


                    db.SaveChanges();
                    dataGridView1.DataSource = db.Course.ToList();
                }
                TxtID.ResetText();
                TxtTitle.ResetText();
                comboBoxCredits.SelectedItem = null;
                comboBoxDepartments.SelectedItem = null;
                comboBoxInstructors.SelectedItem = null;

            }
        }

        private void AdminCourses_Enter(object sender, EventArgs e)
        {
            Client.Instance.AcceptButton = BtnAdd;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                if(MessageBox.Show("Do you really want to delete selected row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // removing by selecting courseid cell to delete

                    // TODO: adding entry to onsite / online course and fixing courseinstructor table because its gonna crash when deleting base entries

                    int val;
                    int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out val);

                    using (var db = new SchoolEntities())
                    {
                        var query = from o in db.Course
                                    where o.CourseID.Equals(val)
                                    select o;

                        var queryOnline = from o in db.OnlineCourse
                                          where o.CourseID.Equals(val)
                                          select o;

                        var queryOnsite = from o in db.OnsiteCourse
                                          where o.CourseID.Equals(val)
                                          select o;

                        var queryGrades = from o in db.StudentGrade
                                          where o.CourseID.Equals(val)
                                          select o;

                        db.Course.Remove(query.First());
                        
                        if(queryOnline.FirstOrDefault() != null)
                        {
                            db.OnlineCourse.Remove(queryOnline.First());
                        }
                        if(queryOnsite.FirstOrDefault() != null)
                        {
                            db.OnsiteCourse.Remove(queryOnsite.First());
                        }
                        if(queryGrades.FirstOrDefault() != null)
                        {
                            db.StudentGrade.RemoveRange(queryGrades.ToArray());
                        }

                        db.SaveChanges();

                        dataGridView1.DataSource = db.Course.ToList();
                    }

                }
            }
        }

        private void AdminCourses_Leave(object sender, EventArgs e)
        {
            courseBindingSource.EndEdit();
            dataGridView1.Update();
            Client.Instance.AcceptButton = null;
        }
    }
}
