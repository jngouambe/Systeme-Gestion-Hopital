using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class frmLogin : Form
    {

        Ma_BaseDeDonnées maBD = new Ma_BaseDeDonnées();

        public frmLogin()
        {
            InitializeComponent();
        }

        public bool verif()
        {
            if (txtNomUtilisateur.Text =="" || txtMotPasse.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)

        {
            string nomUtilisateur = txtNomUtilisateur.Text;
            string motPasse = txtMotPasse.Text;

            if (verif())
            {
                MessageBox.Show("Vous devez remplir tous les champs", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
              
                    if (maBD.VerificationAdministrateur(nomUtilisateur, motPasse) == true)
                    {

                        frmAdministrateur admin = new frmAdministrateur();
                        admin.Show();


                    }
                    else if (maBD.VerificationPreposes(nomUtilisateur, motPasse) == true)
                    {
                        frmPréposesAdmissions preposees = new frmPréposesAdmissions();
                        preposees.Show();
                    }
                    else if (nomUtilisateur.StartsWith("NLH"))
                    {

                      if (maBD.VerificationMedecins(nomUtilisateur.Substring(3).Trim(), motPasse) == true)
                       {

                        string departement = motPasse;
                        frmMedecins medecin = new frmMedecins(departement);
                        medecin.Show();
                      }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur ou le mot de passe n'est pas valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMotPasse.Text = "";
                        txtMotPasse.Focus();
                    }

                }
                 else if (nomUtilisateur.StartsWith("infNLH"))
                 {
                    if (maBD.VerificationInfirmiers(nomUtilisateur.Substring(6).Trim(), motPasse) == true)
                    {

                        frmInfirmier_e_s infirmier = new frmInfirmier_e_s();
                        infirmier.Show();
                    }
                    else
                    {
                        MessageBox.Show("Le nom d'utilisateur ou le mot de passe n'est pas valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMotPasse.Text = "";
                        txtMotPasse.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Le nom d'utilisateur ou le mot de passe n'est pas valide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMotPasse.Text = "";
                    txtMotPasse.Focus();
                }
              
              
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desirez-vous vraiment quitter cette application ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
    }
}
