namespace HospitalManagement
{
    partial class frmRechercherPatient
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoirTouslesPatients = new System.Windows.Forms.Button();
            this.txtArechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.rbtnOUI = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnNON = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtgPatients = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnVoirTouslesPatients);
            this.GroupBox1.Controls.Add(this.txtArechercher);
            this.GroupBox1.Controls.Add(this.btnRechercher);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.groupBox2);
            this.GroupBox1.Location = new System.Drawing.Point(41, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(990, 194);
            this.GroupBox1.TabIndex = 65;
            this.GroupBox1.TabStop = false;
            // 
            // btnVoirTouslesPatients
            // 
            this.btnVoirTouslesPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVoirTouslesPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoirTouslesPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirTouslesPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirTouslesPatients.ForeColor = System.Drawing.Color.White;
            this.btnVoirTouslesPatients.Location = new System.Drawing.Point(204, 145);
            this.btnVoirTouslesPatients.Name = "btnVoirTouslesPatients";
            this.btnVoirTouslesPatients.Size = new System.Drawing.Size(306, 43);
            this.btnVoirTouslesPatients.TabIndex = 96;
            this.btnVoirTouslesPatients.Text = "Voir tous les patients";
            this.btnVoirTouslesPatients.UseVisualStyleBackColor = false;
            this.btnVoirTouslesPatients.Click += new System.EventHandler(this.btnVoirTouslesPatients_Click);
            // 
            // txtArechercher
            // 
            this.txtArechercher.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArechercher.Location = new System.Drawing.Point(820, 61);
            this.txtArechercher.Name = "txtArechercher";
            this.txtArechercher.Size = new System.Drawing.Size(164, 30);
            this.txtArechercher.TabIndex = 95;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.Green;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(632, 145);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(306, 43);
            this.btnRechercher.TabIndex = 74;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 23);
            this.label3.TabIndex = 94;
            this.label3.Text = "Entrez les caractères recherchés:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateTimePicker2);
            this.groupBox2.Controls.Add(this.rbtnOUI);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbtnNON);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DateTimePicker1);
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 105);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.DateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker2.Location = new System.Drawing.Point(374, 53);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(103, 26);
            this.DateTimePicker2.TabIndex = 51;
            // 
            // rbtnOUI
            // 
            this.rbtnOUI.AutoSize = true;
            this.rbtnOUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOUI.ForeColor = System.Drawing.Color.White;
            this.rbtnOUI.Location = new System.Drawing.Point(251, 11);
            this.rbtnOUI.Name = "rbtnOUI";
            this.rbtnOUI.Size = new System.Drawing.Size(59, 24);
            this.rbtnOUI.TabIndex = 73;
            this.rbtnOUI.Text = "OUI";
            this.rbtnOUI.UseVisualStyleBackColor = true;
            this.rbtnOUI.CheckedChanged += new System.EventHandler(this.rbtnOUI_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "et";
            // 
            // rbtnNON
            // 
            this.rbtnNON.AutoSize = true;
            this.rbtnNON.Checked = true;
            this.rbtnNON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNON.ForeColor = System.Drawing.Color.White;
            this.rbtnNON.Location = new System.Drawing.Point(374, 9);
            this.rbtnNON.Name = "rbtnNON";
            this.rbtnNON.Size = new System.Drawing.Size(64, 24);
            this.rbtnNON.TabIndex = 72;
            this.rbtnNON.TabStop = true;
            this.rbtnNON.Text = "NON";
            this.rbtnNON.UseVisualStyleBackColor = true;
            this.rbtnNON.CheckedChanged += new System.EventHandler(this.rbtnNON_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Utiliser la plage de dates:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(224, 53);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(103, 26);
            this.DateTimePicker1.TabIndex = 50;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(7, 54);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(211, 20);
            this.Label10.TabIndex = 68;
            this.Label10.Text = "Date de naissance entre:";
            // 
            // dtgPatients
            // 
            this.dtgPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPatients.Location = new System.Drawing.Point(41, 213);
            this.dtgPatients.Name = "dtgPatients";
            this.dtgPatients.Size = new System.Drawing.Size(1031, 284);
            this.dtgPatients.TabIndex = 64;
            // 
            // frmRechercherPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1084, 509);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dtgPatients);
            this.Name = "frmRechercherPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRechercherPatient";
            this.Load += new System.EventHandler(this.frmRechercherPatient_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.RadioButton rbtnOUI;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RadioButton rbtnNON;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DataGridView dtgPatients;
        internal System.Windows.Forms.Button btnVoirTouslesPatients;
        private System.Windows.Forms.TextBox txtArechercher;
        private System.Windows.Forms.Label label3;
    }
}