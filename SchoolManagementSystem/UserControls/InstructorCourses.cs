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
    public partial class InstructorCourses : UserControl
    {
        private static InstructorCourses _instance;
        public static InstructorCourses Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InstructorCourses();
                return _instance;
            }
        }


        public InstructorCourses()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new SchoolEntities())

            if (!string.IsNullOrEmpty(TxtSearch.Text))
            {
                    var query = from o in db.Course
                                where o.Title.Equals(TxtSearch.Text) || o.CourseID.ToString().Equals(TxtSearch.Text) || o.Credits.ToString().Equals(TxtSearch.Text) || o.DepartmentID.ToString().Equals(TxtSearch.Text)
                                select o;

                    if(query.Any())
                    {
                        DataGridViewCourses.DataSource = query.ToList();
                    }
            }
            else
            {
                    DataGridViewCourses.DataSource = db.Course.ToList();
            }
        }

        private void InstructorCourses_Load(object sender, EventArgs e)
        {
            DataGridViewCourses.DataSource = new SchoolEntities().Course.ToList();
        }
    }
}
