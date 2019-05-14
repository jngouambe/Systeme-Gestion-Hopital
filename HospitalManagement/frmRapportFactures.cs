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
using System.IO;

namespace HospitalManagement
{
    public partial class frmRapportFactures : Form
    {

        Departement departement = new Departement();
        Patient patient = new Patient();
        double montantLocationTelephone;
        double montantLocationTelevision;
        double fraisChambre;

        public frmRapportFactures()
        {
            InitializeComponent();
        }

        private void frmRapportFactures_Load(object sender, EventArgs e)
        {
            listBoxDepartements.DataSource = departement.ObtenirTousLesDepartements();
            listBoxDepartements.DisplayMember = "Departement";
            listBoxDepartements.ValueMember = "Departement";

          //  dtgPatients.DataSource = patient.CombinaisonInfosSurPatients(int.Parse(listBoxDepartements.SelectedValue.ToString()));
        }

        private void listBoxDepartements_Click(object sender, EventArgs e)
        {
            ///Remplissons notre data grid avec les infos sur le patient garce au id du departemnt 
            ///passé en parametre a notre methode CombinaisonInfosSurPatients() 
            //dtgPatients.DataSource = patient.CombinaisonInfosSurPatients(int.Parse(listBoxDepartements.SelectedValue.ToString()));
            SqlCommand command;
            String requete;
            string departement = listBoxDepartements.SelectedValue.ToString();
            //

            requete = "SELECT IdPatient,NomPatient, PrenomPatient,AssurancePrivee,TypeChambre,LocationTelevision,LocationTelephone,"+
                "NombresDeJours FROM tblAnciensPatients WHERE" +
                " Departement = '"+ departement + "'";

                command = new SqlCommand(requete);
                RemplirDatagridView(command);

            }

        public void RemplirDatagridView(SqlCommand command)
        {

            //On rempli notre tableau de données trouvées
            dtgPatients.DataSource = patient.ObtenirPatients(command);

        }

        private void btnImprimerRapports_Click(object sender, EventArgs e)
        {

            try
            {
                int IdPatient = int.Parse(dtgPatients.CurrentRow.Cells[0].Value.ToString());
                string nom = dtgPatients.CurrentRow.Cells[1].Value.ToString();
                string prenom = dtgPatients.CurrentRow.Cells[2].Value.ToString();
                string assurance = dtgPatients.CurrentRow.Cells[3].Value.ToString();
                string typeChambre = dtgPatients.CurrentRow.Cells[4].Value.ToString();
                string louerTelevision = dtgPatients.CurrentRow.Cells[5].Value.ToString();
                string louerTelephone = dtgPatients.CurrentRow.Cells[6].Value.ToString();
                int nbrDeJours = Convert.ToInt16(dtgPatients.CurrentRow.Cells[7].Value.ToString());

                string nomFichier = "Patients.txt";
                StreamWriter ecrit = new StreamWriter(nomFichier);


                DateTime date = DateTime.Now;
                if (!File.Exists(nomFichier))
                {
                    File.Create(nomFichier);
                }
                else
                {
                    ecrit.WriteLine();
                    ecrit.WriteLine("                                                                                        " + date);
                    ecrit.WriteLine();
                    ecrit.WriteLine("  Nom complet du patient : " + prenom + " " + nom);
                    ecrit.WriteLine();
                    ecrit.WriteLine("  Nombres de jours passé à l'hôpital : " + nbrDeJours + " jour(s).");
                    ecrit.WriteLine();

                    if (typeChambre == "semi-privée")
                    {
                        ecrit.WriteLine("  Type de chambre : " + typeChambre.ToUpper() + ".");
                        ecrit.WriteLine();
                        fraisChambre = patient.FraisLocationtChambreSemiPrivee(typeChambre, nbrDeJours);
                        ecrit.WriteLine("  Frais d'usage de la chambre : " + fraisChambre + "$.");

                        if (louerTelevision == "OUI")
                        {
                            ecrit.WriteLine();
                            montantLocationTelevision = patient.FraisLocationTelevision(nbrDeJours);
                            ecrit.WriteLine("  Frais de location de télévision : " + montantLocationTelevision + "$.");
                        }
                        else if (louerTelevision == "NON")
                        {
                            ecrit.WriteLine();
                            //on met 0 dollar par défaut
                            ecrit.WriteLine("  Frais de location de télévision : " + 0.00 + "$.");

                        }


                        if (louerTelephone == "OUI")
                        {
                            ecrit.WriteLine();
                            montantLocationTelephone = patient.FraisLocationTelephone(nbrDeJours);
                            ecrit.WriteLine("  Frais de location de télephone : " + montantLocationTelephone + "$.");
                        }
                        else if (louerTelephone == "NON")
                        {
                            ecrit.WriteLine();
                            //on met 0 dollar par défaut
                            ecrit.WriteLine("  Frais de location de télephone : " + 0.00 + "$.");
                        }

                    }
                    else if (typeChambre == "privée")
                    {
                        ecrit.WriteLine("  Type de chambre : " + typeChambre.ToUpper() + ".");
                        ecrit.WriteLine();
                        fraisChambre = patient.FraisLocationtChambrePrivee(typeChambre, nbrDeJours);
                        ecrit.WriteLine("  Frais d'usage de la chambre : " + fraisChambre + "$.");

                        if (louerTelevision == "OUI")
                        {
                            ecrit.WriteLine();
                            montantLocationTelevision = patient.FraisLocationTelevision(nbrDeJours);
                            ecrit.WriteLine("  Frais de location de télévision : " + montantLocationTelevision + "$.");
                        }
                        else if (louerTelevision == "NON")
                        {
                            ecrit.WriteLine();
                            //on met 0 dollar par défaut
                            ecrit.WriteLine("  Frais de location de télévision : " + 0.00 + "$.");
                        }


                        if (louerTelephone == "OUI")
                        {
                            ecrit.WriteLine();
                            montantLocationTelephone = patient.FraisLocationTelephone(nbrDeJours);
                            ecrit.WriteLine("  Frais de location de télephone : " + montantLocationTelephone + "$.");
                        }
                        else if (louerTelephone == "NON")
                        {
                            ecrit.WriteLine();
                            //on met 0 dollar par défaut
                            ecrit.WriteLine("  Frais de location de télephone : " + 0.00 + "$.");
                        }


                    }

                    ecrit.WriteLine();
                    //somme des trois montant;
                    double somme = montantLocationTelephone + montantLocationTelevision + fraisChambre;
                    //  double montantLocationTelephone = patient.FraisLocationTelephone(nbrDeJours);
                    ecrit.WriteLine("  Montant total à payer : " + somme + "$.");

                    ecrit.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
                }

                ecrit.Close();
                MessageBox.Show("Données imprimées avec succès!");
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Vous ne disposez d'aucune information pour le moment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
