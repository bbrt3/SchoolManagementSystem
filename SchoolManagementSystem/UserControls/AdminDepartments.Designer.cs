namespace SchoolManagementSystem.UserControls
{
    partial class AdminDepartments
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
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LabelDepartmentID = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TxtBudget = new System.Windows.Forms.TextBox();
            this.LabelBudget = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelAdministrator = new System.Windows.Forms.Label();
            this.comboBoxInstructors = new System.Windows.Forms.ComboBox();
            this.LabelNewDepartment = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeaderText
            // 
            this.LabelHeaderText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelHeaderText.AutoSize = true;
            this.LabelHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelHeaderText.Location = new System.Drawing.Point(183, 11);
            this.LabelHeaderText.Name = "LabelHeaderText";
            this.LabelHeaderText.Size = new System.Drawing.Size(288, 53);
            this.LabelHeaderText.TabIndex = 0;
            this.LabelHeaderText.Text = "Departments";
            this.LabelHeaderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AllowUserToAddRows = false;
            this.dataGridViewDepartments.AutoGenerateColumns = false;
            this.dataGridViewDepartments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.administratorDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dataGridViewDepartments.DataSource = this.departmentBindingSource;
            this.dataGridViewDepartments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDepartments.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(0, 245);
            this.dataGridViewDepartments.MultiSelect = false;
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(674, 451);
            this.dataGridViewDepartments.TabIndex = 7;
            this.dataGridViewDepartments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDepartments_KeyDown);
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "Budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // administratorDataGridViewTextBoxColumn
            // 
            this.administratorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.administratorDataGridViewTextBoxColumn.DataPropertyName = "Administrator";
            this.administratorDataGridViewTextBoxColumn.HeaderText = "Administrator";
            this.administratorDataGridViewTextBoxColumn.Name = "administratorDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(SchoolManagementSystem.Models.Department);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtSearch.Location = new System.Drawing.Point(85, 212);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(586, 27);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(187, 102);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 0;
            // 
            // LabelDepartmentID
            // 
            this.LabelDepartmentID.AutoSize = true;
            this.LabelDepartmentID.Location = new System.Drawing.Point(138, 105);
            this.LabelDepartmentID.Name = "LabelDepartmentID";
            this.LabelDepartmentID.Size = new System.Drawing.Size(21, 13);
            this.LabelDepartmentID.TabIndex = 4;
            this.LabelDepartmentID.Text = "ID:";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSearch.Location = new System.Drawing.Point(4, 212);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(75, 24);
            this.LabelSearch.TabIndex = 4;
            this.LabelSearch.Text = "Search:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(187, 128);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(138, 131);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Name:";
            // 
            // TxtBudget
            // 
            this.TxtBudget.Location = new System.Drawing.Point(187, 154);
            this.TxtBudget.Name = "TxtBudget";
            this.TxtBudget.Size = new System.Drawing.Size(100, 20);
            this.TxtBudget.TabIndex = 2;
            // 
            // LabelBudget
            // 
            this.LabelBudget.AutoSize = true;
            this.LabelBudget.Location = new System.Drawing.Point(138, 157);
            this.LabelBudget.Name = "LabelBudget";
            this.LabelBudget.Size = new System.Drawing.Size(44, 13);
            this.LabelBudget.TabIndex = 4;
            this.LabelBudget.Text = "Budget:";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(369, 113);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(190, 20);
            this.dateTimeStart.TabIndex = 3;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(293, 117);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(56, 13);
            this.LabelDate.TabIndex = 4;
            this.LabelDate.Text = "Start date:";
            // 
            // LabelAdministrator
            // 
            this.LabelAdministrator.AutoSize = true;
            this.LabelAdministrator.Location = new System.Drawing.Point(293, 147);
            this.LabelAdministrator.Name = "LabelAdministrator";
            this.LabelAdministrator.Size = new System.Drawing.Size(70, 13);
            this.LabelAdministrator.TabIndex = 4;
            this.LabelAdministrator.Text = "Administrator:";
            // 
            // comboBoxInstructors
            // 
            this.comboBoxInstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInstructors.FormattingEnabled = true;
            this.comboBoxInstructors.Location = new System.Drawing.Point(369, 144);
            this.comboBoxInstructors.Name = "comboBoxInstructors";
            this.comboBoxInstructors.Size = new System.Drawing.Size(190, 21);
            this.comboBoxInstructors.TabIndex = 4;
            // 
            // LabelNewDepartment
            // 
            this.LabelNewDepartment.AutoSize = true;
            this.LabelNewDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelNewDepartment.Location = new System.Drawing.Point(265, 73);
            this.LabelNewDepartment.Name = "LabelNewDepartment";
            this.LabelNewDepartment.Size = new System.Drawing.Size(130, 20);
            this.LabelNewDepartment.TabIndex = 4;
            this.LabelNewDepartment.Text = "New department:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DeepPink;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(269, 180);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add Department";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AdminDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.comboBoxInstructors);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.LabelBudget);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelAdministrator);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelNewDepartment);
            this.Controls.Add(this.LabelDepartmentID);
            this.Controls.Add(this.TxtBudget);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.LabelHeaderText);
            this.Name = "AdminDepartments";
            this.Size = new System.Drawing.Size(674, 696);
            this.Load += new System.EventHandler(this.AdminDepartments_Load);
            this.Enter += new System.EventHandler(this.AdminDepartments_Enter);
            this.Leave += new System.EventHandler(this.AdminDepartments_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeaderText;
        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LabelDepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn administratorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TxtBudget;
        private System.Windows.Forms.Label LabelBudget;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelAdministrator;
        private System.Windows.Forms.ComboBox comboBoxInstructors;
        private System.Windows.Forms.Label LabelNewDepartment;
        private System.Windows.Forms.Button BtnAdd;
    }
}
