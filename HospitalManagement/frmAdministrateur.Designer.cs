namespace HospitalManagement
{
    partial class frmAdministrateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouterMedecin = new System.Windows.Forms.Button();
            this.btnSupprimerMedecin = new System.Windows.Forms.Button();
            this.btnRapportFactures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterMedecin
            // 
            this.btnAjouterMedecin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterMedecin.Location = new System.Drawing.Point(45, 73);
            this.btnAjouterMedecin.Name = "btnAjouterMedecin";
            this.btnAjouterMedecin.Size = new System.Drawing.Size(198, 114);
            this.btnAjouterMedecin.TabIndex = 1;
            this.btnAjouterMedecin.Text = "Ajouter médecin";
            this.btnAjouterMedecin.UseVisualStyleBackColor = true;
            this.btnAjouterMedecin.Click += new System.EventHandler(this.btnAjouterMedecin_Click);
            // 
            // btnSupprimerMedecin
            // 
            this.btnSupprimerMedecin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMedecin.Location = new System.Drawing.Point(367, 68);
            this.btnSupprimerMedecin.Name = "btnSupprimerMedecin";
            this.btnSupprimerMedecin.Size = new System.Drawing.Size(193, 119);
            this.btnSupprimerMedecin.TabIndex = 2;
            this.btnSupprimerMedecin.Text = "Supprimer médecin";
            this.btnSupprimerMedecin.UseVisualStyleBackColor = true;
            this.btnSupprimerMedecin.Click += new System.EventHandler(this.btnSupprimerMedecin_Click);
            // 
            // btnRapportFactures
            // 
            this.btnRapportFactures.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapportFactures.Location = new System.Drawing.Point(207, 233);
            this.btnRapportFactures.Name = "btnRapportFactures";
            this.btnRapportFactures.Size = new System.Drawing.Size(198, 114);
            this.btnRapportFactures.TabIndex = 3;
            this.btnRapportFactures.Text = "Rapports des factures";
            this.btnRapportFactures.UseVisualStyleBackColor = true;
            this.btnRapportFactures.Click += new System.EventHandler(this.btnRapportFactures_Click);
            // 
            // frmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(609, 369);
            this.Controls.Add(this.btnRapportFactures);
            this.Controls.Add(this.btnSupprimerMedecin);
            this.Controls.Add(this.btnAjouterMedecin);
            this.Name = "frmAdministrateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrateur";
            this.Load += new System.EventHandler(this.frmAdministrateur_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterMedecin;
        private System.Windows.Forms.Button btnSupprimerMedecin;
        private System.Windows.Forms.Button btnRapportFactures;
    }
}