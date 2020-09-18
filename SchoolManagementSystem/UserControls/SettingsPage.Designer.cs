namespace SchoolManagementSystem.UserControls
{
    partial class SettingsPage
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
            this.LabelSettings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelSettings
            // 
            this.LabelSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelSettings.AutoSize = true;
            this.LabelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSettings.Location = new System.Drawing.Point(230, 0);
            this.LabelSettings.Name = "LabelSettings";
            this.LabelSettings.Size = new System.Drawing.Size(191, 53);
            this.LabelSettings.TabIndex = 0;
            this.LabelSettings.Text = "Settings";
            this.LabelSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.LabelSettings);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(674, 696);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSettings;
    }
}
