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
    public partial class frmMedecins : Form
    {
        public frmMedecins(string departement)
        {
            InitializeComponent();

            labelDepartement.Text = departement;
        }

        private void btnCongePatient_Click(object sender, EventArgs e)
        {
            frmDonnerCongéPatients supp = new frmDonnerCongéPatients(labelDepartement.Text);
            supp.Show();

           
        }

        private void frmMedecins_Load(object sender, EventArgs e)
        {

        }
    }
}
