namespace HospitalManagement
{
    partial class frmMedecins
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
            this.btnCongePatient = new System.Windows.Forms.Button();
            this.labelDepartement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCongePatient
            // 
            this.btnCongePatient.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongePatient.Location = new System.Drawing.Point(159, 60);
            this.btnCongePatient.Name = "btnCongePatient";
            this.btnCongePatient.Size = new System.Drawing.Size(238, 117);
            this.btnCongePatient.TabIndex = 1;
            this.btnCongePatient.Text = "Donner un congé aux patients";
            this.btnCongePatient.UseVisualStyleBackColor = true;
            this.btnCongePatient.Click += new System.EventHandler(this.btnCongePatient_Click);
            // 
            // labelDepartement
            // 
            this.labelDepartement.AutoSize = true;
            this.labelDepartement.Location = new System.Drawing.Point(272, 256);
            this.labelDepartement.Name = "labelDepartement";
            this.labelDepartement.Size = new System.Drawing.Size(0, 13);
            this.labelDepartement.TabIndex = 2;
            this.labelDepartement.Visible = false;
            // 
            // frmMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(595, 334);
            this.Controls.Add(this.labelDepartement);
            this.Controls.Add(this.btnCongePatient);
            this.Name = "frmMedecins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMedecins";
            this.Load += new System.EventHandler(this.frmMedecins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCongePatient;
        private System.Windows.Forms.Label labelDepartement;
    }
}