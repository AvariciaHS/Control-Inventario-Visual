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
    public class adInventario
    {


        //la cadena de conexion  (app config)
        Conexion con = new Conexion();


        //metodo para guardar los datos con procedimiento almacenados


        //******************************* GUARDAR O INSERTAR  REGISTRO
        public void insertar(Inventario nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_GUARDAR_INVENTARIO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                //  cmd.Parameters.Add("@ID_INVENTARIO", SqlDbType.Int).Value = nombre.Id;

                cmd.Parameters.Add("@persona", SqlDbType.VarChar, 50).Value = nombre.Personas;
                cmd.Parameters.Add("@empresa_pertenece", SqlDbType.VarChar, 50).Value = nombre.Empresa;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = nombre.Correo;

                cmd.Parameters.Add("@id_ubicacion", SqlDbType.Int,10).Value = nombre.Ubicaciones;
                cmd.Parameters.Add("@id_equipo", SqlDbType.Int, 10).Value = nombre.Equipos;
                cmd.Parameters.Add("@id_area", SqlDbType.Int, 10).Value = nombre.Areas;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int, 10).Value = nombre.Usuarios;




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

        public void modificar(Inventario nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_MODIFICAR_INVENTARIO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_INVENTARIO", SqlDbType.Int).Value = nombre.Id;

                cmd.Parameters.Add("@persona", SqlDbType.VarChar, 50).Value = nombre.Personas;
                cmd.Parameters.Add("@empresa_pertenece", SqlDbType.VarChar, 50).Value = nombre.Empresa;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 50).Value = nombre.Correo;

                cmd.Parameters.Add("@id_ubicacion", SqlDbType.Int, 10).Value = nombre.Ubicaciones;
                cmd.Parameters.Add("@id_equipo", SqlDbType.Int, 10).Value = nombre.Equipos;
                cmd.Parameters.Add("@id_area", SqlDbType.Int, 10).Value = nombre.Areas;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int, 10).Value = nombre.Usuarios;

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

        public void eliminar(Inventario nombre)
        {
            //evitar errores try    catch 
            try
            {
                //comando que reconoce el nombre del procedimiento almacenado
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_INVENTARIO", con.con);

                // store produre    nombre 

                cmd.CommandType = CommandType.StoredProcedure;

                //los parametro biene ser las columna de la tabla 
                cmd.Parameters.Add("@ID_INVENTARIO", SqlDbType.Int).Value = nombre.Id;

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
            SqlCommand cmd = new SqlCommand("BUSCAR_INVENTARIO_PC", con.con);

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

        public DataTable Listar_ubicacion()
        {

            //selecionar la tabla marca todo sus campos o columnas 

            SqlDataAdapter da = new SqlDataAdapter("select  * from ubicacion", con.con);
            da.SelectCommand.CommandType = CommandType.Text;

            //..................la tabla marca .........................
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


        // PARA EL COMBOBOX   SELECCIONAR 

        public DataTable Listar_area()
        {

            //selecionar la tabla marca todo sus campos o columnas 

            SqlDataAdapter da = new SqlDataAdapter("select  * from area", con.con);
            da.SelectCommand.CommandType = CommandType.Text;

            //..................la tabla marca .........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;



        }

        // PARA EL COMBOBOX   SELECCIONAR 

        public DataTable Listar_usuario()
        {

            //selecionar la tabla marca todo sus campos o columnas 

            SqlDataAdapter da = new SqlDataAdapter("select  * from usuarios", con.con);
            da.SelectCommand.CommandType = CommandType.Text;

            //..................la tabla marca .........................
            DataTable dt = new DataTable();

            //...................fila de registro de la tabla .........................
            da.Fill(dt);

            return dt;



        }




    }


}
