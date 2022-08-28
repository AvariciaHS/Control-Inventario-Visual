using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;


using Entidad;
using Negocio;


namespace Presentacion
{
    public partial class Frm_Login : Form
    {



        Entidad.Login obje = new Entidad.Login();


       Negocio.cnLogin objn = new Negocio.cnLogin();





        cnCargo Listado = new cnCargo();


        public Frm_Login()
        {
            InitializeComponent();
        }

        private void mostrar_cargo()
        {
            DataTable dt = new DataTable();
            dt = Listado.Listar();
            cbocargo.DataSource = dt;


            this.cbocargo.DisplayMember = "nombres";
   



        }


        private void Button1_Click(object sender, EventArgs e)
        {


            //-----------------------------------------
            DataTable dt = new DataTable();

            obje.usuario = txtusuario.Text;
            obje.contraseña = txtcontraseña.Text;
            obje.cargo = cbocargo.Text;

            //-------------------------------

            dt = objn.N_login(obje);

            if (dt.Rows.Count > 0)

            ////
            {
                if (this.cbocargo.Text == "Administrador")

                /////
                {

                    obje.usuario = dt.Rows[0][1].ToString();
                    obje.contraseña = dt.Rows[0][2].ToString();
                    obje.cargo = dt.Rows[0][3].ToString();


                    this.Hide();


                    Frm_Menu_Principal abrir = new Frm_Menu_Principal();

                    abrir.Show();



                }

              

                else if (this.cbocargo.Text == "Supervisor")
                {

                    obje.usuario = dt.Rows[0][1].ToString();
                    obje.contraseña = dt.Rows[0][2].ToString();
                    obje.cargo = dt.Rows[0][3].ToString();


                    this.Hide();


                    Frm_Menu_Supervisor  abrir = new Frm_Menu_Supervisor();



                    abrir.Show();

                }
            }
            else
            {


                MessageBox.Show("El Usuario / Contaseña / Cargo es Incorrecto", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

            mostrar_cargo();

            cbocargo.Text = "";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
