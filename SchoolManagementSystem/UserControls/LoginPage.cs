using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using SchoolManagementSystem.Models;
using Microsoft.Build.BuildEngine;

namespace SchoolManagementSystem
{
    public partial class LoginPage : UserControl
    {
        // Singleton pattern

        private static LoginPage _instance;

        public static LoginPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginPage();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }


        public LoginPage()
        {
            InitializeComponent();
            Client.Instance.AcceptButton = BtnLogin;
        }

        private void ResetTextboxes()
        {
            TxtUsername.ResetText();
            TxtPassword.ResetText();
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("You haven't entered your username and password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                using (var db = new SchoolEntities())
                {

                    Int32 ID;
                    Int32.TryParse(TxtUsername.Text.Trim(), out ID);
                    Client.ID = ID;
                    
                    var queryStudent = from o in db.Person
                                       where o.PersonID.Equals(ID) && o.Password.Equals(TxtPassword.Text) && o.Discriminator.Equals("Student")
                                       select o;

                    var queryInstructor = from o in db.Person
                                          where o.PersonID.Equals(ID) && o.Password.Equals(TxtPassword.Text) && o.Discriminator.Equals("Instructor")
                                          select o;

                    var queryAdmin = from o in db.Person
                                     where o.PersonID.Equals(ID) && o.Password.Equals(TxtPassword.Text) && o.Discriminator.Equals("Administrator")
                                     select o;

                    if (queryStudent.SingleOrDefault() != null)
                    {
                        ResetTextboxes();
                        Client.Instance.EnableUserPanel();
                    }
                    else if (queryInstructor.SingleOrDefault() != null)
                    {
                        ResetTextboxes();
                        Client.Instance.EnableTeacherPanel();
                    }
                    else if (queryAdmin.SingleOrDefault() != null)
                    {
                        ResetTextboxes();
                        Client.Instance.EnableAdminPanel();
                    }
                    else
                    {
                        MessageBox.Show("Your credentials are incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void LoginPage_Resize(object sender, EventArgs e)
        {
            // Responsive login :) 

            PictureLogo.Location = new Point((LoginPage.Instance.Width / 2)-120, (LoginPage.Instance.Height / 2)-250);
            
            LabelUsername.Location = new Point((LoginPage.Instance.Width / 2)-125, (LoginPage.Instance.Height / 2)+52);
            TxtUsername.Location = new Point((LoginPage.Instance.Width / 2)-10, (LoginPage.Instance.Height / 2)+50);

            LabelPassword.Location = new Point((LoginPage.Instance.Width / 2) - 125, (LoginPage.Instance.Height / 2) + 86);
            TxtPassword.Location = new Point((LoginPage.Instance.Width / 2) - 10, (LoginPage.Instance.Height / 2) + 84);

            BtnLogin.Location = new Point((LoginPage.Instance.Width / 2) - 119, (LoginPage.Instance.Height / 2)+135);
        }

        private void LoginPage_Enter(object sender, EventArgs e)
        {
            Client.Instance.AcceptButton = BtnLogin;
        }
    }
}
