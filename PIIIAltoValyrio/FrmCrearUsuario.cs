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
    public partial class FrmCrearUsuario : Form
    {
        private Form1 Form1;

        public FrmCrearUsuario(Form1 form1)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Form1 = form1;
            AutoScroll = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Idbodega = Convert.ToInt32(cmbBodega.SelectedValue);
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();
                    var usuario = new Personal();
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.No_Gafete = int.Parse(txtGafete.Text);
                    usuario.DPI = int.Parse(txtDPI.Text);
                    usuario.Sexo = comboBox1.Text;
                    usuario.Fecha_Nacimiento = dateTimePicker1.Text;
                    usuario.TipoUsuario = cmbTipUs.Text;
                    usuario.IdBodega = Idbodega;

                    SqlCommand Insertar = new SqlCommand("INSERT INTO Personal Values" +
                        "(@Nombre, @Apellido, @Sexo, @Fecha_Nacimiento, @DPI, @No_Gafete, @IdBodega, @TipoUsuario)", conn);

                    Insertar.Parameters.Add(new SqlParameter("Nombre", usuario.Nombre));
                    Insertar.Parameters.Add(new SqlParameter("Apellido", usuario.Apellido));
                    Insertar.Parameters.Add(new SqlParameter("Sexo", usuario.Sexo));
                    Insertar.Parameters.Add(new SqlParameter("Fecha_Nacimiento", usuario.Fecha_Nacimiento));
                    Insertar.Parameters.Add(new SqlParameter("DPI", usuario.DPI));
                    Insertar.Parameters.Add(new SqlParameter("No_Gafete", usuario.No_Gafete));
                    Insertar.Parameters.Add(new SqlParameter("IdBodega", usuario.IdBodega));
                    Insertar.Parameters.Add(new SqlParameter("TipoUsuario", usuario.TipoUsuario));
                    Insertar.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            MessageBox.Show("Datos Creados Correctamente", " GUARDADO ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValyrioDataSet.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValyrioDataSet.Bodega);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipUs.Text == "Administrador")
            {
                textBox1.Visible = true;
                button3.Visible = true;
                button2.Visible = false;


            }
            if (cmbTipUs.Text == "Bodeguero")
            {
                button2.Visible = true;
                textBox1.Visible = false;
                button3.Visible = false;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("DATOS ERRONEOS \nREGISTRESE COMO BODEGUERO");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
