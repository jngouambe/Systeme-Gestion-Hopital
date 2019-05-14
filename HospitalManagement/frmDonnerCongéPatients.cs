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
    public partial class frmDonnerCongéPatients : Form
    {

        Patient patient = new Patient();
        public frmDonnerCongéPatients(string departement)
        {
            InitializeComponent();

            labelDepartement.Text = departement;
        }

        private void frmDonnerCongéPatients_Load(object sender, EventArgs e)
        {
            txtNombreJours.Focus();
            labelListePatients.Text = "";
            labelListePatients.Text += "Liste de patients en : " + labelDepartement.Text;

            string departement = labelDepartement.Text;

            dtgPatientsParMedecin.DataSource = patient.ObtenirTousPatientParDepartement(departement);
        }

        private void btnCongé_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreJours.Text != "" && Convert.ToInt16(txtNombreJours.Text) > 0)
                {
                    if ((MessageBox.Show("Êtes-vous sur de vouloir donné des congés à ce patient ?", "Libérer patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {

                        //Récuperons la valeur de la premiere colonne de la rangée selectionné 
                        //qui est L'id du médecin

                        try
                        {
                            int IdPatient = int.Parse(dtgPatientsParMedecin.CurrentRow.Cells[0].Value.ToString());
                            string nom = dtgPatientsParMedecin.CurrentRow.Cells[1].Value.ToString();
                            string prenom = dtgPatientsParMedecin.CurrentRow.Cells[2].Value.ToString();
                            DateTime dateNaissance = (DateTime)dtgPatientsParMedecin.CurrentRow.Cells[3].Value;
                            string departement = dtgPatientsParMedecin.CurrentRow.Cells[4].Value.ToString();
                            string assurance = dtgPatientsParMedecin.CurrentRow.Cells[5].Value.ToString();
                            string typeChambre = dtgPatientsParMedecin.CurrentRow.Cells[6].Value.ToString();
                            string louerTelevision = dtgPatientsParMedecin.CurrentRow.Cells[7].Value.ToString();
                            string louerTelephone = dtgPatientsParMedecin.CurrentRow.Cells[8].Value.ToString();
                            string NumeroLit = dtgPatientsParMedecin.CurrentRow.Cells[9].Value.ToString();
                            int nbrDeJours = Convert.ToInt16(txtNombreJours.Text);

                            //Suppression du patient de notre table
                            if (patient.DonnerCongéDuPatient(IdPatient))
                            {

                                MessageBox.Show("Le patient à quitter l'hôpital avec succès", "Libérer patient", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Libérons notre lit en l'ajoutant comme disponible dans notre table tblLits
                                patient.InsererLit(NumeroLit, departement, typeChambre);

                                int nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                                //Incrémentons le nombre de lits disponibles.
                                nombreLitsDispo += 1;


                                //MOdifier les disponibilites
                                patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                //Insertion du patient dans la tables des anciens patients
                                //pour garder une trace sur lui
                                patient.InsererAncienPatient(IdPatient, nom, prenom, dateNaissance,
                                    departement, assurance, typeChambre, louerTelevision, louerTelephone, nbrDeJours);
                            }
                            else
                            {
                                MessageBox.Show("Échec de libération du patient", "Libérer patient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (NullReferenceException)
                        {

                            MessageBox.Show("Vous ne disposez d'aucun patient ,raison pour laquelle cette opéraion de libération de patient"
                                + " est impossible.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Vous devez saisir une valeur positive dans ce champ."
                                , "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreJours.Focus();
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Vous devez saisir une valeur numérique pour ce champ."
                                 , "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreJours.Focus();
            }
           
        }
    }
}
