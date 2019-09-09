using PIIIAltoValyrio.Class;
using PIIIAltoValyrio.Operaciones;
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
    public partial class FrmEditarProducto : Form
    {
        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsproducto = new DataSet();
            var operaciones = new OperacionProducto();
            dsproducto = operaciones.Datosporcodigo(txtcod.Text);
            LLenarCamposFOrm(dsproducto);
        }
        private void LLenarCamposFOrm(DataSet dsprod)
        {
            foreach (DataRow informacion in dsprod.Tables[0].Rows)
            {
                txtnombre.Text = informacion["NombreProducto"].ToString();
                txtcat.Text = informacion["IdCategoria"].ToString();
                txtpresen.Text = informacion["IdPresentacion"].ToString();
                txtmarc.Text = informacion["IdMarca"].ToString();
                bodega.Text = informacion["IdBodega"].ToString();
                txtrefrigera.Text = informacion["Refrigeracion"].ToString();
                
            }
            txtcod.Enabled = false;
            txtnombre.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("" +
                      "UPDATE Producto SET NombreProducto = @NombreProducto, " +
                     
                      "IdCategoria = @IdCategoria, " +
                      "IdPresentacion = @IdPresentacion," +
                      "IdMarca = @IdMarca," +
                      "IdBodega = @IdBodega," +
                      "Refrigeracion = @Refrigeracion" +
                      " WHERE CodigoProducto = @CodigoProducto", conn);

                    var prod = new Producto()
                    {
                        NombreProducto = txtnombre.Text,
                        CodigoProducto = txtcod.Text,
                        IdCategoria = Convert.ToInt32(txtcat.Text),
                        IdPresentacion = Convert.ToInt32(txtpresen.Text),
                        IdBodega = Convert.ToInt32(bodega.Text),
                        IdMarca= Convert.ToInt32(txtmarc.Text),
                        Refrigeracion=txtrefrigera.Text
                    };

                    insertCommand.Parameters.Add(new SqlParameter("CodigoProducto", prod.CodigoProducto));
                    insertCommand.Parameters.Add(new SqlParameter("NombreProducto", prod.NombreProducto));
                    insertCommand.Parameters.Add(new SqlParameter("IdCategoria", prod.IdCategoria));
                    insertCommand.Parameters.Add(new SqlParameter("IdPresentacion", prod.IdPresentacion));
                    insertCommand.Parameters.Add(new SqlParameter("IdMarca", prod.IdMarca));
                    insertCommand.Parameters.Add(new SqlParameter("IdBodega", prod.IdBodega));
                    insertCommand.Parameters.Add(new SqlParameter("Refrigeracion", prod.Refrigeracion));
                    
                    insertCommand.ExecuteScalar();
                    MessageBox.Show("Datos editados con exito");
                }
            }
            catch (Exception)
            {
                throw;
            }
            this.Close();
        }
    }
}
