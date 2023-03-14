using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace SistemaVeterinaria1.DAO
{
    internal class ConexionBD
    {
        // conexion cadena obtiene el conectionString para conectarse a la base de datos
        static readonly string conexionCadena= System.Configuration.ConfigurationManager.ConnectionStrings["VeterinariaDB"].ConnectionString;
        //conexionSql es el objeto que genera la conexion con la bdd
        protected SqlConnection conexionSql = new SqlConnection(conexionCadena);

    }
}
