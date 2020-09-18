namespace SchoolManagementSystem.UserControls
{
    partial class UserGrades
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
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.getStudentGradesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelGrades = new System.Windows.Forms.Label();
            this.enrollmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentGradesResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.AllowUserToAddRows = false;
            this.dataGridViewGrades.AllowUserToDeleteRows = false;
            this.dataGridViewGrades.AutoGenerateColumns = false;
            this.dataGridViewGrades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollmentIDDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn});
            this.dataGridViewGrades.DataSource = this.getStudentGradesResultBindingSource;
            this.dataGridViewGrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewGrades.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewGrades.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.ReadOnly = true;
            this.dataGridViewGrades.ShowCellErrors = false;
            this.dataGridViewGrades.ShowCellToolTips = false;
            this.dataGridViewGrades.ShowEditingIcon = false;
            this.dataGridViewGrades.ShowRowErrors = false;
            this.dataGridViewGrades.Size = new System.Drawing.Size(674, 633);
            this.dataGridViewGrades.TabIndex = 0;
            // 
            // getStudentGradesResultBindingSource
            // 
            this.getStudentGradesResultBindingSource.DataSource = typeof(SchoolManagementSystem.Models.GetStudentGrades_Result);
            // 
            // LabelGrades
            // 
            this.LabelGrades.AutoSize = true;
            this.LabelGrades.BackColor = System.Drawing.Color.Transparent;
            this.LabelGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelGrades.Location = new System.Drawing.Point(204, 0);
            this.LabelGrades.Name = "LabelGrades";
            this.LabelGrades.Size = new System.Drawing.Size(288, 53);
            this.LabelGrades.TabIndex = 1;
            this.LabelGrades.Text = "Your grades:";
            // 
            // enrollmentIDDataGridViewTextBoxColumn
            // 
            this.enrollmentIDDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentID";
            this.enrollmentIDDataGridViewTextBoxColumn.HeaderText = "EnrollmentID";
            this.enrollmentIDDataGridViewTextBoxColumn.Name = "enrollmentIDDataGridViewTextBoxColumn";
            this.enrollmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.enrollmentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // UserGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.LabelGrades);
            this.Controls.Add(this.dataGridViewGrades);
            this.Name = "UserGrades";
            this.Size = new System.Drawing.Size(674, 696);
            this.Resize += new System.EventHandler(this.UserGrades_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentGradesResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource getStudentGradesResultBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.Label LabelGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
    }
}
