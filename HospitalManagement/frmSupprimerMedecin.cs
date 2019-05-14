using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class frmSupprimerMedecin : Form
    {
        Departement departement = new Departement();

        Medecin medecin = new Medecin();

        public frmSupprimerMedecin()
        {
            InitializeComponent();
           /// labelListesDepart.Text.;
        }

        private void frmSupprimerMedecin_Load(object sender, EventArgs e)
        {
            comboBxDepartements.DataSource = departement.ObtenirTousLesDepartements();
            comboBxDepartements.DisplayMember = "Departement";
            comboBxDepartements.ValueMember = "IdDepartement";

            //Remplissons notres datagridvieew de nos médecins
            dtgListeMedecins.DataSource = medecin.ObtenirTousLesMedecins();
            dtgListeMedecins.ReadOnly = true;
            
            // dtgListeMedecins.DataSource = etudiant.getEtudiants(command);
            dtgListeMedecins.AllowUserToAddRows = false;

            lblNombreMedecin.Text += " "+ medecin.TotalMedecins();

        }

        private void btnRechercherChambre_Click(object sender, EventArgs e)
        {
            // labelListesDepart.Text += " "+ comboBxDepartements.Text;

            dtgListeMedecins.DataSource = medecin.ObtenirTousLesMedecinsParDepartement(comboBxDepartements.Text);


            labelListesDepart.Text = "";
            labelListesDepart.Text += "Liste des médecins du département de : " + comboBxDepartements.Text;
            // labelListesDepart.Text.Replace(labelListesDepart.Text, labelListesDepart.Text += " " + comboBxDepartements.Text);
            lblNombreMedecin.Text = "";
           lblNombreMedecin.Text += "Nombre total de medécins : " + medecin.TotalMedecinsParDepartement(comboBxDepartements.Text.Trim());

            
        }

        private void btnSupprimerMedecin_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Êtes-vous sur de vouloir supprimer ce médecin ?", "Supprimer médecin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                //Récuperons la valeur de la premiere colonne de la rangée selectionné 
                //qui est L'id du médecin

                try
                {
                    int IdMedecin = int.Parse(dtgListeMedecins.CurrentRow.Cells[0].Value.ToString());

                    if (medecin.SupprimerMedecins(IdMedecin))
                    {
                        MessageBox.Show("Médecin supprimer avec succès", "Supprimer médecin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Échec de suppression de médecin", "Supprimer médecin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("Vous ne disposez d'aucun médecin ,raison pour laquelle cette opéraion de suppression"
                        + " est impossible.","Attntion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

               

            }
        }

        private void btnVoirTousLesMedecins_Click(object sender, EventArgs e)
        {
            dtgListeMedecins.DataSource = medecin.ObtenirTousLesMedecins();

            labelListesDepart.Text = "";
            labelListesDepart.Text += "Liste des médecins de tous les départements";

            lblNombreMedecin.Text = "";
            lblNombreMedecin.Text += "Nombre total de medécins : " + medecin.TotalMedecins();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
