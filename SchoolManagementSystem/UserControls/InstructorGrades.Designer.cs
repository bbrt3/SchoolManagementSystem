namespace SchoolManagementSystem.UserControls
{
    partial class InstructorGrades
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
            this.DataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.enrollmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelStudentGrades = new System.Windows.Forms.Label();
            this.LabelNewGrade = new System.Windows.Forms.Label();
            this.LabelCourseID = new System.Windows.Forms.Label();
            this.BtnAddGrade = new System.Windows.Forms.Button();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.LabelGrade = new System.Windows.Forms.Label();
            this.ComboBoxStudents = new System.Windows.Forms.ComboBox();
            this.ComboBoxGrades = new System.Windows.Forms.ComboBox();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewGrades
            // 
            this.DataGridViewGrades.AllowUserToAddRows = false;
            this.DataGridViewGrades.AutoGenerateColumns = false;
            this.DataGridViewGrades.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollmentIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.eCTSDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn});
            this.DataGridViewGrades.DataSource = this.studentGradeBindingSource;
            this.DataGridViewGrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewGrades.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewGrades.Location = new System.Drawing.Point(0, 297);
            this.DataGridViewGrades.Name = "DataGridViewGrades";
            this.DataGridViewGrades.ReadOnly = true;
            this.DataGridViewGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewGrades.ShowCellErrors = false;
            this.DataGridViewGrades.ShowCellToolTips = false;
            this.DataGridViewGrades.ShowRowErrors = false;
            this.DataGridViewGrades.Size = new System.Drawing.Size(674, 399);
            this.DataGridViewGrades.TabIndex = 4;
            this.DataGridViewGrades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewGrades_KeyDown);
            // 
            // enrollmentIDDataGridViewTextBoxColumn
            // 
            this.enrollmentIDDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentID";
            this.enrollmentIDDataGridViewTextBoxColumn.HeaderText = "EnrollmentID";
            this.enrollmentIDDataGridViewTextBoxColumn.Name = "enrollmentIDDataGridViewTextBoxColumn";
            this.enrollmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eCTSDataGridViewTextBoxColumn
            // 
            this.eCTSDataGridViewTextBoxColumn.DataPropertyName = "ECTS";
            this.eCTSDataGridViewTextBoxColumn.HeaderText = "ECTS";
            this.eCTSDataGridViewTextBoxColumn.Name = "eCTSDataGridViewTextBoxColumn";
            this.eCTSDataGridViewTextBoxColumn.ReadOnly = true;
            this.eCTSDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseDataGridViewTextBoxColumn.Visible = false;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            this.personDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentGradeBindingSource
            // 
            this.studentGradeBindingSource.DataSource = typeof(SchoolManagementSystem.Models.StudentGrade);
            // 
            // LabelStudentGrades
            // 
            this.LabelStudentGrades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelStudentGrades.AutoSize = true;
            this.LabelStudentGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelStudentGrades.Location = new System.Drawing.Point(248, 0);
            this.LabelStudentGrades.Name = "LabelStudentGrades";
            this.LabelStudentGrades.Size = new System.Drawing.Size(175, 53);
            this.LabelStudentGrades.TabIndex = 1;
            this.LabelStudentGrades.Text = "Grades";
            this.LabelStudentGrades.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelNewGrade
            // 
            this.LabelNewGrade.AutoSize = true;
            this.LabelNewGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNewGrade.Location = new System.Drawing.Point(279, 96);
            this.LabelNewGrade.Name = "LabelNewGrade";
            this.LabelNewGrade.Size = new System.Drawing.Size(106, 25);
            this.LabelNewGrade.TabIndex = 2;
            this.LabelNewGrade.Text = "New grade";
            // 
            // LabelCourseID
            // 
            this.LabelCourseID.AutoSize = true;
            this.LabelCourseID.Location = new System.Drawing.Point(237, 139);
            this.LabelCourseID.Name = "LabelCourseID";
            this.LabelCourseID.Size = new System.Drawing.Size(43, 13);
            this.LabelCourseID.TabIndex = 3;
            this.LabelCourseID.Text = "Course:";
            // 
            // BtnAddGrade
            // 
            this.BtnAddGrade.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddGrade.Location = new System.Drawing.Point(240, 230);
            this.BtnAddGrade.Name = "BtnAddGrade";
            this.BtnAddGrade.Size = new System.Drawing.Size(185, 30);
            this.BtnAddGrade.TabIndex = 3;
            this.BtnAddGrade.Text = "Add grade";
            this.BtnAddGrade.UseVisualStyleBackColor = false;
            this.BtnAddGrade.Click += new System.EventHandler(this.BtnAddGrade_Click);
            // 
            // LabelStudent
            // 
            this.LabelStudent.AutoSize = true;
            this.LabelStudent.Location = new System.Drawing.Point(233, 166);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(47, 13);
            this.LabelStudent.TabIndex = 3;
            this.LabelStudent.Text = "Student:";
            // 
            // LabelGrade
            // 
            this.LabelGrade.AutoSize = true;
            this.LabelGrade.Location = new System.Drawing.Point(233, 195);
            this.LabelGrade.Name = "LabelGrade";
            this.LabelGrade.Size = new System.Drawing.Size(39, 13);
            this.LabelGrade.TabIndex = 3;
            this.LabelGrade.Text = "Grade:";
            // 
            // ComboBoxStudents
            // 
            this.ComboBoxStudents.BackColor = System.Drawing.Color.White;
            this.ComboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStudents.FormattingEnabled = true;
            this.ComboBoxStudents.Location = new System.Drawing.Point(304, 163);
            this.ComboBoxStudents.Name = "ComboBoxStudents";
            this.ComboBoxStudents.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxStudents.TabIndex = 1;
            // 
            // ComboBoxGrades
            // 
            this.ComboBoxGrades.BackColor = System.Drawing.Color.White;
            this.ComboBoxGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGrades.FormattingEnabled = true;
            this.ComboBoxGrades.Items.AddRange(new object[] {
            "",
            "2",
            "2,5",
            "3",
            "3,5",
            "4",
            "4,5",
            "5"});
            this.ComboBoxGrades.Location = new System.Drawing.Point(304, 192);
            this.ComboBoxGrades.Name = "ComboBoxGrades";
            this.ComboBoxGrades.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxGrades.TabIndex = 2;
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.BackColor = System.Drawing.Color.White;
            this.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(304, 136);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCourse.TabIndex = 0;
            // 
            // InstructorGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.ComboBoxGrades);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.ComboBoxStudents);
            this.Controls.Add(this.BtnAddGrade);
            this.Controls.Add(this.LabelGrade);
            this.Controls.Add(this.LabelCourseID);
            this.Controls.Add(this.LabelStudent);
            this.Controls.Add(this.LabelNewGrade);
            this.Controls.Add(this.LabelStudentGrades);
            this.Controls.Add(this.DataGridViewGrades);
            this.Name = "InstructorGrades";
            this.Size = new System.Drawing.Size(674, 696);
            this.Load += new System.EventHandler(this.InstructorGrades_Load);
            this.Leave += new System.EventHandler(this.InstructorGrades_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentGradeBindingSource;
        private System.Windows.Forms.Label LabelStudentGrades;
        private System.Windows.Forms.Label LabelNewGrade;
        private System.Windows.Forms.Label LabelCourseID;
        private System.Windows.Forms.Button BtnAddGrade;
        private System.Windows.Forms.Label LabelStudent;
        private System.Windows.Forms.Label LabelGrade;
        private System.Windows.Forms.ComboBox ComboBoxStudents;
        private System.Windows.Forms.ComboBox ComboBoxGrades;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
    }
}
