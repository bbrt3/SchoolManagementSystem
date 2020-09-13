namespace SchoolManagementSystem
{
    partial class Client
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.PanelUserMain = new System.Windows.Forms.Panel();
            this.BtnUserCourses = new System.Windows.Forms.Button();
            this.BtnUserGrades = new System.Windows.Forms.Button();
            this.BtnUserPanel = new System.Windows.Forms.Button();
            this.PanelTeacherMain = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnTeacherAssignments = new System.Windows.Forms.Button();
            this.BtnTeacherCourses = new System.Windows.Forms.Button();
            this.BtnTeacherGrades = new System.Windows.Forms.Button();
            this.BtnTeacherPanel = new System.Windows.Forms.Button();
            this.PanelAdminMain = new System.Windows.Forms.Panel();
            this.BtnAdminGrades = new System.Windows.Forms.Button();
            this.BtnAdminDepartments = new System.Windows.Forms.Button();
            this.BtnAdminCourses = new System.Windows.Forms.Button();
            this.BtnAdminUsers = new System.Windows.Forms.Button();
            this.BtnAdminPanel = new System.Windows.Forms.Button();
            this.PictureSideMenuLogo = new System.Windows.Forms.PictureBox();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelSideMenu.SuspendLayout();
            this.PanelUserMain.SuspendLayout();
            this.PanelTeacherMain.SuspendLayout();
            this.PanelAdminMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSideMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.PanelSideMenu.Controls.Add(this.BtnLogout);
            this.PanelSideMenu.Controls.Add(this.BtnSettings);
            this.PanelSideMenu.Controls.Add(this.PanelUserMain);
            this.PanelSideMenu.Controls.Add(this.PanelTeacherMain);
            this.PanelSideMenu.Controls.Add(this.PanelAdminMain);
            this.PanelSideMenu.Controls.Add(this.PictureSideMenuLogo);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(200, 696);
            this.PanelSideMenu.TabIndex = 0;
            this.PanelSideMenu.Visible = false;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(0, 591);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(200, 33);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Location = new System.Drawing.Point(0, 558);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(200, 33);
            this.BtnSettings.TabIndex = 5;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // PanelUserMain
            // 
            this.PanelUserMain.Controls.Add(this.BtnUserCourses);
            this.PanelUserMain.Controls.Add(this.BtnUserGrades);
            this.PanelUserMain.Controls.Add(this.BtnUserPanel);
            this.PanelUserMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUserMain.Location = new System.Drawing.Point(0, 462);
            this.PanelUserMain.Name = "PanelUserMain";
            this.PanelUserMain.Size = new System.Drawing.Size(200, 96);
            this.PanelUserMain.TabIndex = 3;
            this.PanelUserMain.Visible = false;
            // 
            // BtnUserCourses
            // 
            this.BtnUserCourses.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnUserCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUserCourses.FlatAppearance.BorderSize = 0;
            this.BtnUserCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUserCourses.ForeColor = System.Drawing.Color.White;
            this.BtnUserCourses.Location = new System.Drawing.Point(0, 66);
            this.BtnUserCourses.Name = "BtnUserCourses";
            this.BtnUserCourses.Size = new System.Drawing.Size(200, 33);
            this.BtnUserCourses.TabIndex = 2;
            this.BtnUserCourses.Text = "Courses";
            this.BtnUserCourses.UseVisualStyleBackColor = false;
            this.BtnUserCourses.Click += new System.EventHandler(this.BtnUserCourses_Click);
            // 
            // BtnUserGrades
            // 
            this.BtnUserGrades.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnUserGrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUserGrades.FlatAppearance.BorderSize = 0;
            this.BtnUserGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUserGrades.ForeColor = System.Drawing.Color.White;
            this.BtnUserGrades.Location = new System.Drawing.Point(0, 33);
            this.BtnUserGrades.Name = "BtnUserGrades";
            this.BtnUserGrades.Size = new System.Drawing.Size(200, 33);
            this.BtnUserGrades.TabIndex = 1;
            this.BtnUserGrades.Text = "Grades";
            this.BtnUserGrades.UseVisualStyleBackColor = false;
            this.BtnUserGrades.Click += new System.EventHandler(this.BtnUserGrades_Click);
            // 
            // BtnUserPanel
            // 
            this.BtnUserPanel.BackColor = System.Drawing.Color.White;
            this.BtnUserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUserPanel.Enabled = false;
            this.BtnUserPanel.FlatAppearance.BorderSize = 0;
            this.BtnUserPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUserPanel.ForeColor = System.Drawing.Color.Black;
            this.BtnUserPanel.Location = new System.Drawing.Point(0, 0);
            this.BtnUserPanel.Name = "BtnUserPanel";
            this.BtnUserPanel.Size = new System.Drawing.Size(200, 33);
            this.BtnUserPanel.TabIndex = 0;
            this.BtnUserPanel.Text = "User Panel";
            this.BtnUserPanel.UseVisualStyleBackColor = false;
            // 
            // PanelTeacherMain
            // 
            this.PanelTeacherMain.Controls.Add(this.button6);
            this.PanelTeacherMain.Controls.Add(this.BtnTeacherAssignments);
            this.PanelTeacherMain.Controls.Add(this.BtnTeacherCourses);
            this.PanelTeacherMain.Controls.Add(this.BtnTeacherGrades);
            this.PanelTeacherMain.Controls.Add(this.BtnTeacherPanel);
            this.PanelTeacherMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTeacherMain.Location = new System.Drawing.Point(0, 295);
            this.PanelTeacherMain.Name = "PanelTeacherMain";
            this.PanelTeacherMain.Size = new System.Drawing.Size(200, 167);
            this.PanelTeacherMain.TabIndex = 2;
            this.PanelTeacherMain.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 33);
            this.button6.TabIndex = 4;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // BtnTeacherAssignments
            // 
            this.BtnTeacherAssignments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnTeacherAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTeacherAssignments.FlatAppearance.BorderSize = 0;
            this.BtnTeacherAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacherAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnTeacherAssignments.ForeColor = System.Drawing.Color.White;
            this.BtnTeacherAssignments.Location = new System.Drawing.Point(0, 99);
            this.BtnTeacherAssignments.Name = "BtnTeacherAssignments";
            this.BtnTeacherAssignments.Size = new System.Drawing.Size(200, 33);
            this.BtnTeacherAssignments.TabIndex = 3;
            this.BtnTeacherAssignments.Text = "Assignments";
            this.BtnTeacherAssignments.UseVisualStyleBackColor = false;
            // 
            // BtnTeacherCourses
            // 
            this.BtnTeacherCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnTeacherCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTeacherCourses.FlatAppearance.BorderSize = 0;
            this.BtnTeacherCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacherCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnTeacherCourses.ForeColor = System.Drawing.Color.White;
            this.BtnTeacherCourses.Location = new System.Drawing.Point(0, 66);
            this.BtnTeacherCourses.Name = "BtnTeacherCourses";
            this.BtnTeacherCourses.Size = new System.Drawing.Size(200, 33);
            this.BtnTeacherCourses.TabIndex = 2;
            this.BtnTeacherCourses.Text = "Courses";
            this.BtnTeacherCourses.UseVisualStyleBackColor = false;
            // 
            // BtnTeacherGrades
            // 
            this.BtnTeacherGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnTeacherGrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTeacherGrades.FlatAppearance.BorderSize = 0;
            this.BtnTeacherGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacherGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnTeacherGrades.ForeColor = System.Drawing.Color.White;
            this.BtnTeacherGrades.Location = new System.Drawing.Point(0, 33);
            this.BtnTeacherGrades.Name = "BtnTeacherGrades";
            this.BtnTeacherGrades.Size = new System.Drawing.Size(200, 33);
            this.BtnTeacherGrades.TabIndex = 1;
            this.BtnTeacherGrades.Text = "Grades";
            this.BtnTeacherGrades.UseVisualStyleBackColor = false;
            // 
            // BtnTeacherPanel
            // 
            this.BtnTeacherPanel.BackColor = System.Drawing.Color.White;
            this.BtnTeacherPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTeacherPanel.Enabled = false;
            this.BtnTeacherPanel.FlatAppearance.BorderSize = 0;
            this.BtnTeacherPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeacherPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnTeacherPanel.ForeColor = System.Drawing.Color.Black;
            this.BtnTeacherPanel.Location = new System.Drawing.Point(0, 0);
            this.BtnTeacherPanel.Name = "BtnTeacherPanel";
            this.BtnTeacherPanel.Size = new System.Drawing.Size(200, 33);
            this.BtnTeacherPanel.TabIndex = 0;
            this.BtnTeacherPanel.Text = "Instructor Panel";
            this.BtnTeacherPanel.UseVisualStyleBackColor = false;
            // 
            // PanelAdminMain
            // 
            this.PanelAdminMain.Controls.Add(this.BtnAdminGrades);
            this.PanelAdminMain.Controls.Add(this.BtnAdminDepartments);
            this.PanelAdminMain.Controls.Add(this.BtnAdminCourses);
            this.PanelAdminMain.Controls.Add(this.BtnAdminUsers);
            this.PanelAdminMain.Controls.Add(this.BtnAdminPanel);
            this.PanelAdminMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAdminMain.Location = new System.Drawing.Point(0, 128);
            this.PanelAdminMain.Name = "PanelAdminMain";
            this.PanelAdminMain.Size = new System.Drawing.Size(200, 167);
            this.PanelAdminMain.TabIndex = 1;
            this.PanelAdminMain.Visible = false;
            // 
            // BtnAdminGrades
            // 
            this.BtnAdminGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.BtnAdminGrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdminGrades.FlatAppearance.BorderSize = 0;
            this.BtnAdminGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdminGrades.ForeColor = System.Drawing.Color.White;
            this.BtnAdminGrades.Location = new System.Drawing.Point(0, 132);
            this.BtnAdminGrades.Name = "BtnAdminGrades";
            this.BtnAdminGrades.Size = new System.Drawing.Size(200, 33);
            this.BtnAdminGrades.TabIndex = 4;
            this.BtnAdminGrades.Text = "Grades";
            this.BtnAdminGrades.UseVisualStyleBackColor = false;
            // 
            // BtnAdminDepartments
            // 
            this.BtnAdminDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.BtnAdminDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdminDepartments.FlatAppearance.BorderSize = 0;
            this.BtnAdminDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdminDepartments.ForeColor = System.Drawing.Color.White;
            this.BtnAdminDepartments.Location = new System.Drawing.Point(0, 99);
            this.BtnAdminDepartments.Name = "BtnAdminDepartments";
            this.BtnAdminDepartments.Size = new System.Drawing.Size(200, 33);
            this.BtnAdminDepartments.TabIndex = 3;
            this.BtnAdminDepartments.Text = "Departments";
            this.BtnAdminDepartments.UseVisualStyleBackColor = false;
            // 
            // BtnAdminCourses
            // 
            this.BtnAdminCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.BtnAdminCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdminCourses.FlatAppearance.BorderSize = 0;
            this.BtnAdminCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdminCourses.ForeColor = System.Drawing.Color.White;
            this.BtnAdminCourses.Location = new System.Drawing.Point(0, 66);
            this.BtnAdminCourses.Name = "BtnAdminCourses";
            this.BtnAdminCourses.Size = new System.Drawing.Size(200, 33);
            this.BtnAdminCourses.TabIndex = 2;
            this.BtnAdminCourses.Text = "Courses";
            this.BtnAdminCourses.UseVisualStyleBackColor = false;
            this.BtnAdminCourses.Click += new System.EventHandler(this.BtnAdminCourses_Click);
            // 
            // BtnAdminUsers
            // 
            this.BtnAdminUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(71)))));
            this.BtnAdminUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdminUsers.FlatAppearance.BorderSize = 0;
            this.BtnAdminUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdminUsers.ForeColor = System.Drawing.Color.White;
            this.BtnAdminUsers.Location = new System.Drawing.Point(0, 33);
            this.BtnAdminUsers.Name = "BtnAdminUsers";
            this.BtnAdminUsers.Size = new System.Drawing.Size(200, 33);
            this.BtnAdminUsers.TabIndex = 1;
            this.BtnAdminUsers.Text = "Users";
            this.BtnAdminUsers.UseVisualStyleBackColor = false;
            this.BtnAdminUsers.Click += new System.EventHandler(this.BtnAdminUsers_Click);
            // 
            // BtnAdminPanel
            // 
            this.BtnAdminPanel.BackColor = System.Drawing.Color.White;
            this.BtnAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdminPanel.Enabled = false;
            this.BtnAdminPanel.FlatAppearance.BorderSize = 0;
            this.BtnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdminPanel.ForeColor = System.Drawing.Color.Black;
            this.BtnAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.BtnAdminPanel.Name = "BtnAdminPanel";
            this.BtnAdminPanel.Size = new System.Drawing.Size(200, 33);
            this.BtnAdminPanel.TabIndex = 0;
            this.BtnAdminPanel.Text = "Admin panel";
            this.BtnAdminPanel.UseVisualStyleBackColor = false;
            // 
            // PictureSideMenuLogo
            // 
            this.PictureSideMenuLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureSideMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureSideMenuLogo.Image = global::SchoolManagementSystem.Properties.Resources.logo_small;
            this.PictureSideMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureSideMenuLogo.Name = "PictureSideMenuLogo";
            this.PictureSideMenuLogo.Size = new System.Drawing.Size(200, 128);
            this.PictureSideMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureSideMenuLogo.TabIndex = 0;
            this.PictureSideMenuLogo.TabStop = false;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.MidnightBlue;
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(200, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(674, 696);
            this.PanelContent.TabIndex = 1;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 696);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.Client_Load);
            this.Resize += new System.EventHandler(this.Client_Resize);
            this.PanelSideMenu.ResumeLayout(false);
            this.PanelUserMain.ResumeLayout(false);
            this.PanelTeacherMain.ResumeLayout(false);
            this.PanelAdminMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSideMenuLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.PictureBox PictureSideMenuLogo;
        private System.Windows.Forms.Button BtnAdminUsers;
        private System.Windows.Forms.Button BtnAdminPanel;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnUserCourses;
        private System.Windows.Forms.Button BtnUserGrades;
        private System.Windows.Forms.Button BtnUserPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnTeacherAssignments;
        private System.Windows.Forms.Button BtnTeacherCourses;
        private System.Windows.Forms.Button BtnTeacherGrades;
        private System.Windows.Forms.Button BtnTeacherPanel;
        private System.Windows.Forms.Button BtnAdminGrades;
        private System.Windows.Forms.Button BtnAdminDepartments;
        private System.Windows.Forms.Button BtnAdminCourses;
        private System.Windows.Forms.Panel PanelAdminMain;
        private System.Windows.Forms.Panel PanelTeacherMain;
        private System.Windows.Forms.Panel PanelUserMain;
    }
}

