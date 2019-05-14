namespace HospitalManagement
{
    partial class frmDonnerCongéPatients
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
            this.labelListePatients = new System.Windows.Forms.Label();
            this.dtgPatientsParMedecin = new System.Windows.Forms.DataGridView();
            this.btnCongé = new System.Windows.Forms.Button();
            this.labelDepartement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreJours = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatientsParMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListePatients
            // 
            this.labelListePatients.AutoSize = true;
            this.labelListePatients.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListePatients.Location = new System.Drawing.Point(63, 26);
            this.labelListePatients.Name = "labelListePatients";
            this.labelListePatients.Size = new System.Drawing.Size(213, 27);
            this.labelListePatients.TabIndex = 4;
            this.labelListePatients.Text = "Liste de patients en :";
            // 
            // dtgPatientsParMedecin
            // 
            this.dtgPatientsParMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPatientsParMedecin.Location = new System.Drawing.Point(48, 65);
            this.dtgPatientsParMedecin.Name = "dtgPatientsParMedecin";
            this.dtgPatientsParMedecin.Size = new System.Drawing.Size(674, 227);
            this.dtgPatientsParMedecin.TabIndex = 5;
            // 
            // btnCongé
            // 
            this.btnCongé.BackColor = System.Drawing.Color.Green;
            this.btnCongé.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCongé.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongé.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongé.ForeColor = System.Drawing.Color.White;
            this.btnCongé.Location = new System.Drawing.Point(48, 393);
            this.btnCongé.Name = "btnCongé";
            this.btnCongé.Size = new System.Drawing.Size(674, 43);
            this.btnCongé.TabIndex = 75;
            this.btnCongé.Text = "Donner congé à ce patient";
            this.btnCongé.UseVisualStyleBackColor = false;
            this.btnCongé.Click += new System.EventHandler(this.btnCongé_Click);
            // 
            // labelDepartement
            // 
            this.labelDepartement.AutoSize = true;
            this.labelDepartement.Location = new System.Drawing.Point(569, 28);
            this.labelDepartement.Name = "labelDepartement";
            this.labelDepartement.Size = new System.Drawing.Size(0, 13);
            this.labelDepartement.TabIndex = 76;
            this.labelDepartement.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 27);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nombres de jours passé à l\'hôpital :";
            // 
            // txtNombreJours
            // 
            this.txtNombreJours.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreJours.Location = new System.Drawing.Point(520, 313);
            this.txtNombreJours.Name = "txtNombreJours";
            this.txtNombreJours.Size = new System.Drawing.Size(202, 30);
            this.txtNombreJours.TabIndex = 93;
            // 
            // frmDonnerCongéPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(753, 448);
            this.Controls.Add(this.txtNombreJours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDepartement);
            this.Controls.Add(this.btnCongé);
            this.Controls.Add(this.dtgPatientsParMedecin);
            this.Controls.Add(this.labelListePatients);
            this.Name = "frmDonnerCongéPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonnerCongéPatients";
            this.Load += new System.EventHandler(this.frmDonnerCongéPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatientsParMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListePatients;
        private System.Windows.Forms.DataGridView dtgPatientsParMedecin;
        internal System.Windows.Forms.Button btnCongé;
        private System.Windows.Forms.Label labelDepartement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreJours;
    }
}