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
using System.Security.Policy;

namespace SchoolManagementSystem.UserControls
{
    public partial class AdminUsers : UserControl
    {
        private static AdminUsers _instance;
        public static AdminUsers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminUsers();
                return _instance;
            }
        }


        public AdminUsers()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new SchoolEntities().Person.ToList();
            Client.Instance.AcceptButton = BtnAddUser;
        }

        private void AdminUsers_Resize(object sender, EventArgs e)
        {

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtFirstName.Text) && !string.IsNullOrEmpty(TxtLastName.Text) && !string.IsNullOrEmpty(TxtPassword.Text) && (dateEnrollmentDate.Checked || dateHireDate.Checked) && comboBoxDisc.Text != null)
            {
                using(var db = new SchoolEntities())
                {
                    DateTime? dt = null;
                    var hireDate = (dateHireDate.Enabled == true) ? dateHireDate.Value : dt;
                    var enrollDate = (dateEnrollmentDate.Enabled == true) ? dateEnrollmentDate.Value : dt;

                    var person = new Person() { LastName = TxtLastName.Text, FirstName = TxtFirstName.Text, HireDate = hireDate, EnrollmentDate = enrollDate, Discriminator = comboBoxDisc.SelectedItem.ToString(), Password = TxtPassword.Text };

                    db.Person.Add(person);
                    db.SaveChanges();

                    dataGridView1.DataSource = db.Person.ToList();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                    dataGridView1.FirstDisplayedCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
                }

                TxtFirstName.ResetText();
                TxtLastName.ResetText();
                TxtPassword.ResetText();
                dateHireDate.ResetText();
                dateEnrollmentDate.ResetText();
                comboBoxDisc.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("You havent entered every needed information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxDisc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDisc.SelectedItem != null)
            {
                if (comboBoxDisc.SelectedItem.ToString() == "Student")
                {
                    dateEnrollmentDate.Enabled = true;
                    dateHireDate.Enabled = false;
                }
                else
                {
                    dateEnrollmentDate.Enabled = false;
                    dateHireDate.Enabled = true;
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Do you really want to delete selected row?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using(var db = new SchoolEntities())
                    {
                        db.DeletePerson(dataGridView1.Rows.Count);
                        db.SaveChanges();
                        dataGridView1.DataSource = db.Person.ToList();
                    }
                }
            }
        }

        private void AdminUsers_Leave(object sender, EventArgs e)
        {
            personBindingSource.EndEdit();
            dataGridView1.Update();
            Client.Instance.AcceptButton = null;
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtSearch.Text))
            {
                dataGridView1.DataSource = new SchoolEntities().Person.ToList();
            }
            else
            {
                var query = from o in new SchoolEntities().Person
                            where o.FirstName.Equals(TxtSearch.Text) || o.LastName.Equals(TxtLastName.Text) || o.Discriminator.Equals(TxtSearch.Text)
                            select o;

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void AdminUsers_Enter(object sender, EventArgs e)
        {
            Client.Instance.AcceptButton = BtnAddUser;
        }
    }
}
