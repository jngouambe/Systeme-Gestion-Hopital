using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalManagement
{
    public class Departement
    {
        Ma_BaseDeDonnées maBD = new Ma_BaseDeDonnées();

        //  méthode pour obtenir tous les cours de notre bases de données
        public DataTable ObtenirTousLesDepartements()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM tblDepartements", maBD.getConnexion);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
