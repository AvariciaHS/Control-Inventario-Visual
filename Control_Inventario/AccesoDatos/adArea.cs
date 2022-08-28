using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using System.Data;

namespace AccesoDatos
{
    //clases area  global
    public sealed class adArea
    {
        //funcion grabar  para el formulario

        //capa entidad clases area  sobre nombre pentidad que representa

        //bool  verdadero o falso 
        public static bool Grabar(Entidad.Area pEntidad)

     
        {

            //----> conectarse con app config  al servidor sqlserver

               Conexion con = new Conexion();



           // using (var cn = new SqlConnection(Conexiones.Leer))


            {

                //var declarar variables 


                //new SqlCommand representa al sql           //setencia sql   select  where  
                using (var cmd = new SqlCommand(@"select * from area where id_area=@id_area;", con.con))
                {
                    //...................creamos un parametro para cada valor de insercion.........................
                    cmd.Parameters.AddWithValue("id_area", pEntidad.id_area);
                    cmd.Parameters.AddWithValue("nombres", pEntidad.nombres);

                    //.............conexion abierta open  ...............................
                    con.con.Open();

                    //condicion  if else  verdadero o falso 
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        //modificar la tabla area  por medio sus columnas 
                        cmd.CommandText = @"update area set nombres=@nombres where id_area=@id_area;";


                    }

                    else

                        //insertar los registros

                        cmd.CommandText = @"insert into area(nombres) values (@nombres);";


                    //returno  booleand en ejecucion 

                    return Convert.ToBoolean(cmd.ExecuteNonQuery());

                    //-----------------------------------------------------------

                }

            }

        }



        public static bool Eliminar(Entidad.Area pEntidad)
        {

            //funcion eliminar  para el formulario

            //capa entidad clases area  sobre nombre pentidad que representa

            //bool  verdadero

            //    using (var cn = new SqlConnection(Conexiones.Leer))


            //----> conectarse con app config  al servidor sqlserver

            Conexion con = new Conexion();

            {
                //new SqlCommand representa al sql           //setencia sql   select  where  

                using (var cmd = new SqlCommand(@"select * from area where id_area=@id_area;", con.con))
                {

                    //...................creamos un parametro del  valor para eliminar.........................
                 
                    cmd.Parameters.AddWithValue("id_area", pEntidad.id_area);
                    con.con.Open();

                    //eliminar la tabla area  por medio id

                    cmd.CommandText = "delete from area where id_area=@id_area";

                    //returno  booleand en ejecucion

                    return Convert.ToBoolean(cmd.ExecuteNonQuery());


                }

            }

        }
        //---------------------------- buscar  con procedimiento almacenados------------------------------------------

        public DataTable Buscar(String Nombre)
        {
            //...................conexion al servidor sqlserver.........................
            //  using (var cn = new SqlConnection(Conexiones.Leer))

            //----> conectarse con app config  al servidor sqlserver

            Conexion con = new Conexion();

            {

                //...................consulta con procedimiento almacenado con sqlserver.........................
                SqlCommand cmd = new SqlCommand("BUSCAR_AREAS", con.con);

                //...................representa el procedimento almacenados.........................
                cmd.CommandType = CommandType.StoredProcedure;

                //...................crear parametro para buscar caracteres de la area.........................

                cmd.Parameters.AddWithValue("@nombres", "%" + Nombre);

                //...................devuelve la informacion de la consulta .........................
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //..................la tabla area.........................
                DataTable dt = new DataTable();

                //...................fila de registro de la tabla .........................
                da.Fill(dt);

                return dt;



            }

        }

        //----------------------------------------------------------------------

    }
}


         
