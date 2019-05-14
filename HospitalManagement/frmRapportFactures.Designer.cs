namespace HospitalManagement
{
    partial class frmRapportFactures
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDepartements = new System.Windows.Forms.ListBox();
            this.dtgPatients = new System.Windows.Forms.DataGridView();
            this.btnImprimerRapports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 34);
            this.label1.TabIndex = 79;
            this.label1.Text = "Liste des informations de patient par departement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 27);
            this.label2.TabIndex = 80;
            this.label2.Text = "Liste de départements";
            // 
            // listBoxDepartements
            // 
            this.listBoxDepartements.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDepartements.FormattingEnabled = true;
            this.listBoxDepartements.ItemHeight = 25;
            this.listBoxDepartements.Location = new System.Drawing.Point(17, 108);
            this.listBoxDepartements.Name = "listBoxDepartements";
            this.listBoxDepartements.Size = new System.Drawing.Size(246, 254);
            this.listBoxDepartements.TabIndex = 81;
            this.listBoxDepartements.Click += new System.EventHandler(this.listBoxDepartements_Click);
            // 
            // dtgPatients
            // 
            this.dtgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPatients.Location = new System.Drawing.Point(291, 108);
            this.dtgPatients.Name = "dtgPatients";
            this.dtgPatients.Size = new System.Drawing.Size(672, 254);
            this.dtgPatients.TabIndex = 82;
            // 
            // btnImprimerRapports
            // 
            this.btnImprimerRapports.BackColor = System.Drawing.Color.Blue;
            this.btnImprimerRapports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimerRapports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerRapports.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerRapports.ForeColor = System.Drawing.Color.White;
            this.btnImprimerRapports.Location = new System.Drawing.Point(17, 375);
            this.btnImprimerRapports.Name = "btnImprimerRapports";
            this.btnImprimerRapports.Size = new System.Drawing.Size(963, 48);
            this.btnImprimerRapports.TabIndex = 83;
            this.btnImprimerRapports.Text = "Imprimer dans un fichier texte";
            this.btnImprimerRapports.UseVisualStyleBackColor = false;
            this.btnImprimerRapports.Click += new System.EventHandler(this.btnImprimerRapports_Click);
            // 
            // frmRapportFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(992, 435);
            this.Controls.Add(this.btnImprimerRapports);
            this.Controls.Add(this.dtgPatients);
            this.Controls.Add(this.listBoxDepartements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRapportFactures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRapportFactures";
            this.Load += new System.EventHandler(this.frmRapportFactures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDepartements;
        private System.Windows.Forms.DataGridView dtgPatients;
        internal System.Windows.Forms.Button btnImprimerRapports;
    }
}