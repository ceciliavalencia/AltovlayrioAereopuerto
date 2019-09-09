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
    public partial class FrmIngresoYDetalle : Form
    {
        private AltoValyrio form2;
        public FrmIngresoYDetalle(AltoValyrio form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }
        public FrmIngresoYDetalle()
        {
            InitializeComponent();
           
        }
        public FrmIngresoYDetalle(string bod)
        {
            InitializeComponent();
            label9.Visible = false;
            label9.Text = bod;
            var dsProducto = new DataSet();
            var opc = new OperacionProducto();
            dsProducto = opc.bodeg(int.Parse(label9.Text));
            llenarDatos(dsProducto);
        }
        //llena datos de idcategoria a datagried
        private void llenarDatos(DataSet dsProducto)
        {
            dataGridView3.DataSource = dsProducto.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bodega;
            bodega = Convert.ToInt32(label9.Text);
            var dsProducto = new DataSet();
            var opc = new OperacionProducto();
            dsProducto = opc.bodeg(bodega);
            llenarDatos(dsProducto);
            dataGridView3.Visible = true;

            var idcategoria = (Convert.ToInt32(comboBox1.SelectedValue));
            string pro = Convert.ToString(idcategoria);
            label2.Text = pro;
            foreach (DataGridViewRow Row in dataGridView3.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["IdCategoria"].Value);

                if (Valor == label2.Text)
                {
                    dataGridView3.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.MediumPurple;
                }

                
            }
        }

        private void txtnombreprod_TextChanged(object sender, EventArgs e)
        {
            if (txtnombreprod.Text != "")
            {
                dataGridView3.CurrentCell = null;
                foreach (DataGridViewRow r in dataGridView3.Rows)
                {
                    r.Visible = false;

                }
                foreach (DataGridViewRow r in dataGridView3.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper().IndexOf(txtnombreprod.Text.ToUpper())) == 0)
                        {
                            r.Visible = true;

                            break;
                        }
                    }

                }
            }
            if (txtnombreprod.Text=="")
            {
                int bodeg;
                bodeg = Convert.ToInt32(label9.Text);
                var dsProducto = new DataSet();
                var opc = new OperacionProducto();
                dsProducto = opc.bodeg(bodeg);
                llenarDatos(dsProducto);
            }
        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            //limpiar datos
            txtfechacaducidad.Text = "";
            txtactual.Text = "";
            txtpreciocompra.Text = "";
            txtinicial.Text = "";

            //recogevalor de id 
            
            int nombog = 0;
            int marca = 0;
            txtidprod.Text = Convert.ToString(dataGridView3.CurrentRow.Cells["IdProducto"].Value);
            nombog = Convert.ToInt32(dataGridView3.CurrentRow.Cells["IdBodega"].Value);
            marca = Convert.ToInt32(dataGridView3.CurrentRow.Cells["IdMarca"].Value);

            //validar combobox de acuerdo a la bodega
            if (nombog == 11)
            {
                comboBox4.Text = "Express Home";
            }
            if (nombog == 12)
            {
                comboBox4.Text = "Super Casa";
            }
            if (nombog == 13)
            {
                comboBox4.Text = "Super Ecomax";
            }
            if (nombog == 14)
            {
                comboBox4.Text = "Todo en Casa";
            }
            if (nombog == 15)
            {
                comboBox4.Text = "Rapishop";
            }
            /*  int bg = 0;
              bg = Convert.ToInt32(comboBox4.SelectedValue);
              string devbod;
              if (nombog == bg)
              {
                  devbod = Convert.ToString(bg);
                  comboBox4.SelectedValue=bg;
              }*/

            //validar combobox de acuerdo a la marca
            if (marca == 1)
            {
                cmMarca.Text = "SCOTT";
            }
            if (marca == 3)
            {
                cmMarca.Text = "COLGATE";
            }
            if (marca == 7)
            {
                cmMarca.Text = "GILLETTE";
            }
            if (marca == 8)
            {
                cmMarca.Text = "DANONE";
            }
            if (marca == 9)
            {

                cmMarca.Text = "KELLOWS";

            }
            if (marca == 10)
            {
                cmMarca.Text = "NESTLÉ";

            }
            if (marca == 11)
            {
                cmMarca.Text = "HELLMANN´S";

            }
            if (marca == 13)
            {
                cmMarca.Text = "BIMBO";

            }
            if (marca == 14)
            {
                cmMarca.Text = "UNILEVER";
            }
            if (marca == 15)
            {
                cmMarca.Text = "KERN´S";
            }
            if (marca == 16)
            {
                cmMarca.Text = "IDEAL";
            }
            if (marca == 17)
            {
                cmMarca.Text = "ANABELLY";
            }
            if (marca == 18)
            {
                cmMarca.Text = "PERRY";
            }
            if (marca == 19)
            {
                cmMarca.Text = "PREMIER";

            }
            if (marca == 20)
            {
                cmMarca.Text = "PURINA";
            }
            if (marca == 21)
            {
                cmMarca.Text = "INA";
            }
            if (marca == 22)
            {
                cmMarca.Text = "PARMA";
            }
            if (marca == 23)
            {
                cmMarca.Text = "DEL MONTE";

            }
            if (marca == 24)
            {
                cmMarca.Text = "DUCAL";
            }
            if (marca == 25)
            {
                cmMarca.Text = "MAZOLA";
            }
            if (marca == 27)
            {
                cmMarca.Text = "TANG";
            }
            if (marca == 28)
            {
                cmMarca.Text = "LALA";
            }
            if (marca == 29)
            {
                cmMarca.Text = "REGIA";
            }
            if (marca == 30)
            {
                cmMarca.Text = "ARIEL";
            }
            if (marca == 31)
            {
                cmMarca.Text = "TUCAN";
            }
            if (marca == 32)
            {
                cmMarca.Text = "PYG";
            }
            if (marca == 34)
            {
                cmMarca.Text = "DOVE";
            }
            if (marca == 35)
            {
                cmMarca.Text = "PROTEX";
            }
            if (marca == 36)
            {
                cmMarca.Text = "REXONA";
            }
            if (marca == 37)
            {
                cmMarca.Text = "OTRO";
            }

            ObtenerDatosDetalleIngreso();
        }
        private void ObtenerDatosDetalleIngreso()
        {
            var dsIDProducDetalleIngreso = new DataSet();
            var operaciones = new OperacionProducto();
            dsIDProducDetalleIngreso = operaciones.BuscarDetalleIngreso(Convert.ToInt32(txtidprod.Text));
            LLenarCampostxts(dsIDProducDetalleIngreso);

        }
        //llena los datos de detalle ingreso si existe.
        private void LLenarCampostxts(DataSet dsIDProducDetalleIngreso)
        {

            string nombog;
            foreach (DataRow informacion in dsIDProducDetalleIngreso.Tables[0].Rows)
            {
                txtpreciocompra.Text = informacion["Precio_Compra"].ToString();
                txtactual.Text = informacion["Stock_Actual"].ToString();
                txtinicial.Text = informacion["Stock_Inicial"].ToString();
                txtfechacaducidad.Text = informacion["Fecha_Caducidad"].ToString();
                comboBox4.Text = informacion["IdBodega"].ToString();

               
                
                //validar combobox de acuerdo a la bodega
                 if (comboBox4.Text == "11")
                 {
                     nombog = "Express Home";
                     comboBox4.Text = nombog;
                 }
                 if (comboBox4.Text == "12")
                 {
                     nombog = "Super Casa";
                     comboBox4.Text = nombog;
                 }
                 if (comboBox4.Text == "13")
                 {
                     nombog = "Super Ecomax";
                     comboBox4.Text = nombog;

                 }
                 if (comboBox4.Text == "14")
                 {
                     nombog = "Todo en Casa";
                     comboBox4.Text = nombog;
                 }
                 if (comboBox4.Text == "15")
                 {
                     nombog = "Rapishop";
                     comboBox4.Text = nombog;
                 }

            }
        }
        private void aparecercomandosdetalleingreso()
        {
            label6.Visible = true;
            label7.Visible = true;
            label13.Visible = true;
            label12.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            txtid.Visible = true;
            txtidprod.Visible = true;
            txtinicial.Visible = true;
            txtactual.Visible = true;
            txtfechacaducidad.Visible = true;
            comboBox4.Visible = true;
            txtingeresoproducto.Visible = true;
            txtpreciocompra.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            label10.Visible = true;
        }
        private void desaparecercomandosdetalleingreso()
        {
            label6.Visible = false;
            label7.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            txtid.Visible = false;
            txtidprod.Visible = false;
            txtinicial.Visible = false;
            txtactual.Visible = false;
            txtfechacaducidad.Visible = false;
            comboBox4.Visible = false;
            txtingeresoproducto.Visible = false;
            txtpreciocompra.Visible = false;
            button3.Visible = false;
            label10.Visible = false;
            textBox1.Visible = false;
        }

        private void FrmIngresoYDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet10.Personal' Puede moverla o quitarla según sea necesario.
            this.personalTableAdapter.Fill(this.altoValyrioDataSet10.Personal);
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet7.CategoriaProducto' Puede moverla o quitarla según sea necesario.
            this.categoriaProductoTableAdapter.Fill(this.altoValyrioDataSet7.CategoriaProducto);
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet6.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.altoValyrioDataSet6.Marca);
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet5.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValyrioDataSet5.Bodega);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            aparecercomandosdetalleingreso();
            GuardarIngresoprod();
            var opc = new OperacionProducto();
            opc.llenardataingreso(dataGridView4);
            txtid.Text = Convert.ToString(dataGridView4.CurrentRow.Cells["IdIngreso"].Value);
        }
        //guardar  ingresoproductos
        private void GuardarIngresoprod()
        {
            // MARCAS
            int idmarca = 0;
            if (cmMarca.Text == "SCOTT")
            {
                idmarca = 1;
            }
            if (cmMarca.Text == "COLGATE")
            {
                idmarca = 3;
            }
            if (cmMarca.Text == "GILLETTE")
            {
                idmarca = 7;
            }
            if (cmMarca.Text == "DANONE")
            {
                idmarca = 8;
            }
            if (cmMarca.Text == "KELLOWS")
            {
                idmarca = 9;
            }
            if (cmMarca.Text == "NESTLÉ")
            {
                idmarca = 10;
            }
            if (cmMarca.Text == "HELLMANN´S")
            {
                idmarca = 11;
            }
            if (cmMarca.Text == "BIMBO")
            {
                idmarca = 13;
            }
            if (cmMarca.Text == "UNILEVER")
            {
                idmarca = 14;
            }
            if (cmMarca.Text == "KERN´S")
            {
                idmarca = 15;
            }
            if (cmMarca.Text == "IDEAL")
            {
                idmarca = 16;
            }
            if (cmMarca.Text == "ANABELLY")
            {
                idmarca = 17;
            }
            if (cmMarca.Text == "PERRY")
            {
                idmarca = 18;
            }
            if (cmMarca.Text == "PREMIER")
            {
                idmarca = 19;
            }
            if (cmMarca.Text == "PURINA")
            {
                idmarca = 20;
            }
            if (cmMarca.Text == "INA")
            {
                idmarca = 21;
            }
            if (cmMarca.Text == "PARMA")
            {
                idmarca = 22;
            }
            if (cmMarca.Text == "DEL MONTE")
            {
                idmarca = 23;
            }
            if (cmMarca.Text == "DUCAL")
            {
                idmarca = 24;
            }
            if (cmMarca.Text == "MAZOLA")
            {
                idmarca = 25;
            }
            if (cmMarca.Text == "TANG")
            {
                idmarca = 27;
            }
            if (cmMarca.Text == "LALA")
            {
                idmarca = 28;
            }
            if (cmMarca.Text == "REGIA")
            {
                idmarca = 29;
            }
            if (cmMarca.Text == "ARIEL")
            {
                idmarca = 30;
            }
            if (cmMarca.Text == "TUCAN")
            {
                idmarca = 31;
            }
            if (cmMarca.Text == "PYG")
            {
                idmarca = 32;
            }
            if (cmMarca.Text == "DOVE")
            {
                idmarca = 34;
            }
            if (cmMarca.Text == "PROTEX")
            {
                idmarca = 35;
            }
            if (cmMarca.Text == "REXONA")
            {
                idmarca = 36;
            }
            if (cmMarca.Text == "OTRO")
            {
                idmarca = 37;
            }

            var idpersonal = Convert.ToInt32(comboBox2.SelectedValue);

            //generar ingresoproducto
            var Ingresonuevoprod = new IngresoProducto()
            {
                IdFechaIngreso = Convert.ToDateTime(txtfechaingreso.Text),
                IdMarca = idmarca,
                IdPersonal = idpersonal
            };
            AgregarIngresoProd(Ingresonuevoprod);
            textBox1.Text= txtfechaingreso.Text;
        }

        //llena la tabla ingresoproducto
        private void AgregarIngresoProd(IngresoProducto prod)
        {
            try
            {
                //conectionstring cadena de instrucciones para conectarse a la base de datos
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //sql stuctured querly 
                    //insert into *NOMBRE DE LA TABLA* values(pasan los parametros y se manda la conexión)
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO IngresoProductos VALUES (@IdPersonal,@IdMarca,@Fecha_Ingreso)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("IdPersonal", prod.IdPersonal));
                    insertCommand.Parameters.Add(new SqlParameter("IdMarca", prod.IdMarca));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Ingreso", prod.IdFechaIngreso));
                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lee datos del stock
            int sumadatos = 0;
            sumadatos = int.Parse(txtingeresoproducto.Text);
            if (txtactual.Text == "" && txtinicial.Text == "")
            {
                txtinicial.Text = Convert.ToString(sumadatos);
                txtactual.Text = Convert.ToString(sumadatos);
                comboBox4.Enabled = true;

                GuardaDetalleprod();
            }
            else if (txtactual.Text == "0" && txtinicial.Text == "0")
            {
                txtinicial.Text = Convert.ToString(sumadatos);
                txtactual.Text = Convert.ToString(sumadatos);

                ActualizarDetallesdeIngresoporcantidad();
            }
            else
            {
                int datact = 0;
                datact = int.Parse(txtactual.Text);
                int total = 0;
                total = datact + sumadatos;
                txtactual.Text = Convert.ToString(total);


                ActualizarDetallesdeIngresoporcantidad();
            }
           
            txtingeresoproducto.Text = "";
            txtnombreprod.Text = "";
            txtfechaingreso.Text = "";
            desaparecercomandosdetalleingreso();
            comboBox4.Enabled = false;
        }
        private void GuardaDetalleprod()
        {
            var Idbodega = Convert.ToInt32(comboBox4.SelectedValue);

            var detingre = new DetalleIngreso()
            {
                IdBodega = Idbodega,
                IdProducto = int.Parse(txtidprod.Text),
                IdIngreso = int.Parse(txtid.Text),
                Precio_Compra = Convert.ToInt32(txtpreciocompra.Text),
                Stock_Actual = int.Parse(txtactual.Text),
                Stock_Inicial = int.Parse(txtinicial.Text),
                Fecha_Caducidad = Convert.ToDateTime(txtfechacaducidad.Text),
                Fecha_Ingreso = textBox1.Text

            };
            AgregarDetalle(detingre);

        }

        //llena detalleingresoproducto
        private void AgregarDetalle(DetalleIngreso prod)
        {
            try
            {
                //conectionstring cadena de instrucciones para conectarse a la base de datos
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //sql stuctured querly 
                    //insert into *NOMBRE DE LA TABLA* values(pasan los parametros y se manda la conexión)
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO DetallesIngreso VALUES (@IdIngreso,@IdBodega,@IdProducto,@Precio_Compra,@Stock_Inicial,@Stock_Actual,@Fecha_Caducidad,@Fecha_Ingreso)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("IdBodega", prod.IdBodega));
                    insertCommand.Parameters.Add(new SqlParameter("IdProducto", prod.IdProducto));
                    insertCommand.Parameters.Add(new SqlParameter("Precio_Compra", prod.Precio_Compra));
                    insertCommand.Parameters.Add(new SqlParameter("IdIngreso", prod.IdIngreso));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Inicial", prod.Stock_Inicial));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Actual", prod.Stock_Actual));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Caducidad", prod.Fecha_Caducidad));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Ingreso", prod.Fecha_Ingreso));

                    insertCommand.ExecuteScalar();
                    MessageBox.Show("NUEVO PRODUCTO AGREGADO EXITOSAMENTE");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //actualiza tabla detalleingresoproducto si existe
        private void ActualizarDetallesdeIngresoporcantidad()
        {
            try
            {
                //conectionstring cadena de instrucciones para conectarse a la base de datos
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //sql stuctured querly 
                    //insert into *NOMBRE DE LA TABLA* values(pasan los parametros y se manda la conexión)
                    SqlCommand insertCommand = new SqlCommand("" +
                        "UPDATE DetallesIngreso SET " +// IdIngreso= @IdIngreso," +
                        "IdBodega = @IdBodega," +
                        "Precio_Compra = @Precio_Compra," +
                        "Stock_Inicial = @Stock_Inicial," +
                        "Stock_Actual = @Stock_Actual," +
                        
                        "Fecha_Caducidad = @Fecha_Caducidad,"+
                        "Fecha_Ingreso=@Fecha_Ingreso"+
                        " WHERE IdProducto = @IdProducto", conn);
                    var Idbodega = Convert.ToInt32(comboBox4.SelectedValue);



                    var detingreso = new DetalleIngreso
                    {
                        IdBodega = Idbodega,
                        IdProducto = int.Parse(txtidprod.Text),
                        // IdIngreso=int.Parse(txtid.Text),
                        Precio_Compra = Convert.ToInt32(txtpreciocompra.Text),
                        Stock_Actual = int.Parse(txtactual.Text),
                        Stock_Inicial = int.Parse(txtinicial.Text),
                        Fecha_Caducidad = Convert.ToDateTime(txtfechacaducidad.Text),
                        Fecha_Ingreso=textBox1.Text
                        
                    };


                    // insertCommand.Parameters.Add(new SqlParameter("IdIngreso", detingreso.IdIngreso));
                    insertCommand.Parameters.Add(new SqlParameter("IdBodega", detingreso.IdBodega));
                    insertCommand.Parameters.Add(new SqlParameter("Precio_Compra", detingreso.Precio_Compra));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Inicial", detingreso.Stock_Inicial));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Actual", detingreso.Stock_Actual));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Caducidad", detingreso.Fecha_Caducidad));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Ingreso", detingreso.Fecha_Ingreso));

                    insertCommand.Parameters.Add(new SqlParameter("IdProducto", detingreso.IdProducto));
                    insertCommand.ExecuteScalar();
                    MessageBox.Show("Datos Guardados con exito");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

    }
}
