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
    public partial class frmRechercherPatient : Form
    {
        Patient patient = new Patient();
       
        public frmRechercherPatient()
        {
            InitializeComponent();
        }

        private void frmRechercherPatient_Load(object sender, EventArgs e)
        {
            //On appelle la méthode remplir lors de chaque chargement de notre fenetre

            SqlCommand command = new  SqlCommand("SELECT * FROM tblPatients");
            RemplirDatagridView(command);

            if (rbtnNON.Checked)
            {
                DateTimePicker1.Enabled = false;
                DateTimePicker2.Enabled = false;
            }
        }

        private void rbtnOUI_CheckedChanged(object sender, EventArgs e)
        {


            //On active nos datetimepickers
            DateTimePicker1.Enabled = true;
            DateTimePicker2.Enabled = true;
        }

        private void rbtnNON_CheckedChanged(object sender, EventArgs e)
        {
            //On déactive nos datetimepickers
            DateTimePicker1.Enabled = false;
            DateTimePicker2.Enabled = false;
        }

        public void RemplirDatagridView(SqlCommand command)
        {

            //On rempli notre tableau de données trouvées
            dtgPatients.DataSource = patient.ObtenirPatients(command);

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String requete;
            if (rbtnOUI.Checked)
            {
                string date1 = DateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = DateTimePicker2.Value.ToString("yyyy-MM-dd");



                requete = "SELECT * FROM tblPatients WHERE DateNaissance BETWEEN '" + date1 + "' AND '" + date2 + "'";

                command = new SqlCommand(requete);
                RemplirDatagridView(command);
            }
            else
            {

                 requete = "SELECT * FROM tblPatients WHERE CONCAT" +
               "(IdPatient,NomPatient,PrenomPatient,Departement,NumeroLit)LIKE'%" + txtArechercher.Text + "%'";

                command = new SqlCommand(requete);
                //Appel de la méthode pour remplir la grille
                RemplirDatagridView(command);

             //   requete = "SELECT * FROM tblPatients WHERE Genre = 'Masculin'";


              //  command = new SqlCommand(requete);
               // RemplirDatagridView(command);
            }
        }

        private void btnVoirTouslesPatients_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tblPatients");
            RemplirDatagridView(command);
        }
    }
}
