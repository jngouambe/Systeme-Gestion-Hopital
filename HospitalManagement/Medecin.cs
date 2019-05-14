using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalManagement
{
   public  class Medecin
    {
        Ma_BaseDeDonnées maBD = new Ma_BaseDeDonnées();

        //  méthode pour inserer un nouveau cours
        public bool InsertionMedecin(string nomMedecin, string prenom,DateTime Datenaissance, string departement)
        {



            SqlCommand command = new SqlCommand("INSERT INTO tblMedecins(Nom,Prenom,DateNaissance,Departement)" +
                "VALUES (@Nom,@Prenom,@DateNaissance,@dep)", maBD.getConnexion);

            command.Parameters.Add("@Nom", SqlDbType.VarChar).Value = nomMedecin;
            command.Parameters.Add("@Prenom", SqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@DateNaissance", SqlDbType.DateTime).Value = Datenaissance;
            command.Parameters.Add("@dep", SqlDbType.VarChar).Value = departement;

            maBD.OuvrirConnexion();


            int ligne = command.ExecuteNonQuery();

            if ((ligne != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
;
        }

        //Suppression de médecin
        public bool SupprimerMedecins(int IdMedecin)
        {

            SqlCommand command = new SqlCommand("DELETE FROM tblMedecins WHERE IdMedecin = @ID", maBD.getConnexion);

            command.Parameters.Add("@ID", SqlDbType.Int).Value = IdMedecin;

            maBD.OuvrirConnexion();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Obtenir tous les médecins confondus
        public DataTable ObtenirTousLesMedecins()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM tblMedecins", maBD.getConnexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable ObtenirTousLesMedecinsParDepartement(string departement)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM tblMedecins WHERE Departement = '"+departement+"'", maBD.getConnexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }



        //  Méthode pour exécuter la requête de comptage
        public string CalculDuNombreEnregistrement(string requete)
        {
            SqlCommand command = new SqlCommand(requete, maBD.getConnexion);


            maBD.OuvrirConnexion();


            string compteur = command.ExecuteScalar().ToString();

            maBD.FermerConnexion();

            return compteur;
        }

        public string TotalMedecinsParDepartement(string departement)
        {
            return CalculDuNombreEnregistrement("SELECT COUNT(*) FROM tblMedecins WHERE Departement ='"+departement+"' ");
        }

        public string TotalMedecins()
        {
            return CalculDuNombreEnregistrement("SELECT COUNT(*) FROM tblMedecins");
        }

    }
}
