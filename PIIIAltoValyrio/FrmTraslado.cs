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
    public partial class FrmTraslado : Form
    {
        public FrmTraslado()
        {
            InitializeComponent();
            var opc = new OperacionProducto();
            opc.llenardata(dataGridView3);
            AutoScroll = true;

        }

        private void FrmTraslado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet9.Personal' Puede moverla o quitarla según sea necesario.
            this.personalTableAdapter.Fill(this.altoValyrioDataSet9.Personal);
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet8.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValyrioDataSet8.Bodega);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opc = new OperacionProducto();
            opc.llenardata(dataGridView3);

            var idbodega = (Convert.ToInt32(comboBox4.SelectedValue));
            string pro = Convert.ToString(idbodega);
            label3.Text = pro;
            foreach (DataGridViewRow Row in dataGridView3.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["IdBodega"].Value);

                if (Valor == label3.Text)
                {
                    dataGridView3.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.MediumPurple;
                }
            }
        }

        private void txtnombreprod_TextChanged(object sender, EventArgs e)
        {
            var opc = new OperacionProducto();
            opc.llenardata(dataGridView3);
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
            if (txtnombreprod.Text == "")
            {

                opc.llenardata(dataGridView3);
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
            int devprod = 0;
            int marca = 0;
            txtidprod.Text = Convert.ToString(dataGridView3.CurrentRow.Cells["IdProducto"].Value);
            nombog = Convert.ToInt32(dataGridView3.CurrentRow.Cells["IdBodega"].Value);
            devprod = Convert.ToInt32(dataGridView3.CurrentRow.Cells["IdCategoria"].Value);
            marca = Convert.ToInt32(dataGridView3.CurrentRow.Cells["IdMarca"].Value);


            //validar combobox de acuerdo a la bodega
            if (nombog == 11)
            {
                comboBox2.Text = "Express Home";
            }
            if (nombog == 12)
            {
                comboBox2.Text = "Super Casa";
            }
            if (nombog == 13)
            {
                comboBox2.Text = "Super Ecomax";
            }
            if (nombog == 14)
            {
                comboBox2.Text = "Todo en Casa";
            }
            if (nombog == 15)
            {
                comboBox2.Text = "Rapishop";
            }


            //validar datos de acuerdo a idmarca

            if (devprod == 1)
            {
                comboBox1.Text = "Granos";
            }
            if (devprod == 2)
            {
                comboBox1.Text = "Pastas";
            }
            if (devprod == 3)
            {

                comboBox1.Text = "Lacteos";
            }
            if (devprod == 4)
            {
                comboBox1.Text = "Bebidas";

            }
            if (devprod == 5)
            {
                comboBox1.Text = "Carniceria";
            }
            if (devprod == 6)
            {
                comboBox1.Text = "Higiene";
            }
            if (devprod == 7)
            {
                comboBox1.Text = "Librería";
            }
            if (devprod == 8)
            {
                comboBox1.Text = "Jardinería";
            }
            if (devprod == 9)
            {
                comboBox1.Text = "Mascotas";
            }
            if (devprod == 11)
            {
                comboBox1.Text = "Prod. Enlatados";
            }
            if (devprod == 12)
            {
                comboBox1.Text = "Especias";
            }
            if (devprod == 13)
            {
                comboBox1.Text = "Panaderia";
            }
            if (devprod == 14)
            {
                comboBox1.Text = "Ropa";
            }
            if (devprod == 15)
            {
                comboBox1.Text = "Accesorios";
            }
            if (devprod == 16)
            {
                comboBox1.Text = "Prod. Hogar";
            }
            if (devprod == 17)
            {
                comboBox1.Text = "Limpieza";
            }
            if (devprod == 18)
            {
                comboBox1.Text = "Herramientas";
            }
            if (devprod == 26)
            {
                comboBox1.Text = "Otro.";
            }
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


            ObtenerDatosDetalleTaslado();
        }
        private void ObtenerDatosDetalleTaslado()
        {
            var dsIDProducDetalleTraslado = new DataSet();
            var operaciones = new OperacionProducto();
            dsIDProducDetalleTraslado = operaciones.BuscarDetalleIngreso(Convert.ToInt32(txtidprod.Text));
            LLenarCampostxtstraslado(dsIDProducDetalleTraslado);

            if (txtactual.Text == "" && txtinicial.Text == "")
            {
                MessageBox.Show("NO SE PUEDE HACER TRASLADO DEBIDO A QUE NO HAY STOCK \n PONGASE EN CONTACTO CON LOS BODEGUEROS O SELECCIONE OTRO PRODUCTO", "NO SE PUEDE REALIZAR TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtactual.Text == "0" && txtinicial.Text == "0")
            {
                MessageBox.Show("NO SE PUEDE HACER TRASLADO DEBIDO A QUE NO HAY STOCK \n PONGASE EN CONTACTO CON LOS BODEGUEROS O SELECCIONE OTRO PRODUCTO", "NO SE PUEDE REALIZAR TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void resta()
        {
            //lee datos del stock
            int restadatos = 0;
            restadatos = int.Parse(txtingeresoproducto.Text);
            int datact = 0;
            datact = int.Parse(txtactual.Text);


            int total = 0;
            total = datact - restadatos;
            txtactual.Text = Convert.ToString(total);


            ActualizarDetallesdeIngresoporcantidad();
        }

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
                        "Fecha_Caducidad = @Fecha_Caducidad" +
                        " WHERE IdProducto = @IdProducto", conn);
                    int nombog = 0;
                    //validar combobox de acuerdo a la bodega
                    if (cmbbodega.Text == "Express Home")
                    {
                        nombog = 11;
                    }
                    if (cmbbodega.Text == "Super Casa")
                    {
                        nombog = 12;
                    }
                    if (cmbbodega.Text == "Super Ecomax")
                    {
                        nombog = 13;
                    }
                    if (cmbbodega.Text == "Todo en Casa")
                    {
                        nombog = 14;
                    }
                    if (cmbbodega.Text == "Rapishop")
                    {
                        nombog = 15;
                    }



                    var detingreso = new DetalleIngreso
                    {
                        IdBodega = nombog,
                        IdProducto = int.Parse(txtidprod.Text),

                        Precio_Compra = Convert.ToInt32(txtpreciocompra.Text),
                        Stock_Actual = int.Parse(txtactual.Text),
                        Stock_Inicial = int.Parse(txtinicial.Text),
                        Fecha_Caducidad = Convert.ToDateTime(txtfechacaducidad.Text)
                    };


                    // insertCommand.Parameters.Add(new SqlParameter("IdIngreso", detingreso.IdIngreso));
                    insertCommand.Parameters.Add(new SqlParameter("IdBodega", detingreso.IdBodega));
                    insertCommand.Parameters.Add(new SqlParameter("Precio_Compra", detingreso.Precio_Compra));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Inicial", detingreso.Stock_Inicial));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Actual", detingreso.Stock_Actual));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Caducidad", detingreso.Fecha_Caducidad));
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
        private void LLenarCampostxtstraslado(DataSet dsIDProducDetalleIngreso)
        {

            string nombog;
            foreach (DataRow informacion in dsIDProducDetalleIngreso.Tables[0].Rows)
            {
                txtiddetalle.Text = informacion["IdDetalle_Ingreso"].ToString();
                txtpreciocompra.Text = informacion["Precio_Compra"].ToString();
                txtactual.Text = informacion["Stock_Actual"].ToString();
                txtinicial.Text = informacion["Stock_Inicial"].ToString();
                txtfechacaducidad.Text = informacion["Fecha_Caducidad"].ToString();
                textBox7.Text = informacion["Fecha_Ingreso"].ToString();
                comboBox4.Text = informacion["IdBodega"].ToString();


                //validar combobox de acuerdo a la bodega
                if (comboBox2.Text == "11")
                {
                    nombog = "Express Home";
                    comboBox2.Text = nombog;
                }
                if (comboBox2.Text == "12")
                {
                    nombog = "Super Casa";
                    comboBox2.Text = nombog;
                }
                if (comboBox2.Text == "13")
                {
                    nombog = "Super Ecomax";
                    comboBox2.Text = nombog;

                }
                if (comboBox2.Text == "14")
                {
                    nombog = "Todo en Casa";
                    comboBox2.Text = nombog;
                }
                if (comboBox2.Text == "15")
                {
                    nombog = "Rapishop";
                    comboBox2.Text = nombog;
                }

            }
        }
        private void GuardarTraslado()
        {
            int devprod = 0;
            if (comboBox1.Text == "Granos")
            {
                devprod = 1;
            }
            if (comboBox1.Text == "Pastas")
            {
                devprod = 2;
            }
            if (comboBox1.Text == "Lacteos")
            {
                devprod = 3;
            }
            if (comboBox1.Text == "Bebidas")
            {
                devprod = 4;

            }
            if (comboBox1.Text == "Carniceria")
            {
                devprod = 5;
            }
            if (comboBox1.Text == "Higiene")
            {
                devprod = 6;
            }
            if (comboBox1.Text == "Librería")
            {
                devprod = 7;
            }
            if (comboBox1.Text == "Jardinería")
            {
                devprod = 8;
            }
            if (comboBox1.Text == "Mascotas")
            {
                devprod = 9;
            }
            if (comboBox1.Text == "Prod. Enlatados")
            {
                devprod = 11;
            }
            if (comboBox1.Text == "Especias")
            {
                devprod = 12;
            }
            if (comboBox1.Text == "Panaderia")
            {
                devprod = 13;
            }
            if (comboBox1.Text == "Ropa")
            {
                devprod = 14;
            }
            if (comboBox1.Text == "Accesorios")
            {
                devprod = 15;
            }
            if (comboBox1.Text == "Prod. Hogar")
            {
                devprod = 16;
            }
            if (comboBox1.Text == "Limpieza")
            {
                devprod = 17;
            }
            if (comboBox1.Text == "Herramientas")
            {
                devprod = 18;
            }
            if (comboBox1.Text == "Otro.")
            {
                devprod = 26;
            }
            var idpersonal=Convert.ToInt32(comboBox5.SelectedValue);
            //generar ingresoproducto
            var ingtras = new Traslado()
            {
                IdCategoria = devprod,
                Fecha = Convert.ToDateTime(txtfechaingreso.Text),
                IdPersonal = idpersonal
            };
            AgregarTraslado(ingtras);
        }

        //llena la tabla ingresoproducto
        private void AgregarTraslado(Traslado prod)
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
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Traslado VALUES (@IdPersonal,@IdCategoria,@Fecha)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("IdPersonal", prod.IdPersonal));
                    insertCommand.Parameters.Add(new SqlParameter("IdCategoria", prod.IdCategoria));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha", prod.Fecha));
                    insertCommand.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void cmbbodega_TextChanged(object sender, EventArgs e)
        {
            var opc = new OperacionProducto();
            opc.llenardata(dataGridView1);
            var idbodega = (Convert.ToInt32(cmbbodega.SelectedValue));
            string pro = Convert.ToString(idbodega);
            label20.Text = pro;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["IdBodega"].Value);

                if (Valor == label20.Text)
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            valida();
            string fech;
            fech = txtfechaingreso.Text;
            textBox2.Text = txtfechacaducidad.Text;
            groupBox1.Visible=true;
            //limpiar datos
            // textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";



            //recogevalor de id 
            int nombog = 0;
            int devprod = 0;
            int marca = 0;
            textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["IdProducto"].Value);
            nombog = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdBodega"].Value);
            devprod = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCategoria"].Value);
            marca = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdMarca"].Value);

            //validar combobox de acuerdo a la bodega
            if (nombog == 11)
            {
                comboBox3.Text = "Express Home";
            }
            if (nombog == 12)
            {
                comboBox3.Text = "Super Casa";
            }
            if (nombog == 13)
            {
                comboBox3.Text = "Super Ecomax";
            }
            if (nombog == 14)
            {
                comboBox3.Text = "Todo en Casa";
            }
            if (nombog == 15)
            {
                comboBox3.Text = "Rapishop";
            }


            //validar datos de acuerdo a idmarca

            if (devprod == 1)
            {
                comboBox1.Text = "Granos";
            }
            if (devprod == 2)
            {
                comboBox1.Text = "Pastas";
            }
            if (devprod == 3)
            {

                comboBox1.Text = "Lacteos";
            }
            if (devprod == 4)
            {
                comboBox1.Text = "Bebidas";

            }
            if (devprod == 5)
            {
                comboBox1.Text = "Carniceria";
            }
            if (devprod == 6)
            {
                comboBox1.Text = "Higiene";
            }
            if (devprod == 7)
            {
                comboBox1.Text = "Librería";
            }
            if (devprod == 8)
            {
                comboBox1.Text = "Jardinería";
            }
            if (devprod == 9)
            {
                comboBox1.Text = "Mascotas";
            }
            if (devprod == 11)
            {
                comboBox1.Text = "Prod. Enlatados";
            }
            if (devprod == 12)
            {
                comboBox1.Text = "Especias";
            }
            if (devprod == 13)
            {
                comboBox1.Text = "Panaderia";
            }
            if (devprod == 14)
            {
                comboBox1.Text = "Ropa";
            }
            if (devprod == 15)
            {
                comboBox1.Text = "Accesorios";
            }
            if (devprod == 16)
            {
                comboBox1.Text = "Prod. Hogar";
            }
            if (devprod == 17)
            {
                comboBox1.Text = "Limpieza";
            }
            if (devprod == 18)
            {
                comboBox1.Text = "Herramientas";
            }
            if (devprod == 26)
            {
                comboBox1.Text = "Otro.";
            }
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
            dsIDProducDetalleIngreso = operaciones.BuscarDetalleIngreso(Convert.ToInt32(textBox6.Text));
            LLenarCampostxts(dsIDProducDetalleIngreso);

        }

        //llena los datos de detalle ingreso si existe.
        private void LLenarCampostxts(DataSet dsIDProducDetalleIngreso)
        {

            string nombog;
            foreach (DataRow informacion in dsIDProducDetalleIngreso.Tables[0].Rows)
            {
                textBox5.Text = informacion["Precio_Compra"].ToString();
                textBox4.Text = informacion["Stock_Actual"].ToString();
                textBox3.Text = informacion["Stock_Inicial"].ToString();
                textBox2.Text = informacion["Fecha_Caducidad"].ToString();
                comboBox3.Text = informacion["IdBodega"].ToString();


                //validar combobox de acuerdo a la bodega
                if (comboBox3.Text == "11")
                {
                    nombog = "Express Home";
                    comboBox3.Text = nombog;
                }
                if (comboBox3.Text == "12")
                {
                    nombog = "Super Casa";
                    comboBox3.Text = nombog;
                }
                if (comboBox3.Text == "13")
                {
                    nombog = "Super Ecomax";
                    comboBox3.Text = nombog;

                }
                if (comboBox3.Text == "14")
                {
                    nombog = "Todo en Casa";
                    comboBox3.Text = nombog;
                }
                if (comboBox3.Text == "15")
                {
                    nombog = "Rapishop";
                    comboBox3.Text = nombog;
                }

            }
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
            var idpersonal = Convert.ToInt32(comboBox5.SelectedValue);
            //generar ingresoproducto
            var Ingresonuevoprod = new IngresoProducto()
            {
                IdFechaIngreso = Convert.ToDateTime(txtfechaingreso.Text),
                IdMarca = idmarca,
                IdPersonal = idpersonal
            };
            AgregarIngresoProd(Ingresonuevoprod);

        }
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
        private void valida()
        {
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            comboBox3.Visible = true;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            valida();
            GuardarIngresoprod();
            resta();
            var opc = new OperacionProducto();
            opc.llenardataingreso(dataGridView2);
            textBox1.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["IdIngreso"].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sumadatos = 0;
            sumadatos = int.Parse(txtingeresoproducto.Text);
            if (textBox4.Text == "" && textBox3.Text == "")
            {
                textBox3.Text = Convert.ToString(sumadatos);
                textBox4.Text = Convert.ToString(sumadatos);
                comboBox4.Enabled = true;

                GuardaDetalleprod();
            }
            else if (textBox4.Text == "0" && textBox3.Text == "0")
            {
                textBox3.Text = Convert.ToString(sumadatos);
                textBox4.Text = Convert.ToString(sumadatos);

                ActualizarDetallesdeIngresoporcantidadportraslado();
            }
            else
            {
                int datact = 0;
                datact = int.Parse(textBox4.Text);
                int total = 0;
                total = datact + sumadatos;
                textBox4.Text = Convert.ToString(total);


                ActualizarDetallesdeIngresoporcantidadportraslado();
            }

            llenarbitacora();
        }
        private void ActualizarDetallesdeIngresoporcantidadportraslado()
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
                        "Fecha_Caducidad = @Fecha_Caducidad" +
                        " WHERE IdProducto = @IdProducto", conn);
                    int nombog = 0;
                    //validar combobox de acuerdo a la bodega
                    if (comboBox3.Text == "Express Home")
                    {
                        nombog = 11;
                    }
                    if (comboBox3.Text == "Super Casa")
                    {
                        nombog = 12;
                    }
                    if (comboBox3.Text == "Super Ecomax")
                    {
                        nombog = 13;
                    }
                    if (comboBox3.Text == "Todo en Casa")
                    {
                        nombog = 14;
                    }
                    if (comboBox3.Text == "Rapishop")
                    {
                        nombog = 15;
                    }



                    var detingreso = new DetalleIngreso
                    {
                        IdBodega = nombog,
                        IdProducto = int.Parse(textBox6.Text),

                        Precio_Compra = Convert.ToInt32(textBox5.Text),
                        Stock_Actual = int.Parse(textBox4.Text),
                        Stock_Inicial = int.Parse(textBox3.Text),
                        Fecha_Caducidad = Convert.ToDateTime(textBox2.Text),
                        Fecha_Ingreso=textBox8.Text
                    };


                    // insertCommand.Parameters.Add(new SqlParameter("IdIngreso", detingreso.IdIngreso));
                    insertCommand.Parameters.Add(new SqlParameter("IdBodega", detingreso.IdBodega));
                    insertCommand.Parameters.Add(new SqlParameter("Precio_Compra", detingreso.Precio_Compra));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Inicial", detingreso.Stock_Inicial));
                    insertCommand.Parameters.Add(new SqlParameter("Stock_Actual", detingreso.Stock_Actual));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Caducidad", detingreso.Fecha_Caducidad));
                    insertCommand.Parameters.Add(new SqlParameter("IdProducto", detingreso.IdProducto));
                    insertCommand.Parameters.Add(new SqlParameter("Fecha_Ingreso", detingreso.Fecha_Ingreso));
                    insertCommand.ExecuteScalar();
                    MessageBox.Show("ACTUALIZADO");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }


        private void GuardaDetalleprod()
        {
            int nombog = 0;
            //validar combobox de acuerdo a la bodega
            if (comboBox3.Text == "Express Home")
            {
                nombog = 11;
            }
            if (comboBox3.Text == "Super Casa")
            {
                nombog = 12;
            }
            if (comboBox3.Text == "Super Ecomax")
            {
                nombog = 13;
            }
            if (comboBox3.Text == "Todo en Casa")
            {
                nombog = 14;
            }
            if (comboBox3.Text == "Rapishop")
            {
                nombog = 15;
            }



            var detingre = new DetalleIngreso()
            {
                IdBodega = nombog,
                IdProducto = int.Parse(textBox6.Text),
                IdIngreso = int.Parse(textBox1.Text),
                Precio_Compra = Convert.ToInt32(textBox5.Text),
                Stock_Actual = int.Parse(textBox4.Text),
                Stock_Inicial = int.Parse(textBox3.Text),
                Fecha_Caducidad = Convert.ToDateTime(textBox2.Text),
                Fecha_Ingreso=textBox8.Text


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
                    MessageBox.Show("ACTUALIZADO EXITOSAMENTE");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        private void llenarbitacora()
        {
            var idpersonal = Convert.ToInt32(comboBox5.SelectedValue);

            int nombog = 0;
            int devprod = 0;
            int nombogfinal = 0;
            //validar combobox de acuerdo a la bodega
            if (comboBox3.Text == "Express Home")
            {
                nombogfinal = 11;
            }
            if (comboBox3.Text == "Super Casa")
            {
                nombogfinal = 12;
            }
            if (comboBox3.Text == "Super Ecomax")
            {
                nombogfinal = 13;
            }
            if (comboBox3.Text == "Todo en Casa")
            {
                nombogfinal = 14;
            }
            if (comboBox3.Text == "Rapishop")
            {
                nombogfinal = 15;
            }


            //validar combobox de acuerdo a la bodega inicial
            if (comboBox2.Text == "Express Home")
            {
                nombog = 11;
            }
            if (comboBox2.Text == "Super Casa")
            {
                nombog = 12;
            }
            if (comboBox2.Text == "Super Ecomax")
            {
                nombog = 13;
            }
            if (comboBox2.Text == "Todo en Casa")
            {
                nombog = 14;
            }
            if (comboBox2.Text == "Rapishop")
            {
                nombog = 15;
            }



            //validar datos de acuerdo a idmarca

            if (comboBox1.Text == "Granos")
            {
                devprod = 1;
            }
            if (comboBox1.Text == "Pastas")
            {
                devprod = 2;
            }
            if (comboBox1.Text == "Lacteos")
            {
                devprod = 3;
            }
            if (comboBox1.Text == "Bebidas")
            {
                devprod = 4;

            }
            if (comboBox1.Text == "Carniceria")
            {
                devprod = 5;
            }
            if (comboBox1.Text == "Higiene")
            {
                devprod = 6;
            }
            if (comboBox1.Text == "Librería")
            {
                devprod = 7;
            }
            if (comboBox1.Text == "Jardinería")
            {
                devprod = 8;
            }
            if (comboBox1.Text == "Mascotas")
            {
                devprod = 9;
            }
            if (comboBox1.Text == "Prod. Enlatados")
            {
                devprod = 11;
            }
            if (comboBox1.Text == "Especias")
            {
                devprod = 12;
            }
            if (comboBox1.Text == "Panaderia")
            {
                devprod = 13;
            }
            if (comboBox1.Text == "Ropa")
            {
                devprod = 14;
            }
            if (comboBox1.Text == "Accesorios")
            {
                devprod = 15;
            }
            if (comboBox1.Text == "Prod. Hogar")
            {
                devprod = 16;
            }
            if (comboBox1.Text == "Limpieza")
            {
                devprod = 17;
            }
            if (comboBox1.Text == "Herramientas")
            {
                devprod = 18;
            }
            if (comboBox1.Text == "Otro.")
            {
                devprod = 26;
            }


            var tras = new BitacoraTraslado()
            {
                IdCategoria = devprod,
                IdPersonal = idpersonal,
                IdProductoBDInicio = int.Parse(txtidprod.Text),
                IdProductoBDDestino = int.Parse(textBox6.Text),
                IdBodega = nombog,
                IdBodegaFinal = nombogfinal,
                FechaIngreso = Convert.ToDateTime(textBox7.Text),
                FechaTraslado =Convert.ToDateTime(textBox8.Text),
                Cantidad = int.Parse(txtingeresoproducto.Text)

            };
            AgregarBitacota(tras);

        }
        private void AgregarBitacota(BitacoraTraslado prod)
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
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO BitacoraTraslado VALUES (@IdCategoria,@IdPersonal," +
                        "@IdProductoBDInicio,@IdBodega,@FechaIngreso,@Cantidad,@IdProductoBDDestino," +
                        "@IdBodegaFinal,@FechaTraslado)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("IdCategoria", prod.IdCategoria));
                    insertCommand.Parameters.Add(new SqlParameter("IdPersonal", prod.IdPersonal));
                    insertCommand.Parameters.Add(new SqlParameter("IdProductoBDInicio", prod.IdProductoBDInicio));
                    insertCommand.Parameters.Add(new SqlParameter("IdBodega", prod.IdBodega));
                    insertCommand.Parameters.Add(new SqlParameter("FechaIngreso", prod.FechaIngreso));
                    insertCommand.Parameters.Add(new SqlParameter("Cantidad", prod.Cantidad));
                    insertCommand.Parameters.Add(new SqlParameter("IdProductoBDDestino", prod.IdProductoBDDestino));
                    insertCommand.Parameters.Add(new SqlParameter("IdBodegaFinal", prod.IdBodegaFinal));
                    insertCommand.Parameters.Add(new SqlParameter("FechaTraslado", prod.FechaTraslado));
                    insertCommand.ExecuteScalar();
                    MessageBox.Show("PARA VER EL REPORTE DE TRASLADO DIRIJASE A LA PESTAÑA TRASLADO Y SELECCIONE REPORTE \n", " TRASLADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            textBox8.Text=txtfechaingreso.Text;
            GuardarTraslado();


            var opc = new OperacionProducto();
            opc.llenardatatraslado(dataGridView4);
            txtid.Text = Convert.ToString(dataGridView4.CurrentRow.Cells["IdTraslado"].Value);
        }
    }
}
