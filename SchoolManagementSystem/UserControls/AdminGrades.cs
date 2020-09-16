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
    public partial class AdminGrades : UserControl
    {
        private static AdminGrades _instance;
        public static AdminGrades Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminGrades();
                return _instance;
            }
        }


        public AdminGrades()
        {
            InitializeComponent();
        }

        private void AdminGrades_Load(object sender, EventArgs e)
        {
            dataGridViewGrades.DataSource = new SchoolEntities().StudentGrade.ToList();
        }

        private void dataGridViewGrades_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Do you really want to delete this row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (var db = new SchoolEntities())
                    {

                    var deletedRowId = dataGridViewGrades.SelectedRows[0].Cells[0].Value.ToString();

                        var query = from o in db.StudentGrade
                                    where o.EnrollmentID.ToString().Equals(deletedRowId)
                                    select o;

                        if (query.Any())
                        {
                            db.StudentGrade.Remove(query.First());

                            db.SaveChanges();

                            dataGridViewGrades.DataSource = db.StudentGrade.ToList();
                        }
                    }
                }
            }
        }

        private void AdminGrades_Leave(object sender, EventArgs e)
        {
            dataGridViewGrades.EndEdit();
            Client.Instance.AcceptButton = null;
        }
    }
}
