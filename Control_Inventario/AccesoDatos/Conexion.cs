using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//generamo el puente al servidor sqlserver
using System.Data.SqlClient;

//agregamos la configuration  (referencia)
using System.Configuration;



namespace AccesoDatos
{
    public class Conexion
    {
        //***************** configuration  para app config (cadena de conexion)***************************************************
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString.ToString());




    }
}
