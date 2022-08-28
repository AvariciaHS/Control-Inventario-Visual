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
    public partial class Frm_Inventario : Form
    {

        Inventario descripcion_entidad = new Inventario();

        cnInventario descripcion_negocio = new cnInventario();

        cnInventario Listado = new cnInventario();



        public Frm_Inventario()
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

        // combobox  jala los datos  de la tabla  ---------------------------
        private void listadoarea()
        {
            DataTable dt = new DataTable();
            dt = Listado.Mostrar_area();
            cboarea.DataSource = dt;


            this.cboarea.DisplayMember = "nombres";
            this.cboarea.ValueMember = "id_area";



        }




        // combobox  jala los datos  de la tabla  ---------------------------
        private void listadoubicacion()
        {
            DataTable dt = new DataTable();
            dt = Listado.Mostrar_ubicacion();
            cboubicacion.DataSource = dt;


            this.cboubicacion.DisplayMember = "descripcion";
            this.cboubicacion.ValueMember = "id_ubicacion";



        }

        // combobox  jala los datos  de la tabla  ---------------------------
        private void listadoequipo()
        {
            DataTable dt = new DataTable();
            dt = Listado.Mostrar_equipo();
            cboequipo.DataSource = dt;


            this.cboequipo.DisplayMember = "equipo";
            this.cboequipo.ValueMember = "id_equipo";



        }


        // combobox  jala los datos  de la tabla  ---------------------------
        private void listadousuario()
        {
            DataTable dt = new DataTable();
            dt = Listado.Mostrar_usuario();
            cbousuario.DataSource = dt;


            this.cbousuario.DisplayMember = "usuario";
            this.cbousuario.ValueMember = "idusuario";



        }






        private void limpiar()
        {

            txtcodigo.Text = "";
            txtcorreo.Text = "";
            txtempresa.Text = "";
            txtpersona.Text = "";
            cboarea.Text = "";
            cboubicacion.Text = "";
            cboequipo.Text = "";


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




        private void btnguardar_Click(object sender, EventArgs e)
        {



            if (txtpersona.Text == "" || txtempresa.Text=="" || txtcorreo.Text=="" || cboequipo.Text == "" || cboubicacion.Text == "" || cbousuario.Text == "" || cboarea.Text == "" )


            {



                MessageBox.Show("Debe Ingresar los Datos Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            else
            {

                // la variables que representa  para la caja de textos

                //******* descripcion_entidad.Id = txtcodigo.Text;
                descripcion_entidad.Personas = txtpersona.Text;

                descripcion_entidad.Empresa = txtempresa.Text;
                descripcion_entidad.Correo = txtcorreo.Text;


                //****************comboxbox---------------------------------

                descripcion_entidad.Ubicaciones = cboubicacion.SelectedValue.ToString();
                descripcion_entidad.Equipos = cboequipo.SelectedValue.ToString();
                descripcion_entidad.Areas = cboarea.SelectedValue.ToString();
                descripcion_entidad.Usuarios = cbousuario.SelectedValue.ToString();






                // metodo de guardar
                descripcion_negocio.guardar(descripcion_entidad);


                MessageBox.Show("Asido Guardado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mostrar();

                limpiar();


            }












        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {


            mostrar();


            listadoubicacion();
            listadoarea();
            listadoequipo();
            listadousuario();



            desahilitar();

            cboarea.Text = "";
            cboequipo.Text = "";
            cboubicacion.Text = "";








        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            // la variables que representa  para la caja de textos

            descripcion_entidad.Id = txtcodigo.Text;
            descripcion_entidad.Personas = txtpersona.Text;

            descripcion_entidad.Empresa = txtempresa.Text;
            descripcion_entidad.Correo = txtcorreo.Text;


            //****************comboxbox---------------------------------

            descripcion_entidad.Ubicaciones = cboubicacion.SelectedValue.ToString();
            descripcion_entidad.Equipos = cboequipo.SelectedValue.ToString();
            descripcion_entidad.Areas = cboarea.SelectedValue.ToString();
            descripcion_entidad.Usuarios = cbousuario.SelectedValue.ToString();






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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrar();

            desahilitar();

        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void grilla_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            txtcodigo.Text = grilla_listado.CurrentRow.Cells["Codigo"].Value.ToString();

            txtpersona.Text = grilla_listado.CurrentRow.Cells["persona"].Value.ToString();

            txtempresa.Text = grilla_listado.CurrentRow.Cells["empresa_pertenece"].Value.ToString();

            txtcorreo.Text = grilla_listado.CurrentRow.Cells["correo"].Value.ToString();

            cboubicacion.Text = grilla_listado.CurrentRow.Cells["ubicacion"].Value.ToString();
            cboequipo.Text = grilla_listado.CurrentRow.Cells["equipo"].Value.ToString();
            cboarea.Text = grilla_listado.CurrentRow.Cells["area"].Value.ToString();
            cbousuario.Text = grilla_listado.CurrentRow.Cells["usuario"].Value.ToString();


            habilitar();












        }
    }
}
