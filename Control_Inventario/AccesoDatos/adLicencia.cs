using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// puente al servidor
using System.Data.SqlClient;
using System.Data;


// llamamos  a la   capa ENTIDAD
using Entidad;

namespace AccesoDatos
{
   public  class adLicencia
    {

        //la cadena de conexion  (app config)
        Conexion con = new Conexion();


        //metodo para guardar los datos con procedimiento almacenados


        //******************************* GUARDAR O INSERTAR  REGISTRO
        public void insertar(Licencia nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("GUARDAR_LICENCIA", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                //  cmd.Parameters.Add("@ID_INVENTARIO", SqlDbType.Int).Value = nombre.Id;

                cmd.Parameters.Add("@CLAVE_OFFICE", SqlDbType.VarChar, 50).Value = nombre.Office;
                cmd.Parameters.Add("@CLAVE_WINDOWS", SqlDbType.VarChar, 50).Value = nombre.Windows;
                cmd.Parameters.Add("@CLAVE_AUTOCAD", SqlDbType.VarChar, 50).Value = nombre.Autocad;

                cmd.Parameters.Add("@CLAVE_PDF", SqlDbType.VarChar, 50).Value = nombre.Pdf;
                cmd.Parameters.Add("@CLAVE_ANTIVIRUS", SqlDbType.VarChar, 50).Value = nombre.Antivirus;
                cmd.Parameters.Add("@ID_EQUIPO", SqlDbType.Int, 10).Value = nombre.Idequipo;
               




                //***------------------------------------------------------------------------------------------

                //conexion abierta
                con.con.Open();
                //ejecucion del los comandos 
                cmd.ExecuteNonQuery();

                //conexion cerrada
                con.con.Close();

            }

            //***************************************************

            catch (Exception ex)
            {
                string error = "Error de dato" + ex;

            }




        }



        //***********************************************MODIFICAR  REGISTRO ******************************

        public void modificar(Licencia nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("MODIFICAR_LICENCIA", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_LICENCIA", SqlDbType.Int).Value = nombre.Id;

                cmd.Parameters.Add("@CLAVE_OFFICE", SqlDbType.VarChar, 50).Value = nombre.Office;
                cmd.Parameters.Add("@CLAVE_WINDOWS", SqlDbType.VarChar, 50).Value = nombre.Windows;
                cmd.Parameters.Add("@CLAVE_AUTOCAD", SqlDbType.VarChar, 50).Value = nombre.Autocad;

              


                cmd.Parameters.Add("@CLAVE_PDF", SqlDbType.VarChar, 50).Value = nombre.Pdf;
                cmd.Parameters.Add("@CLAVE_ANTIVIRUS", SqlDbType.VarChar, 50).Value = nombre.Antivirus;
                cmd.Parameters.Add("@ID_EQUIPO", SqlDbType.Int, 10).Value = nombre.Idequipo;




                //***------------------------------------------------------------------------------------------

                //conexion abierta
                con.con.Open();
                //ejecucion del los comandos 
                cmd.ExecuteNonQuery();

                //conexion cerrada
                con.con.Close();

            }

            //***************************************************

            catch (Exception ex)
            {
                string error = "Error de dato" + ex;

            }




        }
        //*******************ELIMINAR REGISTRO

        public void eliminar(Licencia nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("ELIMINAR_LICENCIA", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_LICENCIA", SqlDbType.Int).Value = nombre.Id;

                //***------------------------------------------------------------------------------------------

                //conexion abierta
                con.con.Open();
                //ejecucion del los comandos 
                cmd.ExecuteNonQuery();

                //conexion cerrada
                con.con.Close();


            }

            //***************************************************

            catch (Exception ex)
            {
                string error = "Error de dato" + ex;

            }


        }
        //---------------------------consultar datos-----------------------

        public DataTable Buscar(String Nombre)
        {

            //...................consulta con procedimiento almacenado con sqlserver.........................
            SqlCommand cmd = new SqlCommand("BUSCAR_LICENCIAS", con.con);

            //...................representa el procedimento almacenados.........................
            cmd.CommandType = CommandType.StoredProcedure;

            //...................crear parametro para buscar caracteres de la area.........................

            cmd.Parameters.AddWithValue("@EQUIPO", "%" + Nombre);

            //...................devuelve la informacion de la consulta .........................
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //..................la tabla area.........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;




        }



        // PARA EL COMBOBOX   SELECCIONAR 

        public DataTable Listar_equipo()
        {

            //selecionar la tabla marca todo sus campos o columnas 

            SqlDataAdapter da = new SqlDataAdapter("select  * from equipo", con.con);
            da.SelectCommand.CommandType = CommandType.Text;

            //..................la tabla marca .........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;



        }




    }


}
