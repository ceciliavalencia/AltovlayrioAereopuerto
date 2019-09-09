using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIIIAltoValyrio
{
    public partial class FrmBienvenida : Form
    {
        public int IdBodega = 0;
        public string TipoUsiario;

        public FrmBienvenida()
        {
            InitializeComponent();

            this.CenterToScreen();

        }
        public FrmBienvenida(string nombre, string bod, string tip)
        {
            InitializeComponent();
            label1.Text = "Colaborador:  " + nombre;
            label2.Text = bod;
            label3.Text = tip;
            TipoUsiario = label3.Text;
            IdBodega = int.Parse(label2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            this.Close();
            var intera = new AltoValyrio(TipoUsiario,IdBodega);
            intera.Show();
           
            

        }
    }
}
