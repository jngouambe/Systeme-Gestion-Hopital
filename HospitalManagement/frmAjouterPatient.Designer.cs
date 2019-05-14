namespace HospitalManagement
{
    partial class frmAjouterPatient
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
            this.comboBxDepartement = new System.Windows.Forms.ComboBox();
            this.DateTimePickerNaissanceMedecin = new System.Windows.Forms.DateTimePicker();
            this.txtPrenomMedecin = new System.Windows.Forms.TextBox();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.btnAjouterPatient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnNONAssurance = new System.Windows.Forms.RadioButton();
            this.rBtnOUIAssurance = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBxTypeChambre = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblNombreLitDispoParDepartement = new System.Windows.Forms.Label();
            this.labelLitDispo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnLouerTelevisionNON = new System.Windows.Forms.RadioButton();
            this.rBtnLouerTelevisionOUI = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnLocationTelephoneNON = new System.Windows.Forms.RadioButton();
            this.rBtnLocationTelephoneOUI = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBxNumeroLit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBxDepartement
            // 
            this.comboBxDepartement.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.comboBxDepartement.FormattingEnabled = true;
            this.comboBxDepartement.Location = new System.Drawing.Point(276, 203);
            this.comboBxDepartement.Name = "comboBxDepartement";
            this.comboBxDepartement.Size = new System.Drawing.Size(261, 31);
            this.comboBxDepartement.TabIndex = 95;
            // 
            // DateTimePickerNaissanceMedecin
            // 
            this.DateTimePickerNaissanceMedecin.CustomFormat = "yyyy-MM-dd";
            this.DateTimePickerNaissanceMedecin.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.DateTimePickerNaissanceMedecin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerNaissanceMedecin.Location = new System.Drawing.Point(276, 149);
            this.DateTimePickerNaissanceMedecin.Name = "DateTimePickerNaissanceMedecin";
            this.DateTimePickerNaissanceMedecin.Size = new System.Drawing.Size(261, 30);
            this.DateTimePickerNaissanceMedecin.TabIndex = 94;
            // 
            // txtPrenomMedecin
            // 
            this.txtPrenomMedecin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomMedecin.Location = new System.Drawing.Point(276, 96);
            this.txtPrenomMedecin.Name = "txtPrenomMedecin";
            this.txtPrenomMedecin.Size = new System.Drawing.Size(261, 30);
            this.txtPrenomMedecin.TabIndex = 93;
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMedecin.Location = new System.Drawing.Point(276, 43);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.Size = new System.Drawing.Size(261, 30);
            this.txtNomMedecin.TabIndex = 92;
            // 
            // btnAjouterPatient
            // 
            this.btnAjouterPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouterPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPatient.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPatient.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPatient.Location = new System.Drawing.Point(423, 502);
            this.btnAjouterPatient.Name = "btnAjouterPatient";
            this.btnAjouterPatient.Size = new System.Drawing.Size(114, 35);
            this.btnAjouterPatient.TabIndex = 91;
            this.btnAjouterPatient.Text = "Ajouter";
            this.btnAjouterPatient.UseVisualStyleBackColor = false;
            this.btnAjouterPatient.Click += new System.EventHandler(this.btnAjouterPatient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 90;
            this.label4.Text = "Département:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 89;
            this.label3.Text = "Date de naissance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 88;
            this.label2.Text = "Prénom du patient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 87;
            this.label1.Text = "Nom du patient:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 96;
            this.label5.Text = "Assurance privée:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnNONAssurance);
            this.groupBox1.Controls.Add(this.rBtnOUIAssurance);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(276, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 51);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // rBtnNONAssurance
            // 
            this.rBtnNONAssurance.AutoSize = true;
            this.rBtnNONAssurance.Checked = true;
            this.rBtnNONAssurance.Location = new System.Drawing.Point(177, 18);
            this.rBtnNONAssurance.Name = "rBtnNONAssurance";
            this.rBtnNONAssurance.Size = new System.Drawing.Size(67, 27);
            this.rBtnNONAssurance.TabIndex = 1;
            this.rBtnNONAssurance.TabStop = true;
            this.rBtnNONAssurance.Text = "NON";
            this.rBtnNONAssurance.UseVisualStyleBackColor = true;
            // 
            // rBtnOUIAssurance
            // 
            this.rBtnOUIAssurance.AutoSize = true;
            this.rBtnOUIAssurance.Location = new System.Drawing.Point(6, 18);
            this.rBtnOUIAssurance.Name = "rBtnOUIAssurance";
            this.rBtnOUIAssurance.Size = new System.Drawing.Size(62, 27);
            this.rBtnOUIAssurance.TabIndex = 0;
            this.rBtnOUIAssurance.Text = "OUI";
            this.rBtnOUIAssurance.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 98;
            this.label6.Text = "Type de chambre:";
            // 
            // comboBxTypeChambre
            // 
            this.comboBxTypeChambre.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.comboBxTypeChambre.FormattingEnabled = true;
            this.comboBxTypeChambre.Location = new System.Drawing.Point(276, 338);
            this.comboBxTypeChambre.Name = "comboBxTypeChambre";
            this.comboBxTypeChambre.Size = new System.Drawing.Size(261, 31);
            this.comboBxTypeChambre.TabIndex = 99;
            this.comboBxTypeChambre.SelectedIndexChanged += new System.EventHandler(this.comboBxTypeChambre_SelectedIndexChanged);
            this.comboBxTypeChambre.Click += new System.EventHandler(this.comboBxTypeChambre_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(278, 290);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 100;
            this.lblMessage.Visible = false;
            // 
            // lblNombreLitDispoParDepartement
            // 
            this.lblNombreLitDispoParDepartement.AutoSize = true;
            this.lblNombreLitDispoParDepartement.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLitDispoParDepartement.Location = new System.Drawing.Point(572, 67);
            this.lblNombreLitDispoParDepartement.Name = "lblNombreLitDispoParDepartement";
            this.lblNombreLitDispoParDepartement.Size = new System.Drawing.Size(283, 23);
            this.lblNombreLitDispoParDepartement.TabIndex = 101;
            this.lblNombreLitDispoParDepartement.Text = "Nombres de lits disponibles  pour :";
            // 
            // labelLitDispo
            // 
            this.labelLitDispo.AutoSize = true;
            this.labelLitDispo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLitDispo.ForeColor = System.Drawing.Color.Red;
            this.labelLitDispo.Location = new System.Drawing.Point(610, 122);
            this.labelLitDispo.Name = "labelLitDispo";
            this.labelLitDispo.Size = new System.Drawing.Size(0, 30);
            this.labelLitDispo.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(164, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 15);
            this.label7.TabIndex = 103;
            this.label7.Text = "*Veillez cliquer sur le type choisi pour voir le nombre de lits disponibles.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 23);
            this.label8.TabIndex = 104;
            this.label8.Text = "Location de télévision:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(280, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 106;
            this.label9.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnLouerTelevisionNON);
            this.groupBox2.Controls.Add(this.rBtnLouerTelevisionOUI);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 51);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            // 
            // rBtnLouerTelevisionNON
            // 
            this.rBtnLouerTelevisionNON.AutoSize = true;
            this.rBtnLouerTelevisionNON.Checked = true;
            this.rBtnLouerTelevisionNON.Location = new System.Drawing.Point(177, 18);
            this.rBtnLouerTelevisionNON.Name = "rBtnLouerTelevisionNON";
            this.rBtnLouerTelevisionNON.Size = new System.Drawing.Size(67, 27);
            this.rBtnLouerTelevisionNON.TabIndex = 1;
            this.rBtnLouerTelevisionNON.TabStop = true;
            this.rBtnLouerTelevisionNON.Text = "NON";
            this.rBtnLouerTelevisionNON.UseVisualStyleBackColor = true;
            // 
            // rBtnLouerTelevisionOUI
            // 
            this.rBtnLouerTelevisionOUI.AutoSize = true;
            this.rBtnLouerTelevisionOUI.Location = new System.Drawing.Point(6, 18);
            this.rBtnLouerTelevisionOUI.Name = "rBtnLouerTelevisionOUI";
            this.rBtnLouerTelevisionOUI.Size = new System.Drawing.Size(62, 27);
            this.rBtnLouerTelevisionOUI.TabIndex = 0;
            this.rBtnLouerTelevisionOUI.Text = "OUI";
            this.rBtnLouerTelevisionOUI.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(280, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 109;
            this.label10.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnLocationTelephoneNON);
            this.groupBox3.Controls.Add(this.rBtnLocationTelephoneOUI);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(278, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 51);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            // 
            // rBtnLocationTelephoneNON
            // 
            this.rBtnLocationTelephoneNON.AutoSize = true;
            this.rBtnLocationTelephoneNON.Checked = true;
            this.rBtnLocationTelephoneNON.Location = new System.Drawing.Point(177, 18);
            this.rBtnLocationTelephoneNON.Name = "rBtnLocationTelephoneNON";
            this.rBtnLocationTelephoneNON.Size = new System.Drawing.Size(67, 27);
            this.rBtnLocationTelephoneNON.TabIndex = 1;
            this.rBtnLocationTelephoneNON.TabStop = true;
            this.rBtnLocationTelephoneNON.Text = "NON";
            this.rBtnLocationTelephoneNON.UseVisualStyleBackColor = true;
            // 
            // rBtnLocationTelephoneOUI
            // 
            this.rBtnLocationTelephoneOUI.AutoSize = true;
            this.rBtnLocationTelephoneOUI.Location = new System.Drawing.Point(6, 18);
            this.rBtnLocationTelephoneOUI.Name = "rBtnLocationTelephoneOUI";
            this.rBtnLocationTelephoneOUI.Size = new System.Drawing.Size(62, 27);
            this.rBtnLocationTelephoneOUI.TabIndex = 0;
            this.rBtnLocationTelephoneOUI.Text = "OUI";
            this.rBtnLocationTelephoneOUI.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 23);
            this.label11.TabIndex = 107;
            this.label11.Text = "Location de télephone:";
            // 
            // comboBxNumeroLit
            // 
            this.comboBxNumeroLit.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.comboBxNumeroLit.FormattingEnabled = true;
            this.comboBxNumeroLit.Location = new System.Drawing.Point(732, 243);
            this.comboBxNumeroLit.Name = "comboBxNumeroLit";
            this.comboBxNumeroLit.Size = new System.Drawing.Size(261, 31);
            this.comboBxNumeroLit.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(591, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 110;
            this.label12.Text = "Numéro du lit:";
            // 
            // frmAjouterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(999, 549);
            this.Controls.Add(this.comboBxNumeroLit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelLitDispo);
            this.Controls.Add(this.lblNombreLitDispoParDepartement);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.comboBxTypeChambre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBxDepartement);
            this.Controls.Add(this.DateTimePickerNaissanceMedecin);
            this.Controls.Add(this.txtPrenomMedecin);
            this.Controls.Add(this.txtNomMedecin);
            this.Controls.Add(this.btnAjouterPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAjouterPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterPatient";
            this.Load += new System.EventHandler(this.frmAjouterPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBxDepartement;
        internal System.Windows.Forms.DateTimePicker DateTimePickerNaissanceMedecin;
        private System.Windows.Forms.TextBox txtPrenomMedecin;
        private System.Windows.Forms.TextBox txtNomMedecin;
        internal System.Windows.Forms.Button btnAjouterPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnNONAssurance;
        private System.Windows.Forms.RadioButton rBtnOUIAssurance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBxTypeChambre;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblNombreLitDispoParDepartement;
        private System.Windows.Forms.Label labelLitDispo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnLouerTelevisionNON;
        private System.Windows.Forms.RadioButton rBtnLouerTelevisionOUI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnLocationTelephoneNON;
        private System.Windows.Forms.RadioButton rBtnLocationTelephoneOUI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBxNumeroLit;
        private System.Windows.Forms.Label label12;
    }
}