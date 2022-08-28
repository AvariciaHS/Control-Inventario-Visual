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
    public partial class Frm_Usuario : Form
    {


        Usuario descripcion_entidad = new Usuario();

        cnUsuario descripcion_negocio = new cnUsuario();

        cnUsuario Listado = new cnUsuario();



        public Frm_Usuario()
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


        private void mostrar_cargo()
        {
            DataTable dt = new DataTable();
            dt = Listado.Mostrar_cargo();
            cbocargo.DataSource = dt;


            this.cbocargo.DisplayMember = "nombres";
            this.cbocargo.ValueMember = "id_cargo";



        }





        private void limpiar()
        {

            txtcodigo.Text = "";
            txtusuario.Text = "";
            cbocargo.Text = "";
            txtcontraseña.Text = "";
            cbocargo.Text = "";


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


     


        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            mostrar();



            mostrar_cargo();

            desahilitar();

            cbocargo.Text = "";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrar();

            desahilitar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")

            // ---------->  ||
            {



                MessageBox.Show("Debe Ingresar N° Serial Impresora ", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            else
            {

                // la variables que representa  para la caja de textos

                //******* descripcion_entidad.Id = txtcodigo.Text;
            
                
                descripcion_entidad.Usu = txtusuario.Text;

                descripcion_entidad.Contra = txtcontraseña.Text;
                descripcion_entidad.Idcargo = cbocargo.SelectedValue.ToString();










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

            descripcion_entidad.Usu = txtusuario.Text;

            descripcion_entidad.Contra = txtcontraseña.Text;
            descripcion_entidad.Idcargo = cbocargo.SelectedValue.ToString();





        






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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void grilla_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtcodigo.Text = grilla_listado.CurrentRow.Cells["Codigo"].Value.ToString();

            txtusuario.Text = grilla_listado.CurrentRow.Cells["usuario"].Value.ToString();

            txtcontraseña.Text = grilla_listado.CurrentRow.Cells["contraseña"].Value.ToString();

         

            cbocargo.Text = grilla_listado.CurrentRow.Cells["cargo"].Value.ToString();



            habilitar();


        }
    }
}
