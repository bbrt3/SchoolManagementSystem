namespace SchoolManagementSystem.UserControls
{
    partial class AdminCourses
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelHeaderText = new System.Windows.Forms.Label();
            this.LabelNewCourse = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LabelCredits = new System.Windows.Forms.Label();
            this.LabelCourseID = new System.Windows.Forms.Label();
            this.LabelDepartment = new System.Windows.Forms.Label();
            this.LabelInstructor = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.comboBoxCredits = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.comboBoxInstructors = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.onsiteCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onsiteCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.Title,
            this.Credits,
            this.DepartmentID});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 291);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(674, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Credits
            // 
            this.Credits.DataPropertyName = "Credits";
            this.Credits.HeaderText = "Credits";
            this.Credits.Name = "Credits";
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "DepartmentID";
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Width = 331;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SchoolManagementSystem.Models.Course);
            // 
            // LabelHeaderText
            // 
            this.LabelHeaderText.AutoSize = true;
            this.LabelHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelHeaderText.Location = new System.Drawing.Point(239, 0);
            this.LabelHeaderText.Name = "LabelHeaderText";
            this.LabelHeaderText.Size = new System.Drawing.Size(195, 51);
            this.LabelHeaderText.TabIndex = 1;
            this.LabelHeaderText.Text = "Courses:";
            // 
            // LabelNewCourse
            // 
            this.LabelNewCourse.AutoSize = true;
            this.LabelNewCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNewCourse.Location = new System.Drawing.Point(282, 58);
            this.LabelNewCourse.Name = "LabelNewCourse";
            this.LabelNewCourse.Size = new System.Drawing.Size(121, 25);
            this.LabelNewCourse.TabIndex = 1;
            this.LabelNewCourse.Text = "New course:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(242, 104);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(30, 13);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Title:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(313, 101);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(121, 20);
            this.TxtTitle.TabIndex = 0;
            // 
            // LabelCredits
            // 
            this.LabelCredits.AutoSize = true;
            this.LabelCredits.Location = new System.Drawing.Point(242, 130);
            this.LabelCredits.Name = "LabelCredits";
            this.LabelCredits.Size = new System.Drawing.Size(42, 13);
            this.LabelCredits.TabIndex = 2;
            this.LabelCredits.Text = "Credits:";
            // 
            // LabelCourseID
            // 
            this.LabelCourseID.AutoSize = true;
            this.LabelCourseID.Location = new System.Drawing.Point(242, 159);
            this.LabelCourseID.Name = "LabelCourseID";
            this.LabelCourseID.Size = new System.Drawing.Size(21, 13);
            this.LabelCourseID.TabIndex = 2;
            this.LabelCourseID.Text = "ID:";
            // 
            // LabelDepartment
            // 
            this.LabelDepartment.AutoSize = true;
            this.LabelDepartment.Location = new System.Drawing.Point(242, 183);
            this.LabelDepartment.Name = "LabelDepartment";
            this.LabelDepartment.Size = new System.Drawing.Size(65, 13);
            this.LabelDepartment.TabIndex = 2;
            this.LabelDepartment.Text = "Department:";
            // 
            // LabelInstructor
            // 
            this.LabelInstructor.AutoSize = true;
            this.LabelInstructor.Location = new System.Drawing.Point(242, 210);
            this.LabelInstructor.Name = "LabelInstructor";
            this.LabelInstructor.Size = new System.Drawing.Size(54, 13);
            this.LabelInstructor.TabIndex = 2;
            this.LabelInstructor.Text = "Instructor:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.HotPink;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(245, 233);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(189, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add course";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(313, 152);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(121, 20);
            this.TxtID.TabIndex = 2;
            // 
            // comboBoxCredits
            // 
            this.comboBoxCredits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCredits.FormattingEnabled = true;
            this.comboBoxCredits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxCredits.Location = new System.Drawing.Point(313, 127);
            this.comboBoxCredits.Name = "comboBoxCredits";
            this.comboBoxCredits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCredits.TabIndex = 1;
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(313, 178);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartments.TabIndex = 3;
            // 
            // comboBoxInstructors
            // 
            this.comboBoxInstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInstructors.FormattingEnabled = true;
            this.comboBoxInstructors.Location = new System.Drawing.Point(313, 206);
            this.comboBoxInstructors.Name = "comboBoxInstructors";
            this.comboBoxInstructors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInstructors.TabIndex = 4;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(65, 265);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(597, 20);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(15, 268);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(44, 13);
            this.LabelSearch.TabIndex = 7;
            this.LabelSearch.Text = "Search:";
            // 
            // onsiteCourseBindingSource
            // 
            this.onsiteCourseBindingSource.DataSource = typeof(SchoolManagementSystem.Models.OnsiteCourse);
            // 
            // AdminCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.comboBoxInstructors);
            this.Controls.Add(this.comboBoxDepartments);
            this.Controls.Add(this.comboBoxCredits);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LabelDepartment);
            this.Controls.Add(this.LabelCourseID);
            this.Controls.Add(this.LabelCredits);
            this.Controls.Add(this.LabelInstructor);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelNewCourse);
            this.Controls.Add(this.LabelHeaderText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminCourses";
            this.Size = new System.Drawing.Size(674, 696);
            this.Load += new System.EventHandler(this.AdminCourses_Load);
            this.Enter += new System.EventHandler(this.AdminCourses_Enter);
            this.Leave += new System.EventHandler(this.AdminCourses_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onsiteCourseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource onsiteCourseBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.Label LabelHeaderText;
        private System.Windows.Forms.Label LabelNewCourse;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LabelCredits;
        private System.Windows.Forms.Label LabelCourseID;
        private System.Windows.Forms.Label LabelDepartment;
        private System.Windows.Forms.Label LabelInstructor;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox comboBoxCredits;
        private System.Windows.Forms.ComboBox comboBoxDepartments;
        private System.Windows.Forms.ComboBox comboBoxInstructors;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LabelSearch;
    }
}
