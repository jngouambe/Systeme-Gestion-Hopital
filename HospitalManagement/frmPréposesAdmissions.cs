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
    public partial class frmPréposesAdmissions : Form
    {
        public frmPréposesAdmissions()
        {
            InitializeComponent();
           
        }

        private void frmPréposesAdmissions_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAjouterPatient_Click(object sender, EventArgs e)
        {
            frmAjouterPatient ajout = new frmAjouterPatient();
            ajout.Show();
        }

        private void bntRechercherPatient_Click(object sender, EventArgs e)
        {
            frmRechercherPatient recherche = new frmRechercherPatient();
            recherche.Show();
        }
    }
}
