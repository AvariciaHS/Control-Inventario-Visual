using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


using Entidad;

namespace AccesoDatos
{
    public class LOGIN_DAO
    {

        Conexion con = new Conexion ();

        public DataTable D_Login(Entidad.Login obje)
        {

            SqlCommand cmd = new SqlCommand("sp_login", con.con);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@usuario", obje.usuario);

            cmd.Parameters.AddWithValue("@contraseña", obje.contraseña);

            cmd.Parameters.AddWithValue("@NOMBRES", obje.cargo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable1 = new DataTable();

            da.Fill(dtable1);

            return dtable1;



        }






    }
}
