namespace SchoolManagementSystem.UserControls
{
    partial class AdminGrades
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
            this.LabelHeaderText = new System.Windows.Forms.Label();
            this.DataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.enrollmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eCTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeaderText
            // 
            this.LabelHeaderText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelHeaderText.AutoSize = true;
            this.LabelHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelHeaderText.Location = new System.Drawing.Point(247, 0);
            this.LabelHeaderText.Name = "LabelHeaderText";
            this.LabelHeaderText.Size = new System.Drawing.Size(175, 53);
            this.LabelHeaderText.TabIndex = 0;
            this.LabelHeaderText.Text = "Grades";
            this.LabelHeaderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataGridViewGrades
            // 
            this.DataGridViewGrades.AutoGenerateColumns = false;
            this.DataGridViewGrades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.DataGridViewGrades.Location = new System.Drawing.Point(0, 66);
            this.DataGridViewGrades.Name = "DataGridViewGrades";
            this.DataGridViewGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewGrades.ShowCellErrors = false;
            this.DataGridViewGrades.ShowCellToolTips = false;
            this.DataGridViewGrades.ShowEditingIcon = false;
            this.DataGridViewGrades.ShowRowErrors = false;
            this.DataGridViewGrades.Size = new System.Drawing.Size(674, 630);
            this.DataGridViewGrades.TabIndex = 1;
            this.DataGridViewGrades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewGrades_KeyDown);
            // 
            // enrollmentIDDataGridViewTextBoxColumn
            // 
            this.enrollmentIDDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentID";
            this.enrollmentIDDataGridViewTextBoxColumn.HeaderText = "EnrollmentID";
            this.enrollmentIDDataGridViewTextBoxColumn.Name = "enrollmentIDDataGridViewTextBoxColumn";
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // eCTSDataGridViewTextBoxColumn
            // 
            this.eCTSDataGridViewTextBoxColumn.DataPropertyName = "ECTS";
            this.eCTSDataGridViewTextBoxColumn.HeaderText = "ECTS";
            this.eCTSDataGridViewTextBoxColumn.Name = "eCTSDataGridViewTextBoxColumn";
            this.eCTSDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Visible = false;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentGradeBindingSource
            // 
            this.studentGradeBindingSource.DataSource = typeof(SchoolManagementSystem.Models.StudentGrade);
            // 
            // AdminGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.DataGridViewGrades);
            this.Controls.Add(this.LabelHeaderText);
            this.Name = "AdminGrades";
            this.Size = new System.Drawing.Size(674, 696);
            this.Load += new System.EventHandler(this.AdminGrades_Load);
            this.Leave += new System.EventHandler(this.AdminGrades_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeaderText;
        private System.Windows.Forms.DataGridView DataGridViewGrades;
        private System.Windows.Forms.BindingSource studentGradeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eCTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
    }
}
