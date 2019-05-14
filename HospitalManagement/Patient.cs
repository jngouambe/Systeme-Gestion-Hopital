using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace HospitalManagement
{
   public  class Patient
    {

        Ma_BaseDeDonnées maBD = new Ma_BaseDeDonnées();

        //Méthode ajouté patient
        public bool InsererPatient(string nom,string prenom,DateTime dateNaissance, string departement,
            string assurance , string typeChambre, string LouerTelevision,string LouerTelephone ,string numeroLit)
        {
            SqlCommand command = new SqlCommand("INSERT INTO tblPatients"+
                "(NomPatient, PrenomPatient, DateNaissance, Departement,AssurancePrivee,TypeChambre,"+
                "LocationTelevision,LocationTelephone,NumeroLit) " +
                "VALUES (@nom,@prenom,@dateNaissance ,@departement,@assurance,@typeChambre,@LouerTelevision"+
                ",@LouerTelephone,@numeroLit)", maBD.getConnexion);

            command.Parameters.Add("@nom", SqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", SqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@dateNaissance", SqlDbType.DateTime).Value = dateNaissance;
            command.Parameters.Add("@departement", SqlDbType.VarChar).Value = departement;
            command.Parameters.Add("@assurance", SqlDbType.VarChar).Value = assurance;
            command.Parameters.Add("@typeChambre", SqlDbType.VarChar).Value = typeChambre;
            command.Parameters.Add("@LouerTelevision", SqlDbType.VarChar).Value = LouerTelevision;
            command.Parameters.Add("@LouerTelephone", SqlDbType.VarChar).Value = LouerTelephone;
            command.Parameters.Add("@numeroLit", SqlDbType.VarChar).Value = numeroLit;


            maBD.OuvrirConnexion();

            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Méthode ajouté patient
        public bool InsererAncienPatient(int idPatient,string nom, string prenom, DateTime dateNaissance, string departement,
            string assurance, string typeChambre, string LouerTelevision, string LouerTelephone,int nbrDeJours)
        {
            SqlCommand command = new SqlCommand("INSERT INTO tblAnciensPatients" +
                "(IdPatient,NomPatient, PrenomPatient, DateNaissance, Departement,AssurancePrivee,TypeChambre"+
                ",LocationTelevision,LocationTelephone,NombresDeJours) " +
                "VALUES (@idPatient,@nom,@prenom,@dateNaissance ,@departement,@assurance,@typeChambre,"+
                "@LouerTelevision,@LouerTelephone,@nbrDeJours)", maBD.getConnexion);

            command.Parameters.Add("@idPatient", SqlDbType.Int).Value = idPatient;
            command.Parameters.Add("@nom", SqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", SqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@dateNaissance", SqlDbType.DateTime).Value = dateNaissance;
            command.Parameters.Add("@departement", SqlDbType.VarChar).Value = departement;
            command.Parameters.Add("@assurance", SqlDbType.VarChar).Value = assurance;
            command.Parameters.Add("@typeChambre", SqlDbType.VarChar).Value = typeChambre;
            command.Parameters.Add("@LouerTelevision", SqlDbType.VarChar).Value = LouerTelevision;
            command.Parameters.Add("@LouerTelephone", SqlDbType.VarChar).Value = LouerTelephone;
            command.Parameters.Add("@nbrDeJours", SqlDbType.Int).Value = nbrDeJours;


            maBD.OuvrirConnexion();

            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //Obtenir tous les type de chambre confondus
        public DataTable ObtenirTypeChambre()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM tblChambres", maBD.getConnexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        //Obtenir tous les médecins confondus
        public string  NombreLitDipo(string departement, string typeChambre)
        {

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM tblDisponibilites WHERE " +
               " Departement = '" + departement + "' AND  TypeChambre = '" + typeChambre + "'", maBD.getConnexion);

                maBD.OuvrirConnexion();

                string nombreLits = command.ExecuteScalar().ToString();

                return nombreLits;
            }
            catch (NullReferenceException)
            {
                throw new Exception(" Erreur dans le choix du département ou du type de chambre.");
               
            }

           
        }

        public bool SupprimerLits(string numeroLit, string typeChambre)
        {

            SqlCommand command = new SqlCommand("DELETE FROM tblLits WHERE NumeroLit = @numeroLit "+
                "AND TypeChambre = @typeChambre", maBD.getConnexion);

            command.Parameters.Add("@numeroLit", SqlDbType.VarChar).Value = numeroLit;
            command.Parameters.Add("@typeChambre", SqlDbType.VarChar).Value = typeChambre;

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

        }

        //Méthode pour inserer un lit
        public bool InsererLit(string numeroLit, string departement,string typeChambre)
        {

            SqlCommand command = new SqlCommand("INSERT INTO tblLits" +
                   "(NumeroLit,Departement,TypeChambre)" +
                   "VALUES (@NumeroLit,@Departement,@TypeChambre)", maBD.getConnexion);

            command.Parameters.Add("@NumeroLit", SqlDbType.VarChar).Value = numeroLit;
            command.Parameters.Add("@Departement", SqlDbType.VarChar).Value = departement;
            command.Parameters.Add("@TypeChambre", SqlDbType.VarChar).Value = typeChambre;


            maBD.OuvrirConnexion();

            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // méthode pour verifier si le numéro du lit existe  dans notre base de données
        public bool VerificationNumeroLit(string departement, string typeChambre)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM tblLits WHERE Departement = @departement AND " +
                " TypeChambre = @typeChambre ", maBD.getConnexion);

            command.Parameters.Add("@departement", SqlDbType.VarChar).Value = departement;
            command.Parameters.Add("@typeChambre", SqlDbType.VarChar).Value = typeChambre;
            //  command.Parameters.Add("@Id", SqlDbType.Int).Value = IdCours;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                // si ce lit est déjà pris
                return true;
            }
            else
            {
                return false;
            }
        }

        // méthode pour verifier si le type dechambre existe  dans notre base de données
        public bool VerificationTypeChambre(string typeChambre)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM tblChambres WHERE TypeChambre = @typeChambre", maBD.getConnexion);

            command.Parameters.Add("@typeChambre", SqlDbType.VarChar).Value = typeChambre;

            //  command.Parameters.Add("@Id", SqlDbType.Int).Value = IdCours;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                // si ce type existe déjà
                return true;
            }
            else
            {
                return false;
            }

        }
             // méthode pour verifier si le type dechambre existe  dans notre base de données
        public bool VerificationDepartement(string departement)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM tblDepartements WHERE Departement = @departement", maBD.getConnexion);

            command.Parameters.Add("@departement", SqlDbType.VarChar).Value = departement;

            //  command.Parameters.Add("@Id", SqlDbType.Int).Value = IdCours;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                // si ce type existe déjà
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ModifierDisponibites(int nombreLits,string departement,string typeChambre)
        {
            SqlCommand command = new SqlCommand("UPDATE tblDisponibilites  SET " +
               "NombreLits = @nombreLits , Departement =@departement ,  TypeChambre =@typeChambre "+
               "WHERE Departement = @departement AND TypeChambre =@typeChambre", maBD.getConnexion);

            

            command.Parameters.Add("@nombreLits", SqlDbType.Int).Value = nombreLits;
            command.Parameters.Add("@departement", SqlDbType.VarChar).Value = departement;
            command.Parameters.Add("@typeChambre", SqlDbType.VarChar).Value = typeChambre;


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

        }

        public double FraisLocationTelevision(int nombreJours)
        {
            const double montantLocationTelevision = 42.5;

            double montant = nombreJours * montantLocationTelevision;
            return montant;
        }

        //
        public double FraisLocationTelephone(int nombreJours)
        {
            const double montantLocationTelephone = 7.5;

            double montant = nombreJours * montantLocationTelephone;
            return montant;
        }
        //
        public double FraisLocationtChambreSemiPrivee(string typeChambre ,int nombreJours)
        {
            const double montantChambreSemiPrivee = 267;

            typeChambre = "semi-privée";

            double montant = nombreJours * montantChambreSemiPrivee;
            return montant;

        }

        //
        public double FraisLocationtChambrePrivee(string typeChambre, int nombreJours)
        {
            const double montantChambrePrivee = 571;
            typeChambre = "privée";

            double montant = nombreJours * montantChambrePrivee;
            return montant;

        }

        //
        public DataTable CombinaisonInfosSurPatients(int departement)
        {

            //command.Connection = maBD.getConnexion;
            //command.CommandText = ("SELECT tblNotes.Id_Etudiant, tblEtudiants.Nom, tblEtudiants.Prenom, tblNotes.Id_Cours," +
            //    "tblCours.Nom_Cours, tblNotes.Note_Etudiant FROM tblEtudiants INNER JOIN tblNotes on " +
            //"tblEtudiants.IdEtudiant = tblNotes.Id_Etudiant INNER JOIN tblCours on tblNotes.Id_Cours =tblCours.Id" +
            //" WHERE tblNotes.Id_Cours = " + Id_Cours);

            SqlCommand command = new SqlCommand();

            command.Connection = maBD.getConnexion;
            //command.CommandText = ("SELECT tblPatients.IdPatient, tblPatients.NomPatient, tblPatients.PrenomPatient,"+
            //    "tblDepartements.IdDepartement" +
            //    "FROM tblPatients INNER JOIN tblDepartements on " +
            //"tblPatients.Departement = tblDepartements.Departement "+
            //" WHERE tblDepartements.Departement = " +departement);


            command.CommandText = ("SELECT tblPatients.IdPatient, tblPatients.NomPatient, tblPatients.PrenomPatient," +
                "tblPatients.AssurancePrivee" +
                "FROM tblPatients INNER JOIN tblDepartements ON tblPatients.Departement = tblDepartements.Departement"+
                "WHERE tblDepartements.IdDepartement = '"+departement+"'");

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        //  méthode pour obtenir tous les lits de notre bases de données
        public DataTable ObtenirTousLesLits(string departement,string typeChambre)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM tblLits WHERE Departement = '"+departement+"' "+
                " AND TypeChambre = '"+typeChambre+"'", maBD.getConnexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        //Obtenir les patients
        public DataTable ObtenirPatients(SqlCommand command)
        {
            command.Connection = maBD.getConnexion;
            SqlDataAdapter adapter = new SqlDataAdapter(command);


            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        ////libération du patient
        public bool DonnerCongéDuPatient(int IdPatient)
        {

            SqlCommand command = new SqlCommand("DELETE FROM tblPatients WHERE IdPatient = @ID", maBD.getConnexion);

            command.Parameters.Add("@ID", SqlDbType.Int).Value = IdPatient;

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

        }

        

        //  //Obtenir tous les médecins confondus
        public DataTable ObtenirTousPatientParDepartement(string departement)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM tblPatients"+
                " WHERE Departement = '"+departement+"'", maBD.getConnexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

    }
}
