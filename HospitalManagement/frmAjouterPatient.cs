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
    public partial class frmAjouterPatient : Form
    {
        Patient patient = new Patient();
        Departement departement = new Departement();

       

        public frmAjouterPatient()
        {
            InitializeComponent();
        }

        public bool verif()
        {
            if(txtNomMedecin.Text  =="" ||
                txtPrenomMedecin.Text == "" ||
                comboBxNumeroLit.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAjouterPatient_Click(object sender, EventArgs e)
        {
            string nom = txtNomMedecin.Text;
            string prenom = txtPrenomMedecin.Text;
            DateTime date = DateTimePickerNaissanceMedecin.Value;
            string typeChambre = comboBxTypeChambre.Text;
            string departement = comboBxDepartement.Text;
            string Assurance = "NON";
            string LouerTelevision = "NON";
            string LouerTelephone = "NON";
            string numeroLit = comboBxNumeroLit.Text;

            int nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));


            //Selection de l'option d'assurance privée
            if (rBtnNONAssurance.Checked == true)
            {
                Assurance = "NON";
            }
            else if(rBtnOUIAssurance.Checked ==true)
            {
                Assurance = "OUI";
            }

            //selection de l'option Location de television
            if (rBtnLouerTelevisionNON.Checked == true)
            {
                LouerTelevision = "NON";
            }
            else if (rBtnLouerTelevisionOUI.Checked == true)
            {
                LouerTelevision = "OUI";
            }

            /// //selection de l'option Location de telephone
            if (rBtnLocationTelephoneNON.Checked == true)
            {
                LouerTelephone = "NON";
            }
            else if (rBtnLocationTelephoneNON.Checked == true)
            {
                LouerTelephone = "OUI";
            }


            //Verifions si nos champs sont vides 
            //Daans le cas contraire 
            if (verif())
            {

                //Les patients agés de 16 ans ou mons qui ne sont pas admis pour une chirurgie
                //sont automatiquent dirigés vers les chambres du département de pédiatrie
                //lorsqun lit correspondant au type est dispo 
                if (nombreLitsDispo > 0)
                {

                    int dateNaisssancePatient = DateTimePickerNaissanceMedecin.Value.Year;
                    int dateActuel = DateTime.Now.Year;


                    if ((dateActuel - dateNaisssancePatient) <= 16)
                    {
                        if (typeChambre != "Chirurgie")
                        {
                            typeChambre = "Pédiatrie";
                            nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                            if (nombreLitsDispo > 0)
                            {
                                if (patient.VerificationNumeroLit(departement, typeChambre))
                                {
                                    if (patient.VerificationTypeChambre(typeChambre))
                                    {
                                        if (patient.VerificationDepartement(departement))
                                        {
                                            if (nombreLitsDispo > 0)
                                            {
                                                if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                                       typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                                {


                                                    nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));



                                                    //
                                                    MessageBox.Show("Insertion du patient avec succès.", "Information",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    numeroLit = comboBxNumeroLit.Text;
                                                    patient.SupprimerLits(numeroLit, typeChambre);

                                                    //On diminiue les lits diponibles a chaque ajout
                                                    nombreLitsDispo -= 1;

                                                    //Modification de notre table tblDisponibilites
                                                    patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Échec d'insertion du patient.", "Information",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                                 "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            
                        }

                    }
                }
                else
                {
                    comboBxTypeChambre.Focus();
                    typeChambre = comboBxTypeChambre.Text;

                    if (nombreLitsDispo <= 0)
                    {
                        MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //**************************************************
                //6 eme point du projet
                if (Assurance == "NON")
                {

                    if (typeChambre == "standard")
                    {
                        
                            nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                        if (nombreLitsDispo > 0)
                        {
                            if (patient.VerificationNumeroLit(departement, typeChambre))
                            {
                                if (patient.VerificationTypeChambre(typeChambre))
                                {
                                    if (patient.VerificationDepartement(departement))
                                    {
                                        if (nombreLitsDispo > 0)
                                        {
                                            if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                                   typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                            {


                                                nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));



                                                //
                                                MessageBox.Show("Insertion du patient avec succès.", "Information",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                numeroLit = comboBxNumeroLit.Text;
                                                patient.SupprimerLits(numeroLit, typeChambre);

                                                //On diminiue les lits diponibles a chaque ajout
                                                nombreLitsDispo -= 1;

                                                //Modification de notre table tblDisponibilites
                                                patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Échec d'insertion du patient.", "Information",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                             "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                       else if ((nombreLitsDispo <= 0) )
                        {
                            if (typeChambre == "privée" || typeChambre == "semi-privée")
                            {
                                if (typeChambre=="privée")
                                {
                                    nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                                    if (nombreLitsDispo <= 0)
                                    {
                                        MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de "+
                                            "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));
                                        //insertion sans frais supp
                                        //AJout avec succes
                                if (patient.VerificationNumeroLit(departement, typeChambre))
                    {
                        if (patient.VerificationTypeChambre(typeChambre))
                        {
                            if (patient.VerificationDepartement(departement))
                            {
                                if (nombreLitsDispo > 0)
                                {
                                    if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                           typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                    {


                                        nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));



                                        //
                                        MessageBox.Show("Insertion du patient avec succès.", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        numeroLit = comboBxNumeroLit.Text;
                                        patient.SupprimerLits(numeroLit, typeChambre);

                                        //On diminiue les lits diponibles a chaque ajout
                                        nombreLitsDispo -= 1;

                                        //Modification de notre table tblDisponibilites
                                        patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Échec d'insertion du patient.", "Information",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                     "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                                    }
                                }
                                else if(typeChambre == "semi-privée")
                                {
                                    nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                                  
                                    if (nombreLitsDispo <= 0)
                                    {
                                        MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                            "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        //insertion sans frais supp
                                        //AJout avec succes
                                        if (patient.VerificationNumeroLit(departement, typeChambre))
                                        {
                                            if (patient.VerificationTypeChambre(typeChambre))
                                            {
                                                if (patient.VerificationDepartement(departement))
                                                {
                                                    if (nombreLitsDispo > 0)
                                                    {
                                                        if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                                               typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                                        {


                                                            nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));



                                                            //
                                                            MessageBox.Show("Insertion du patient avec succès.", "Information",
                                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                            numeroLit = comboBxNumeroLit.Text;
                                                            patient.SupprimerLits(numeroLit, typeChambre);

                                                            //On diminiue les lits diponibles a chaque ajout
                                                            nombreLitsDispo -= 1;

                                                            //Modification de notre table tblDisponibilites
                                                            patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Échec d'insertion du patient.", "Information",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                                         "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                        }
                    }
                   
                }
               

                //*******************************************
                //8 eme point du projet
                if (departement == "Chirurgie")
                {
                   

                    nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                    if (nombreLitsDispo <=0)
                    {
                        MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                          "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        comboBxTypeChambre.Focus();
                        typeChambre = comboBxTypeChambre.Text;
                        nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                        if (nombreLitsDispo <= 0)
                        {
                            MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                         "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //insertion sans frais sup
                            if (patient.VerificationNumeroLit(departement, typeChambre))
                            {
                                if (patient.VerificationTypeChambre(typeChambre))
                                {
                                    if (patient.VerificationDepartement(departement))
                                    {
                                        if (nombreLitsDispo > 0)
                                        {
                                            if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                                   typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                            {


                                                nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));



                                                //
                                                MessageBox.Show("Insertion du patient avec succès.", "Information",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                numeroLit = comboBxNumeroLit.Text;
                                                patient.SupprimerLits(numeroLit, typeChambre);

                                                //On diminiue les lits diponibles a chaque ajout
                                                nombreLitsDispo -= 1;

                                                //Modification de notre table tblDisponibilites
                                                patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Échec d'insertion du patient.", "Information",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                             "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
               
                ///*****************************************
                ///7 eme point du projet
                ///
                if (Assurance == "NON")
                {
                    nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, "standard"));

                    if (nombreLitsDispo > 0)
                    {
                        if (typeChambre == "privée" || typeChambre == "semi-privée")
                        {
                            nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                            if (patient.VerificationNumeroLit(departement, typeChambre))
                            {
                                if (patient.VerificationTypeChambre(typeChambre))
                                {
                                    if (patient.VerificationDepartement(departement))
                                    {
                                        if (nombreLitsDispo > 0)
                                        {
                                            if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                                   typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                            {


                                                nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                                                MessageBox.Show("Vous serez chargé de frais supplémentaires.", "Attention",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                //
                                                MessageBox.Show("Insertion du patient avec succès.", "Information",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                numeroLit = comboBxNumeroLit.Text;
                                                patient.SupprimerLits(numeroLit, typeChambre);

                                                //On diminiue les lits diponibles a chaque ajout
                                                nombreLitsDispo -= 1;

                                                //Modification de notre table tblDisponibilites
                                                patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                            }
                                            else
                                            {
                                                MessageBox.Show("Échec d'insertion du patient.", "Information",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                             "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

  
                    }

                }
                else if(Assurance == "OUI")
                {
                    if (patient.VerificationNumeroLit(departement, typeChambre))
                    {
                        if (patient.VerificationTypeChambre(typeChambre))
                        {
                            if (patient.VerificationDepartement(departement))
                            {
                                if (nombreLitsDispo > 0)
                                {
                                    if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                           typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                    {


                                        nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));



                                        //
                                        MessageBox.Show("Insertion du patient avec succès.", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        numeroLit = comboBxNumeroLit.Text;
                                        patient.SupprimerLits(numeroLit, typeChambre);

                                        //On diminiue les lits diponibles a chaque ajout
                                        nombreLitsDispo -= 1;

                                        //Modification de notre table tblDisponibilites
                                        patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Échec d'insertion du patient.", "Information",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                     "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               else if (Assurance == "OUI" || Assurance == "NON")
                {

                    nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));

                    if (patient.VerificationNumeroLit(departement, typeChambre))
                    {
                        if (patient.VerificationTypeChambre(typeChambre))
                        {
                            if (patient.VerificationDepartement(departement))
                            {
                                if (nombreLitsDispo > 0)
                                {
                                    if (patient.InsererPatient(nom, prenom, date, departement, Assurance,
                                           typeChambre, LouerTelevision, LouerTelephone, numeroLit))
                                    {


                                        nombreLitsDispo = Convert.ToInt16(patient.NombreLitDipo(departement, typeChambre));



                                        //
                                        MessageBox.Show("Insertion du patient avec succès.", "Information",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        numeroLit = comboBxNumeroLit.Text;
                                        patient.SupprimerLits(numeroLit, typeChambre);

                                        //On diminiue les lits diponibles a chaque ajout
                                        nombreLitsDispo -= 1;

                                        //Modification de notre table tblDisponibilites
                                        patient.ModifierDisponibites(nombreLitsDispo, departement, typeChambre);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Échec d'insertion du patient.", "Information",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Impossible d'ajouter de patients car nous n'avons plus de " +
                                                     "lits disponibles.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ce département n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ce type de chambre n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce numéro de lit n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Certains champs sont vides.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBxTypeChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAjouterPatient_Load(object sender, EventArgs e)
        {
            comboBxTypeChambre.DataSource = patient.ObtenirTypeChambre();
            comboBxTypeChambre.DisplayMember = "TypeChambre";

            comboBxDepartement.DataSource = departement.ObtenirTousLesDepartements();
            comboBxDepartement.DisplayMember = "Departement";

            int nombre = Convert.ToInt16(patient.NombreLitDipo(comboBxDepartement.Text,comboBxTypeChambre.Text));

        }

        private void comboBxTypeChambre_Click(object sender, EventArgs e)
        {
            lblNombreLitDispoParDepartement.Text = "";
            lblNombreLitDispoParDepartement.Text += "Nombre(s) de lit(s) disponible(s)  pour : " + comboBxDepartement.Text;



            string nombreLits = patient.NombreLitDipo(comboBxDepartement.Text,comboBxTypeChambre.Text);
            //dataGridNombreLits.
            //  string nombreLits = patient.NombreLitDipo(comboBxDepartement.Text, comboBxTypeChambre.Text);
            labelLitDispo.Text = "";
            labelLitDispo.Text +="* "+ nombreLits + " Lit(s) disponible(s)";

            comboBxNumeroLit.DataSource = patient.ObtenirTousLesLits(comboBxDepartement.Text, comboBxTypeChambre.Text);
            comboBxNumeroLit.DisplayMember = "NumeroLit";
        }
    }
}
