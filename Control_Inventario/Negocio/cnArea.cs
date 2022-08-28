using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using AccesoDatos;

using System.Data.SqlClient;

using System.Data;


namespace Negocio
{
    public sealed class cnArea
    {

        adArea area_dao = new adArea();

        //para grabar y modificar  los registro-----------------
        public static bool Insertar(Entidad.Area pEntidad)
        {

            return AccesoDatos.adArea.Grabar(pEntidad);


        }

        //---------------------------------------------


        //para eliminar  cada registro-----------------
        public static bool Eliminar(Entidad.Area pEntidad)
        {

            return AccesoDatos.adArea.Eliminar(pEntidad);


        }

        //para consultar registro -----------------

        public DataTable Consultar(String parametro)
        {

            return area_dao.Buscar(parametro);


        }




    }
}
