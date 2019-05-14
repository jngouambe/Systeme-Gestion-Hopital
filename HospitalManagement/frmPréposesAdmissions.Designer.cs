namespace HospitalManagement
{
    partial class frmPréposesAdmissions
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
            this.btnAjouterPatient = new System.Windows.Forms.Button();
            this.bntRechercherPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterPatient
            // 
            this.btnAjouterPatient.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPatient.Location = new System.Drawing.Point(77, 175);
            this.btnAjouterPatient.Name = "btnAjouterPatient";
            this.btnAjouterPatient.Size = new System.Drawing.Size(224, 161);
            this.btnAjouterPatient.TabIndex = 0;
            this.btnAjouterPatient.Text = "Ajouter patient";
            this.btnAjouterPatient.UseVisualStyleBackColor = true;
            this.btnAjouterPatient.Click += new System.EventHandler(this.btnAjouterPatient_Click);
            // 
            // bntRechercherPatient
            // 
            this.bntRechercherPatient.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRechercherPatient.Location = new System.Drawing.Point(370, 46);
            this.bntRechercherPatient.Name = "bntRechercherPatient";
            this.bntRechercherPatient.Size = new System.Drawing.Size(224, 161);
            this.bntRechercherPatient.TabIndex = 1;
            this.bntRechercherPatient.Text = "Rechercher patient";
            this.bntRechercherPatient.UseVisualStyleBackColor = true;
            this.bntRechercherPatient.Click += new System.EventHandler(this.bntRechercherPatient_Click);
            // 
            // frmPréposesAdmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(667, 374);
            this.Controls.Add(this.bntRechercherPatient);
            this.Controls.Add(this.btnAjouterPatient);
            this.Name = "frmPréposesAdmissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPréposesAdmissions";
            this.Load += new System.EventHandler(this.frmPréposesAdmissions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterPatient;
        private System.Windows.Forms.Button bntRechercherPatient;
    }
}