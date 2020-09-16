using Microsoft.Build.BuildEngine;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SchoolManagementSystem
{
    public partial class Client : Form
    {
        private static Client _instance;

        public static Client Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Client();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }

        private static int _ID;

        public static int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public Client()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            if (!PanelContent.Contains(LoginPage.Instance))
            {
                PanelContent.Controls.Add(LoginPage.Instance);

                LoginPage.Instance.Dock = DockStyle.Fill;
            }
        }

        public void EnableAdminPanel()
        {
            LoginPage.Instance.Visible = false;
            PanelSideMenu.Visible = true;
            PanelAdminMain.Visible = true;
        }

        public void EnableTeacherPanel()
        {
            LoginPage.Instance.Visible = false;
            PanelSideMenu.Visible = true;
            PanelTeacherMain.Visible = true;
        }

        public void EnableUserPanel()
        {
            LoginPage.Instance.Visible = false;
            PanelSideMenu.Visible = true;
            PanelUserMain.Visible = true;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            PanelSideMenu.Visible = false;
            PanelAdminMain.Visible = false;
            PanelUserMain.Visible = false;
            PanelTeacherMain.Visible = false;

            PanelContent.Controls.Clear();
            PanelContent.Controls.Add(LoginPage.Instance);

            LoginPage.Instance.Visible = true;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if(!PanelContent.Contains(SettingsPage.Instance))
            {
                PanelContent.Controls.Add(SettingsPage.Instance);
                SettingsPage.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                SettingsPage.Instance.BringToFront();
            }
        }

        private void Client_Resize(object sender, EventArgs e)
        {
            PanelSideMenu.Width = (int)(this.Width / 4.5);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    if (MessageBox.Show("Do you really want to quit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        Close();
                    break;

            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnUserGrades_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Contains(UserGrades.Instance))
            {
                PanelContent.Controls.Add(UserGrades.Instance);
                UserGrades.Instance.BringToFront();
                UserGrades.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                UserGrades.Instance.BringToFront();
            }
        }

        private void BtnUserCourses_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Contains(UserCourses.Instance))
            {
                PanelContent.Controls.Add(UserCourses.Instance);
                UserCourses.Instance.BringToFront();
                UserCourses.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                UserCourses.Instance.BringToFront();
            }
        }

        private void BtnAdminUsers_Click(object sender, EventArgs e)
        {
            if(!PanelContent.Contains(AdminUsers.Instance))
            {
                PanelContent.Controls.Add(AdminUsers.Instance);
                AdminUsers.Instance.BringToFront();
                AdminUsers.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                AdminUsers.Instance.BringToFront();
            }
        }

        private void BtnAdminCourses_Click(object sender, EventArgs e)
        {
            if(!PanelContent.Contains(AdminCourses.Instance))
            {
                PanelContent.Controls.Add(AdminCourses.Instance);
                AdminCourses.Instance.BringToFront();
                AdminCourses.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                AdminCourses.Instance.BringToFront();
            }
        }

        private void BtnAdminDepartments_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Contains(AdminDepartments.Instance))
            {
                PanelContent.Controls.Add(AdminDepartments.Instance);
                AdminDepartments.Instance.BringToFront();
                AdminDepartments.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                AdminDepartments.Instance.BringToFront();
            }
        }

        private void BtnAdminGrades_Click(object sender, EventArgs e)
        {
            if (!PanelContent.Contains(AdminGrades.Instance))
            {
                PanelContent.Controls.Add(AdminGrades.Instance);
                AdminGrades.Instance.BringToFront();
                AdminGrades.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                AdminGrades.Instance.BringToFront();
            }
        }
    }
}
