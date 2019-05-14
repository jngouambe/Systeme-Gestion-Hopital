namespace HospitalManagement
{
    partial class frmInfirmier_e_s
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
            this.dtgListePatients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChambreArechercher = new System.Windows.Forms.TextBox();
            this.btnRechercherChambre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListePatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListePatients
            // 
            this.dtgListePatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListePatients.Location = new System.Drawing.Point(12, 141);
            this.dtgListePatients.Name = "dtgListePatients";
            this.dtgListePatients.Size = new System.Drawing.Size(1160, 319);
            this.dtgListePatients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des patients dans la chambre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrer le numéro de chambre à rechercher :";
            // 
            // txtChambreArechercher
            // 
            this.txtChambreArechercher.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChambreArechercher.Location = new System.Drawing.Point(812, 13);
            this.txtChambreArechercher.Name = "txtChambreArechercher";
            this.txtChambreArechercher.Size = new System.Drawing.Size(193, 34);
            this.txtChambreArechercher.TabIndex = 3;
            // 
            // btnRechercherChambre
            // 
            this.btnRechercherChambre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRechercherChambre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherChambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherChambre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherChambre.ForeColor = System.Drawing.Color.White;
            this.btnRechercherChambre.Location = new System.Drawing.Point(1020, 12);
            this.btnRechercherChambre.Name = "btnRechercherChambre";
            this.btnRechercherChambre.Size = new System.Drawing.Size(114, 37);
            this.btnRechercherChambre.TabIndex = 76;
            this.btnRechercherChambre.Text = "Rechercher";
            this.btnRechercherChambre.UseVisualStyleBackColor = false;
            this.btnRechercherChambre.Click += new System.EventHandler(this.btnRechercherChambre_Click);
            // 
            // frmInfirmier_e_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1184, 474);
            this.Controls.Add(this.btnRechercherChambre);
            this.Controls.Add(this.txtChambreArechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgListePatients);
            this.Name = "frmInfirmier_e_s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInfirmier_e_s";
            this.Load += new System.EventHandler(this.frmInfirmier_e_s_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListePatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListePatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChambreArechercher;
        internal System.Windows.Forms.Button btnRechercherChambre;
    }
}