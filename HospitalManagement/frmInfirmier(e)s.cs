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
    public partial class frmInfirmier_e_s : Form
    {
        Patient patient = new Patient();
        public frmInfirmier_e_s()
        {
            InitializeComponent();
        }

        private void frmInfirmier_e_s_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tblPatients");
            RemplirDatagridView(command);
        }

        public void RemplirDatagridView(SqlCommand command)
        {

            //On rempli notre tableau de données trouvées
            dtgListePatients.DataSource = patient.ObtenirPatients(command);

        }

        private void btnRechercherChambre_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string requete;


            requete = "SELECT * FROM tblPatients WHERE CONCAT" +
          "(NomPatient,PrenomPatient,Departement)LIKE'%" + txtChambreArechercher.Text + "%'";

            command = new SqlCommand(requete);
            //Appel de la méthode pour remplir la grille
            RemplirDatagridView(command);
        }
    }
}
