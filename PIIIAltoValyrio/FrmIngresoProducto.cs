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
    public partial class FrmIngresoProducto : Form
    {
        private AltoValyrio form1;

        public FrmIngresoProducto(AltoValyrio form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

       /* public FrmIngresoProducto(string f)
        {
            InitializeComponent();
          
            label8.Visible = false;
            label8.Text = f;
        }*/

        private void FrmIngresoProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet4.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValyrioDataSet4.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet3.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.altoValyrioDataSet3.Marca);
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet2.PresentacionProducto' Puede moverla o quitarla según sea necesario.
            this.presentacionProductoTableAdapter.Fill(this.altoValyrioDataSet2.PresentacionProducto);
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet1.CategoriaProducto' Puede moverla o quitarla según sea necesario.
            this.categoriaProductoTableAdapter.Fill(this.altoValyrioDataSet1.CategoriaProducto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar();

        }

        public void Agregar()
        {
            var Idbodega = Convert.ToInt32(comboBox4.SelectedValue);
            var Idmarca = Convert.ToInt32(cmMarca.SelectedValue);
            var Idpresentacion = Convert.ToInt32(cmbpresentacion.SelectedValue);
            var Idcategoria = Convert.ToInt32(comboBox1.SelectedValue);
           
            using (SqlConnection conn = new SqlConnection(Conectar.cnn))
            {
                try
                {

                    conn.Open();
                    var select = new SqlCommand("SELECT IdCategoria, CodigoProducto FROM Producto WHERE NombreProducto = @NombreProducto AND IdBodega = @IdBodega", conn);
                    select.Parameters.AddWithValue("NombreProducto", txtnombreprod.Text);
                    select.Parameters.AddWithValue("IdBodega", Idbodega);


                    SqlDataAdapter ds = new SqlDataAdapter(select);
                    DataTable dt = new DataTable();
                    ds.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Ya existe el producto en la bodega");
                    }
                    else
                    {
                        var nuevoingreso = new Producto()
                        {
                            CodigoProducto = txtcodigoprod.Text,
                            NombreProducto = txtnombreprod.Text,
                            IdCategoria = Idcategoria,
                            IdPresentacion = Idpresentacion,
                            IdMarca = Idmarca,
                            IdBodega = Idbodega,
                            Refrigeracion = cmbrefrigeracion.Text

                        };
                        form1.AgregarNuevoIngresoProd(nuevoingreso);
                       // var frm2 = new FrmIngresoYDetalle();
                      //  frm2.Show();
                        MessageBox.Show("NUEVO PRODUCTO AGREGADO CORRECTAMENTE\n Dirijase a la pestaña Producto, Producto existente para completar el respectivo ingreso", "INGRESO DE PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                   /* else if (val == Idbodega)
                    {

                        var nuevoingreso = new Producto()
                        {
                            CodigoProducto = txtcodigoprod.Text,
                            NombreProducto = txtnombreprod.Text,
                            IdCategoria = Idcategoria,
                            IdPresentacion = Idpresentacion,
                            IdMarca = Idmarca,
                            IdBodega = Idbodega,
                            Refrigeracion = cmbrefrigeracion.Text

                        };
                        form1.AgregarNuevoIngresoProd(nuevoingreso);
                        var frm2 = new FrmIngresoYDetalle(Convert.ToString(Idbodega));
                        frm2.Show();
                        MessageBox.Show("NUEVO PRODUCTO AGREGADO CORRECTAMENTE", "INGRESO DE PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                   
                    else
                    {
                        MessageBox.Show("ERROR USTED NO ES USUARIO DE LA BODEGA ASIGNADA", "INGRESO DE PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/

                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

