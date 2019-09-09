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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var UsNew = new FrmCrearUsuario(this))
            {
                UsNew.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox5.Text=="" & textBox6.Text=="")
            {
                MessageBox.Show("Campos Sin llenar", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            Login(this.textBox5.Text, Convert.ToInt32(this.textBox6.Text));
        }
        public void Login(string Nombre, int No_Gafete)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                
                 conn.ConnectionString =Conectar.cnn;
                 conn.Open();
                SqlCommand Conex = new SqlCommand("SELECT Nombre, TipoUsuario, IdBodega FROM Personal WHERE Nombre = @Nombre AND No_Gafete = @NoGafete", conn);
                Conex.Parameters.AddWithValue("Nombre", Nombre);
                Conex.Parameters.AddWithValue("NoGafete", No_Gafete);

                SqlDataAdapter da = new SqlDataAdapter(Conex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                   
                    new FrmBienvenida(dt.Rows[0][0].ToString().ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][1].ToString()).Show();
                    
                  
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
