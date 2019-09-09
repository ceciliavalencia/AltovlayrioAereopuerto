using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIIIAltoValyrio.Class;
using PIIIAltoValyrio.Operaciones;
using System.Data.SqlClient;

namespace PIIIAltoValyrio
{
    public partial class FrmReportes : Form
    {

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'altoValyrioDataSet5.Bodega' table. You can move, or remove it, as needed.
            this.bodegaTableAdapter.Fill(this.altoValyrioDataSet11.Bodega);

        }


        private void llenaGrid(object sender, EventArgs e)
        {
            var opc = new OperacionProducto();
            var nombre = Convert.ToInt16(comboBox1.SelectedValue);

            opc.gridReporte(nombre, dataGridView1);

        }
    }
}
