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
    public partial class Frm_Equipo : Form
    {


        Equipo descripcion_entidad = new Equipo();

        cnEquipo descripcion_negocio = new cnEquipo();

        cnEquipo Listado = new cnEquipo();


        public Frm_Equipo()
        {
            InitializeComponent();
        }



        private void mostrar()
        {

            DataTable dt = new DataTable();

            String dato = txtconsultar.Text;


            dt = Listado.Consultar(dato);

            grilla_listado.DataSource = dt;


        }


        private void mostrar_marca()
        {
            DataTable dt = new DataTable();
            dt = Listado.Mostrar_equipo();
            cboimpresora.DataSource = dt;


            this.cboimpresora.DisplayMember = "serial";
            this.cboimpresora.ValueMember = "id_impresora";



        }





        private void limpiar()
        {

            txtcodigo.Text = "";
            txtequipo.Text = "";
            txtpantalla.Text = "";
            txtdireccion.Text = "";
            cboimpresora.Text = "";

            txtprocesador.Text = "";
            txtram.Text = "";
            txtdisco.Text = "";
            txtplaca.Text = "";
            txtdireccion.Text = "";
            txtpantalla.Text = "";
            txtvideo.Text = "";
            txtestabilizador.Text = "";
            txtteclado.Text = "";

            txtconsultar.Text = "";


        }

        private void habilitar()
        {


            btnguardar.Enabled = false;

            btnmodificar.Enabled = true;

            btneliminar.Enabled = true;

        }

        private void desahilitar()
        {

            btnguardar.Enabled = true;

            btnmodificar.Enabled = false;

            btneliminar.Enabled = false;


        }




        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Equipo_Load(object sender, EventArgs e)
        {
            mostrar();



            mostrar_marca();

            desahilitar();

            cboimpresora.Text = "";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            limpiar();
            mostrar();

            desahilitar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtequipo.Text == "")

            // ---------->  ||
            {



                MessageBox.Show("Debe Ingresar N° Equipo ", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (cboimpresora.Text == "")

            // ---------->  ||
            {



                MessageBox.Show("Debe Ingresar N° Impresora ", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else
            {

                // la variables que representa  para la caja de textos

                //******* descripcion_entidad.Id = txtcodigo.Text;
                descripcion_entidad.Equi = txtequipo.Text;

                descripcion_entidad.Procesador = txtprocesador.Text;
                descripcion_entidad.Ram = txtram.Text;
                 descripcion_entidad.Disco = txtdisco.Text;

                descripcion_entidad.Placa = txtplaca.Text;
                descripcion_entidad.Direccion= txtdireccion.Text;
                descripcion_entidad.Pantalla = txtpantalla.Text;

                descripcion_entidad.T_video= txtvideo.Text;
                descripcion_entidad.Estabilizador = txtestabilizador.Text;

                descripcion_entidad.Teclado_mouse = txtteclado.Text;


                descripcion_entidad.Idimpresora = cboimpresora.SelectedValue.ToString();







                // metodo de guardar
                descripcion_negocio.guardar(descripcion_entidad);


                MessageBox.Show("Asido Guardado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mostrar();

                limpiar();


            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            // la variables que representa  para la caja de textos

            descripcion_entidad.Id = txtcodigo.Text;

            descripcion_entidad.Equi = txtequipo.Text;

            descripcion_entidad.Procesador = txtprocesador.Text;
            descripcion_entidad.Ram = txtram.Text;
            descripcion_entidad.Disco = txtdisco.Text;

            descripcion_entidad.Placa = txtplaca.Text;
            descripcion_entidad.Direccion = txtdireccion.Text;
            descripcion_entidad.Pantalla = txtpantalla.Text;

            descripcion_entidad.T_video = txtvideo.Text;
            descripcion_entidad.Estabilizador = txtestabilizador.Text;

            descripcion_entidad.Teclado_mouse = txtteclado.Text;


            descripcion_entidad.Idimpresora = cboimpresora.SelectedValue.ToString();






            // metodo de guardar
            descripcion_negocio.editar(descripcion_entidad);


            MessageBox.Show("Asido Modificado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostrar();

            limpiar();


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {


            DialogResult resultado = MessageBox.Show("¿Desea Eliminar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {


                return;

                mostrar();

                limpiar();

            }

            // la variables que representa  para la caja de textos

            descripcion_entidad.Id = txtcodigo.Text;


            // metodo de guardar
            descripcion_negocio.cancelar(descripcion_entidad);

            //   MessageBox.Show("Asido Eliminado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostrar();

            limpiar();

        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void grilla_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtcodigo.Text = grilla_listado.CurrentRow.Cells["Codigo"].Value.ToString();

            txtequipo.Text = grilla_listado.CurrentRow.Cells["equipo"].Value.ToString();

            txtprocesador.Text = grilla_listado.CurrentRow.Cells["procesador"].Value.ToString();

            txtram.Text = grilla_listado.CurrentRow.Cells["ram"].Value.ToString();

            txtdisco.Text = grilla_listado.CurrentRow.Cells["disco_duro"].Value.ToString();


            txtplaca.Text = grilla_listado.CurrentRow.Cells["placa"].Value.ToString();

            txtdireccion.Text = grilla_listado.CurrentRow.Cells["direccion_ip"].Value.ToString();

            txtpantalla.Text = grilla_listado.CurrentRow.Cells["pantalla"].Value.ToString();

            txtvideo.Text = grilla_listado.CurrentRow.Cells["t_video"].Value.ToString();

            txtestabilizador.Text = grilla_listado.CurrentRow.Cells["estabilizador"].Value.ToString();


            txtteclado.Text = grilla_listado.CurrentRow.Cells["teclado_mouse"].Value.ToString();

            cboimpresora.Text = grilla_listado.CurrentRow.Cells["impresora"].Value.ToString();








            habilitar();

        }
    }
}
