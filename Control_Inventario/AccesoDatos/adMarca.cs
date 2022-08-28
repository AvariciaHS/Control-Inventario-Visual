using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


// llamamos  a la   capa ENTIDAD
using Entidad;


namespace AccesoDatos
{
    public class adMarca
    {

        Conexion con = new Conexion();

        //metodo para guardar los datos con procedimiento almacenados

        //******************************* GUARDAR O INSERTAR  REGISTRO
        public void insertar(Marcas nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_GUARDAR_MARCAS", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
              //  cmd.Parameters.Add("@ID_MARCA", SqlDbType.Int).Value = nombre.Id;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = nombre.Descripcion;
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

        public void modificar(Marcas nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_MARCA", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_MARCA", SqlDbType.Int).Value = nombre.Id;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = nombre.Descripcion;
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

        public void eliminar(Marcas nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_MARCA", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_MARCA", SqlDbType.Int).Value = nombre.Id;

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
            SqlCommand cmd = new SqlCommand("BUSCAR_MARCA", con.con);

            //...................representa el procedimento almacenados.........................
            cmd.CommandType = CommandType.StoredProcedure;

            //...................crear parametro para buscar caracteres de la area.........................

            cmd.Parameters.AddWithValue("@descripcion", "%" + Nombre);

            //...................devuelve la informacion de la consulta .........................
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //..................la tabla area.........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;











        }



    }


}
