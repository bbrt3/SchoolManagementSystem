namespace SchoolManagementSystem.UserControls
{
    partial class InstructorCourses
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
            this.DataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelHeaderText = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewCourses
            // 
            this.DataGridViewCourses.AllowUserToAddRows = false;
            this.DataGridViewCourses.AllowUserToDeleteRows = false;
            this.DataGridViewCourses.AutoGenerateColumns = false;
            this.DataGridViewCourses.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn});
            this.DataGridViewCourses.DataSource = this.courseBindingSource;
            this.DataGridViewCourses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewCourses.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewCourses.Location = new System.Drawing.Point(0, 140);
            this.DataGridViewCourses.Name = "DataGridViewCourses";
            this.DataGridViewCourses.ReadOnly = true;
            this.DataGridViewCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCourses.ShowCellErrors = false;
            this.DataGridViewCourses.ShowCellToolTips = false;
            this.DataGridViewCourses.ShowEditingIcon = false;
            this.DataGridViewCourses.ShowRowErrors = false;
            this.DataGridViewCourses.Size = new System.Drawing.Size(674, 556);
            this.DataGridViewCourses.TabIndex = 0;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(SchoolManagementSystem.Models.Course);
            // 
            // LabelHeaderText
            // 
            this.LabelHeaderText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelHeaderText.AutoSize = true;
            this.LabelHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelHeaderText.Location = new System.Drawing.Point(232, 0);
            this.LabelHeaderText.Name = "LabelHeaderText";
            this.LabelHeaderText.Size = new System.Drawing.Size(195, 53);
            this.LabelHeaderText.TabIndex = 1;
            this.LabelHeaderText.Text = "Courses";
            this.LabelHeaderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtSearch.Location = new System.Drawing.Point(104, 90);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(554, 29);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSearch.Location = new System.Drawing.Point(23, 93);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(75, 24);
            this.LabelSearch.TabIndex = 3;
            this.LabelSearch.Text = "Search:";
            // 
            // InstructorCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LabelHeaderText);
            this.Controls.Add(this.DataGridViewCourses);
            this.Name = "InstructorCourses";
            this.Size = new System.Drawing.Size(674, 696);
            this.Load += new System.EventHandler(this.InstructorCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Label LabelHeaderText;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LabelSearch;
    }
}
