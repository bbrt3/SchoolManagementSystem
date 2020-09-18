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

        public static int ID { get; set; }

        public Client()
        {
            InitializeComponent();
            Instance = this;
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

        private void Client_Load(object sender, EventArgs e)
        {
            UserControlAction(LoginPage.Instance);
        }

        private void UserControlAction(Control instance)
        {   
            if (!PanelContent.Contains(instance))
            {
                PanelContent.Controls.Add(instance);
                instance.BringToFront();
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                instance.BringToFront();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            UserControlAction(SettingsPage.Instance);
        }

        private void BtnUserGrades_Click(object sender, EventArgs e)
        {
            UserControlAction(UserGrades.Instance);
        }

        private void BtnUserCourses_Click(object sender, EventArgs e)
        {
            UserControlAction(UserCourses.Instance);
        }

        private void BtnAdminUsers_Click(object sender, EventArgs e)
        {
            UserControlAction(AdminUsers.Instance);
        }

        private void BtnAdminCourses_Click(object sender, EventArgs e)
        {
            UserControlAction(AdminCourses.Instance);
        }

        private void BtnAdminDepartments_Click(object sender, EventArgs e)
        {
            UserControlAction(AdminDepartments.Instance);
        }

        private void BtnAdminGrades_Click(object sender, EventArgs e)
        {
            UserControlAction(AdminGrades.Instance);
        }

        private void BtnTeacherGrades_Click(object sender, EventArgs e)
        {
            UserControlAction(InstructorGrades.Instance);
        }

        private void BtnTeacherCourses_Click(object sender, EventArgs e)
        {
            UserControlAction(InstructorCourses.Instance);
        }
    }
}
