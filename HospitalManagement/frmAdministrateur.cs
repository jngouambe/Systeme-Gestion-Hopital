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
    public partial class frmAdministrateur : Form
    {
        public frmAdministrateur()
        {
            InitializeComponent();

        }

        private void frmAdministrateur_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {
            frmAjouterMedecin ajout = new frmAjouterMedecin();
            ajout.Show();
        }

        private void btnSupprimerMedecin_Click(object sender, EventArgs e)
        {
            frmSupprimerMedecin supp = new frmSupprimerMedecin();
            supp.Show();
        }

        private void btnRapportFactures_Click(object sender, EventArgs e)
        {
            frmRapportFactures rapport = new frmRapportFactures();
            rapport.Show();
        }
    }
}
