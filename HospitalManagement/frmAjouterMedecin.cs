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
    public partial class frmAjouterMedecin : Form
    {
        Departement departement = new Departement();
        Medecin medicin = new Medecin();

        public frmAjouterMedecin()
        {
            InitializeComponent();
        }

        public bool verif()
        {
            if (txtNomMedecin.Text == "" || txtPrenomMedecin.Text =="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmAjouterMedecin_Load(object sender, EventArgs e)
        {
            comboBxDepartement.DataSource = departement.ObtenirTousLesDepartements();

            comboBxDepartement.DisplayMember= "Departement";
            //comboBxDepartement.ValueMember = "IdDepartement";
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {

            string nom = txtNomMedecin.Text;
            string prenom = txtPrenomMedecin.Text;
            DateTime dateNaissance = DateTimePickerNaissanceMedecin.Value;
            string departement = comboBxDepartement.Text;
            //Si L,utilisater a entrer des valeurs pours les 2 premiers champs

            int dateEntree = DateTimePickerNaissanceMedecin.Value.Year;
            int anneeActuel = DateTime.Now.Year;
            if (verif())
            {
                if (((anneeActuel - dateEntree) < 20) || ((anneeActuel - dateEntree) > 75))
                {
                    MessageBox.Show("L'age du médecin doit être compris entre 20 et 75 ans.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (medicin.InsertionMedecin(nom, prenom, dateNaissance, departement))
                    {
                        MessageBox.Show("Médecin inséré avec succès.", "Insertion médecin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Échec d'insertion du médecin.", "Insertion médecin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Certains champs sont vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
