namespace Presentacion
{
    partial class Frm_Area
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Area));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grilla_listado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtconsultar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_listado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.Location = new System.Drawing.Point(106, 20);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(91, 51);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Area";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(101, 42);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(356, 20);
            this.txtcodigo.TabIndex = 4;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(101, 65);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(356, 20);
            this.txtarea.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe de Area";
            // 
            // grilla_listado
            // 
            this.grilla_listado.AllowUserToAddRows = false;
            this.grilla_listado.BackgroundColor = System.Drawing.Color.White;
            this.grilla_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_listado.Location = new System.Drawing.Point(23, 293);
            this.grilla_listado.Name = "grilla_listado";
            this.grilla_listado.Size = new System.Drawing.Size(507, 191);
            this.grilla_listado.TabIndex = 7;
            this.grilla_listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_listado_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtconsultar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 56);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar";
            // 
            // txtconsultar
            // 
            this.txtconsultar.Location = new System.Drawing.Point(78, 19);
            this.txtconsultar.Name = "txtconsultar";
            this.txtconsultar.Size = new System.Drawing.Size(356, 21);
            this.txtconsultar.TabIndex = 8;
            this.txtconsultar.TextChanged += new System.EventHandler(this.txtconsultar_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnnuevo);
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btneliminar);
            this.groupBox3.Controls.Add(this.btnmodificar);
            this.groupBox3.Controls.Add(this.btnguardar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 94);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mantenimiento";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(15, 20);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(85, 51);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.Location = new System.Drawing.Point(397, 20);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(91, 51);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(300, 20);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(91, 51);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(203, 20);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(91, 51);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccionar";
            // 
            // Frm_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(547, 496);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grilla_listado);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area";
            this.Load += new System.EventHandler(this.Frm_Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_listado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grilla_listado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtconsultar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label4;
    }
}