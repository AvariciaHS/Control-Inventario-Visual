using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Menu_Principal : Form
    {
        public Frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void registrarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Marca abrir = new Frm_Marca();

            abrir.Show();





        }

        private void registrarAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Area  abrir = new Frm_Area();

            abrir.Show();



        }

        private void registrarImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Impresora abrir = new Frm_Impresora();

            abrir.Show();
        }

        private void registrarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Frm_Inventario abrir = new Frm_Inventario();

            abrir.Show();
        }

        private void registrarLicenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Licencia abrir = new Frm_Licencia();

            abrir.Show();
        }

        private void registrarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Equipo abrir = new Frm_Equipo();

            abrir.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Usuario abrir = new Frm_Usuario();

            abrir.Show();
        }

        private void informeDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Acerca abrir = new Frm_Acerca();

            abrir.Show();


        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Desea Salir del Control de Inventario ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {

                return;



            }

            this.Dispose();
            this.Hide();




        }

        private void registrarUbicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Frm_Ubicacion abrir = new Frm_Ubicacion();

            abrir.Show();

        }

        private void reporteDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void reporteDeImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void reporteDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reporteDeLincenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cargo abrir = new Frm_Cargo();

            abrir.Show();
        }
    }
}
