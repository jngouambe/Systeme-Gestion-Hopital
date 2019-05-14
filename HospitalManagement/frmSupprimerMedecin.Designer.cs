namespace HospitalManagement
{
    partial class frmSupprimerMedecin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRechercherChambre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelListesDepart = new System.Windows.Forms.Label();
            this.dtgListeMedecins = new System.Windows.Forms.DataGridView();
            this.btnSupprimerMedecin = new System.Windows.Forms.Button();
            this.comboBxDepartements = new System.Windows.Forms.ComboBox();
            this.lblNombreMedecin = new System.Windows.Forms.Label();
            this.btnVoirTousLesMedecins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeMedecins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRechercherChambre
            // 
            this.btnRechercherChambre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRechercherChambre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherChambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherChambre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherChambre.ForeColor = System.Drawing.Color.White;
            this.btnRechercherChambre.Location = new System.Drawing.Point(746, 21);
            this.btnRechercherChambre.Name = "btnRechercherChambre";
            this.btnRechercherChambre.Size = new System.Drawing.Size(114, 35);
            this.btnRechercherChambre.TabIndex = 81;
            this.btnRechercherChambre.Text = "Rechercher";
            this.btnRechercherChambre.UseVisualStyleBackColor = false;
            this.btnRechercherChambre.Click += new System.EventHandler(this.btnRechercherChambre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 27);
            this.label2.TabIndex = 79;
            this.label2.Text = "Choisissez le département du médecin à supprimer :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelListesDepart
            // 
            this.labelListesDepart.AutoSize = true;
            this.labelListesDepart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListesDepart.Location = new System.Drawing.Point(47, 89);
            this.labelListesDepart.Name = "labelListesDepart";
            this.labelListesDepart.Size = new System.Drawing.Size(473, 29);
            this.labelListesDepart.TabIndex = 78;
            this.labelListesDepart.Text = "Liste des médecins de tous les départements";
            // 
            // dtgListeMedecins
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListeMedecins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListeMedecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListeMedecins.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListeMedecins.Location = new System.Drawing.Point(52, 140);
            this.dtgListeMedecins.Name = "dtgListeMedecins";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListeMedecins.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListeMedecins.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgListeMedecins.Size = new System.Drawing.Size(600, 300);
            this.dtgListeMedecins.TabIndex = 77;
            // 
            // btnSupprimerMedecin
            // 
            this.btnSupprimerMedecin.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerMedecin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerMedecin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerMedecin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMedecin.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerMedecin.Location = new System.Drawing.Point(52, 464);
            this.btnSupprimerMedecin.Name = "btnSupprimerMedecin";
            this.btnSupprimerMedecin.Size = new System.Drawing.Size(260, 52);
            this.btnSupprimerMedecin.TabIndex = 82;
            this.btnSupprimerMedecin.Text = "Supprimer";
            this.btnSupprimerMedecin.UseVisualStyleBackColor = false;
            this.btnSupprimerMedecin.Click += new System.EventHandler(this.btnSupprimerMedecin_Click);
            // 
            // comboBxDepartements
            // 
            this.comboBxDepartements.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBxDepartements.FormattingEnabled = true;
            this.comboBxDepartements.Location = new System.Drawing.Point(511, 21);
            this.comboBxDepartements.Name = "comboBxDepartements";
            this.comboBxDepartements.Size = new System.Drawing.Size(208, 35);
            this.comboBxDepartements.TabIndex = 83;
            // 
            // lblNombreMedecin
            // 
            this.lblNombreMedecin.AutoSize = true;
            this.lblNombreMedecin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreMedecin.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedecin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreMedecin.Location = new System.Drawing.Point(678, 493);
            this.lblNombreMedecin.Name = "lblNombreMedecin";
            this.lblNombreMedecin.Size = new System.Drawing.Size(227, 23);
            this.lblNombreMedecin.TabIndex = 84;
            this.lblNombreMedecin.Text = "Nombre total de medécins :";
            // 
            // btnVoirTousLesMedecins
            // 
            this.btnVoirTousLesMedecins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVoirTousLesMedecins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoirTousLesMedecins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirTousLesMedecins.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirTousLesMedecins.ForeColor = System.Drawing.Color.White;
            this.btnVoirTousLesMedecins.Location = new System.Drawing.Point(408, 466);
            this.btnVoirTousLesMedecins.Name = "btnVoirTousLesMedecins";
            this.btnVoirTousLesMedecins.Size = new System.Drawing.Size(244, 50);
            this.btnVoirTousLesMedecins.TabIndex = 85;
            this.btnVoirTousLesMedecins.Text = "Voir tous les médecins";
            this.btnVoirTousLesMedecins.UseVisualStyleBackColor = false;
            this.btnVoirTousLesMedecins.Click += new System.EventHandler(this.btnVoirTousLesMedecins_Click);
            // 
            // frmSupprimerMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(948, 528);
            this.Controls.Add(this.btnVoirTousLesMedecins);
            this.Controls.Add(this.lblNombreMedecin);
            this.Controls.Add(this.comboBxDepartements);
            this.Controls.Add(this.btnSupprimerMedecin);
            this.Controls.Add(this.btnRechercherChambre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelListesDepart);
            this.Controls.Add(this.dtgListeMedecins);
            this.Name = "frmSupprimerMedecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupprimerMedecin";
            this.Load += new System.EventHandler(this.frmSupprimerMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeMedecins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRechercherChambre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelListesDepart;
        private System.Windows.Forms.DataGridView dtgListeMedecins;
        internal System.Windows.Forms.Button btnSupprimerMedecin;
        private System.Windows.Forms.ComboBox comboBxDepartements;
        private System.Windows.Forms.Label lblNombreMedecin;
        internal System.Windows.Forms.Button btnVoirTousLesMedecins;
    }
}