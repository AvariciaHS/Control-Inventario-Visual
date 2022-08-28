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
  public    class adEquipo
    {


        //la cadena de conexion  (app config)
        Conexion con = new Conexion();


        //metodo para guardar los datos con procedimiento almacenados


        //******************************* GUARDAR O INSERTAR  REGISTRO
        public void insertar(Equipo nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("GUARDAR_EQUIPO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                //  cmd.Parameters.Add("@ID_INVENTARIO", SqlDbType.Int).Value = nombre.Id;

                cmd.Parameters.Add("@EQUIPO", SqlDbType.VarChar, 50).Value = nombre.Equi;
                cmd.Parameters.Add("@PROCESADOR", SqlDbType.VarChar, 50).Value = nombre.Procesador;
                cmd.Parameters.Add("@RAM", SqlDbType.VarChar, 50).Value = nombre.Ram;

                cmd.Parameters.Add("@DISCO_DURO", SqlDbType.VarChar, 50).Value = nombre.Disco;
                cmd.Parameters.Add("@PLACA", SqlDbType.VarChar, 50).Value = nombre.Placa;
                cmd.Parameters.Add("@DIRECCION_IP", SqlDbType.VarChar, 50).Value = nombre.Direccion;
                cmd.Parameters.Add("@PANTALLA", SqlDbType.VarChar, 50).Value = nombre.Pantalla;

                cmd.Parameters.Add("@T_VIDEO", SqlDbType.VarChar, 50).Value = nombre.T_video;
                cmd.Parameters.Add("@ESTABILIZADOR", SqlDbType.VarChar, 50).Value = nombre.Estabilizador;
                cmd.Parameters.Add("@TECLADO_MOUSE", SqlDbType.VarChar, 50).Value = nombre.Teclado_mouse;

                cmd.Parameters.Add("@ID_IMPRESORA", SqlDbType.VarChar, 50).Value = nombre.Idimpresora;
            



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

        public void modificar(Equipo nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("MODIFICAR_EQUIPO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_EQUIPO", SqlDbType.Int).Value = nombre.Id;

                cmd.Parameters.Add("@EQUIPO", SqlDbType.VarChar, 50).Value = nombre.Equi;
                cmd.Parameters.Add("@PROCESADOR", SqlDbType.VarChar, 50).Value = nombre.Procesador;
                cmd.Parameters.Add("@RAM", SqlDbType.VarChar, 50).Value = nombre.Ram;

                cmd.Parameters.Add("@DISCO_DURO", SqlDbType.VarChar, 50).Value = nombre.Disco;
                cmd.Parameters.Add("@PLACA", SqlDbType.VarChar, 50).Value = nombre.Placa;
                cmd.Parameters.Add("@DIRECCION_IP", SqlDbType.VarChar, 50).Value = nombre.Direccion;
                cmd.Parameters.Add("@PANTALLA", SqlDbType.VarChar, 50).Value = nombre.Pantalla;

                cmd.Parameters.Add("@T_VIDEO", SqlDbType.VarChar, 50).Value = nombre.T_video;
                cmd.Parameters.Add("@ESTABILIZADOR", SqlDbType.VarChar, 50).Value = nombre.Estabilizador;
                cmd.Parameters.Add("@TECLADO_MOUSE", SqlDbType.VarChar, 50).Value = nombre.Teclado_mouse;

                cmd.Parameters.Add("@ID_IMPRESORA", SqlDbType.VarChar, 50).Value = nombre.Idimpresora;

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

        public void eliminar(Equipo nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("ELIMINAR_EQUIPO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_EQUIPO", SqlDbType.Int).Value = nombre.Id;

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
            SqlCommand cmd = new SqlCommand("BUSCAR_EQUIPO", con.con);

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

            SqlDataAdapter da = new SqlDataAdapter("select  * from impresora", con.con);
            da.SelectCommand.CommandType = CommandType.Text;

            //..................la tabla marca .........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;



        }






    }


}
