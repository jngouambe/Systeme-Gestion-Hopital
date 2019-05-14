using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalManagement
{
   public class Ma_BaseDeDonnées
    {
        //la connexion
        SqlConnection con = new SqlConnection("Data Source=MONPC;Initial Catalog=Hopital;Integrated Security=True");


        //obtenir la connexion
        public SqlConnection getConnexion
        {
            get
            {
                return con;
            }
        }


        // ouvrir la connexion
        public void OuvrirConnexion()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // fermer la connexion
        public void FermerConnexion()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }


        public bool VerificationAdministrateur(string nomUtilisateur, string motPassse)
        {

            
            SqlCommand command = new SqlCommand("SELECT * FROM tblAdministrateurs WHERE  NomUtilisateur = @Nom AND " +
                "MotPasse=@motPasse ", getConnexion);

            command.Parameters.Add("@Nom", SqlDbType.VarChar).Value = nomUtilisateur;
            command.Parameters.Add("@motPasse", SqlDbType.VarChar).Value = motPassse;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count <= 0))
            {
                // si cet administrateur existe déjà
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool VerificationPreposes(string nomUtilisateur, string motPassse)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM tblPreposesAdmissions WHERE NomUtilisateur = @Nom AND " +
                "MotPasse=@motPasse ", getConnexion);

            command.Parameters.Add("@Nom", SqlDbType.VarChar).Value = nomUtilisateur;
            command.Parameters.Add("@motPasse", SqlDbType.VarChar).Value = motPassse;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count <= 0))
            {
                // si ce préposé existe déjà
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool VerificationMedecins(string nomUtilisateur, string motPassse)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM tblMedecins WHERE  Departement = @motPasse AND "+
                "Nom = @nom", getConnexion);


            command.Parameters.Add("@nom", SqlDbType.VarChar).Value = nomUtilisateur;
            command.Parameters.Add("@motPasse", SqlDbType.VarChar).Value = motPassse;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count <= 0))
            {
                // si ce médecin existe déjà
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool VerificationInfirmiers(string nomUtilisateur, string motPassse)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM tblInfirmiers WHERE Prenom = @motPasse AND " +
                "Nom = @nom", getConnexion);


            command.Parameters.Add("@nom", SqlDbType.VarChar).Value = nomUtilisateur;
            command.Parameters.Add("@motPasse", SqlDbType.VarChar).Value = motPassse;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count <= 0))
            {
                // si cet infirmier existe déjà
                return false;
            }
            else
            {
                return true;
            }

        }


    }
}
