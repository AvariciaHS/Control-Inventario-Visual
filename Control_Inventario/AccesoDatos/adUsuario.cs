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
    public class adUsuario
    {


        Conexion con = new Conexion();

        //metodo para guardar los datos con procedimiento almacenados

        //******************************* GUARDAR O INSERTAR  REGISTRO
        public void insertar(Usuario nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("GUARDAR_USUARIO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                //  cmd.Parameters.Add("@ID_MARCA", SqlDbType.Int).Value = nombre.Id;
                cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar, 50).Value = nombre.Usu;
                cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar, 50).Value = nombre.Contra;
                cmd.Parameters.Add("@ID_CARGO", SqlDbType.Int).Value = nombre.Idcargo;
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

        public void modificar(Usuario nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("MODIFICAR_USUARIO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@IDUSUARIO", SqlDbType.Int).Value = nombre.Id;

                cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar, 50).Value = nombre.Usu;
                cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar, 50).Value = nombre.Contra;
                cmd.Parameters.Add("@ID_CARGO", SqlDbType.Int).Value = nombre.Idcargo;
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

        public void eliminar(Usuario nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("ELIMINAR_USUARIO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@IDUSUARIO", SqlDbType.Int).Value = nombre.Id;
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
            SqlCommand cmd = new SqlCommand("BUSCAR_USUARIO", con.con);

            //...................representa el procedimento almacenados.........................
            cmd.CommandType = CommandType.StoredProcedure;

            //...................crear parametro para buscar caracteres de la area.........................

            cmd.Parameters.AddWithValue("@USUARIO", "%" + Nombre);

            //...................devuelve la informacion de la consulta .........................
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //..................la tabla area.........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;











        }


        // PARA EL COMBOBOX   SELECCIONAR 

        public DataTable Listar_cargo()
        {

            //selecionar la tabla marca todo sus campos o columnas 

            SqlDataAdapter da = new SqlDataAdapter("select  * from cargo", con.con);
            da.SelectCommand.CommandType = CommandType.Text;

            //..................la tabla marca .........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;



        }



    }


}
