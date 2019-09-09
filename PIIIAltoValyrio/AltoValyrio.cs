using PIIIAltoValyrio.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIIIAltoValyrio
{
    public partial class AltoValyrio : Form
    {
        public AltoValyrio(string tip, int bod)
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Text = tip;
            label2.Text = Convert.ToString(bod);
            validar();
        }
        //constructor vacio
        public AltoValyrio()
        {
            InitializeComponent();
        }

        //valida tipo de user
        public void validar()
        {
            if (label1.Text == "Bodeguero")
            {
                productosToolStripMenuItem.Enabled = true;
                reportesToolStripMenuItem.Enabled = false;
                bodegasToolStripMenuItem.Enabled=false;
            }
            if (label1.Text=="Administrador")
            {
                productosToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = true;
                trasladoProductosToolStripMenuItem.Enabled = true;
                ediciónProductoToolStripMenuItem.Enabled = true;
                bodegasToolStripMenuItem.Enabled = true;

            }
        }

        private void AltoValyrio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void AgregarNuevoIngresoProd(Producto prod)
        {
            try
            {
                //conectionstring cadena de instrucciones para conectarse a la base de datos
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //insert into *NOMBRE DE LA TABLA* values(pasan los parametros y se manda la conexión)
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Producto VALUES (@CodigoProducto,@NombreProducto,@IdCategoria,@IdPresentacion,@IdMarca,@IdBodega,@Refrigeracion)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("CodigoProducto", prod.CodigoProducto));
                    insertCommand.Parameters.Add(new SqlParameter("NombreProducto", prod.NombreProducto));
                    insertCommand.Parameters.Add(new SqlParameter("IdCategoria", prod.IdCategoria));
                    insertCommand.Parameters.Add(new SqlParameter("IdPresentacion", prod.IdPresentacion));
                    insertCommand.Parameters.Add(new SqlParameter("IdMarca", prod.IdMarca));
                    insertCommand.Parameters.Add(new SqlParameter("IdBodega", prod.IdBodega));
                    insertCommand.Parameters.Add(new SqlParameter("Refrigeracion", prod.Refrigeracion));
                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ingresoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ingreso = new FrmIngresoProducto(this);
            ingreso.Show();
        }

        private void ingresoProductoExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var prodexistente = new FrmIngresoYDetalle(label2.Text);
            prodexistente.Show();
        }

        private void borrarTrasladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var generartras = new FrmTraslado();
            generartras.Show();
        }

        private void borrarTrasladoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var borrar = new FrmBorrarTraslado();
            borrar.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var sal = new Form1();
            sal.Show();
        }

        private void ediciónProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var edit = new FrmEditarProducto();
            edit.Show();
        }

        private void generarPorBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rebod = new FrmReportes();
            rebod.Show();
        }

        private void generarPorTrasladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reptras = new FrmReporteBit();
            reptras.Show();
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bg = new DireccionBodegas();
            bg.Show();
        }

        private void altoValyrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mis = new MisionyVision();
            mis.Show();

        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ac = new FrmAcercaDe();
            ac.Show();
        }
    }
}
