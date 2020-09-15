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
    public partial class AdminDepartments : UserControl
    {
        private static AdminDepartments _instance;
        public static AdminDepartments Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminDepartments();
                return _instance;
            }
        }


        public AdminDepartments()
        {
            InitializeComponent();
        }

        private void AdminDepartments_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolEntities())
            {
                var instructorsList = from o in db.Person
                                      where o.Discriminator.Equals("Instructor")
                                      select o.FirstName + " " + o.LastName;

                comboBoxInstructors.Items.AddRange(instructorsList.ToArray());

                dataGridViewDepartments.DataSource = db.Department.ToList();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtName.Text) && !string.IsNullOrEmpty(TxtBudget.Text) && !string.IsNullOrEmpty(TxtName.Text) && comboBoxInstructors.Text != null)
            {
                using(var db = new SchoolEntities())
                {
                    // parsing budget if correct
                    decimal budget = default;
                    decimal.TryParse(TxtBudget.Text, out budget);

                    if(budget.ToString() == "0")
                    {
                        MessageBox.Show("Invalid budget value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // parsing deptid if correct
                    int deptID = default;
                    int.TryParse(TxtId.Text, out deptID);

                    if(deptID.ToString() == "0")
                    {
                        MessageBox.Show("Invalid department ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    // getting dept admin id from name + surname
                    var findAdmin = from o in db.Person
                                    where (o.FirstName + " " + o.LastName).Equals(comboBoxInstructors.Text)
                                    select o.PersonID;
                    

                    var dept = new Department()
                    {
                        Name = TxtName.Text,
                        Budget = budget,
                        DepartmentID = deptID,
                        StartDate = dateTimeStart.Value,
                        Administrator = findAdmin.First()
                    };

                    TxtId.ResetText();
                    TxtBudget.ResetText();
                    TxtName.ResetText();
                    dateTimeStart.ResetText();
                    comboBoxInstructors.SelectedItem = null;

                    db.Department.Add(dept);

                    db.SaveChanges();
                    dataGridViewDepartments.DataSource = db.Department.ToList();
                }
            }
            else
            {
                MessageBox.Show("Please enter missing information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.TextLength > 0)
            {
                using (var db = new SchoolEntities())
                {
                    var query = from o in db.Department
                                where o.DepartmentID.ToString().Equals(TxtSearch.Text) || o.Budget.ToString().Contains(TxtSearch.Text) || o.Administrator.ToString().Equals(TxtSearch.Text) || o.Name.Equals(TxtSearch.Text)
                                select o;

                    dataGridViewDepartments.DataSource = query.ToList();
                }

            }
            else
            {
                dataGridViewDepartments.DataSource = new SchoolEntities().Department.ToList();
            }
        }

        private void dataGridViewDepartments_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                if(MessageBox.Show("Do you really want to delete selected row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new SchoolEntities())
                    {
                        // has to be inside variable cuz linq cant resolve something like that
                        var val = dataGridViewDepartments.SelectedRows[0].Cells[0].Value.ToString();

                        var query = from o in db.Department
                                    where o.DepartmentID.ToString().Equals(val)
                                    select o;

                        db.Department.Remove(query.Single());

                        db.SaveChanges();

                        dataGridViewDepartments.DataSource = db.Department.ToList();
                    }
                }
            }
        }

        private void AdminDepartments_Enter(object sender, EventArgs e)
        {
            Client.Instance.AcceptButton = BtnAdd;
        }

        private void AdminDepartments_Leave(object sender, EventArgs e)
        {
            dataGridViewDepartments.EndEdit();
            Client.Instance.AcceptButton = null;
        }
    }
}
