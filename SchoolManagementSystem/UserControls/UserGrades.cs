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
    public partial class UserGrades : UserControl
    {
        private static UserGrades _instance;

        public static UserGrades Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserGrades();
                return _instance;
            }
        }
        

        public UserGrades()
        {
            InitializeComponent();

            using(var db = new SchoolEntities())
            {
                var query = db.GetStudentGrades(Client.ID);

                dataGridViewGrades.DataSource = query.ToList();
            }
        }

        private void UserGrades_Resize(object sender, EventArgs e)
        {
            LabelGrades.Location = new Point((int)(Client.Instance.Width / 3.35), (int)(Client.Instance.Height / 4.25));
            dataGridViewGrades.Location = new Point((int)(Client.Instance.Width / 3.35), (int)(Client.Instance.Height / 3.5));
        }

    }
}
