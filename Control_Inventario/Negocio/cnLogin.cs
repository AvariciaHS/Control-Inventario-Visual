using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using AccesoDatos;

using System.Data;

namespace Negocio
{
  public   class cnLogin
    {



        LOGIN_DAO objd = new LOGIN_DAO();


        public DataTable N_login(Entidad.Login obje)
        {


            return objd.D_Login(obje);

        }







    }
}
