using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Models
{
    public partial class UserCourses : UserControl
    {
        private static UserCourses _instance;
        public static UserCourses Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserCourses();
                return _instance;
            }
        }


        public UserCourses()
        {
            InitializeComponent();

            using(var db = new SchoolEntities())
            {
                var query = from o in db.OnsiteCourse
                            select o;


                dataGridViewCourses.DataSource = query.ToList();
            }
        }

        private void UserCourses_Resize(object sender, EventArgs e)
        {
            LabelCourses.Location = new Point((int)(Client.Instance.Width / 5), (int)(Client.Instance.Height / 5));
            dataGridViewCourses.Location = new Point((int)(Client.Instance.Width / 5), (int)(Client.Instance.Height / 3.5));
        }
    }
}
