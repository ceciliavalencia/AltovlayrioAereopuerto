using PIIIAltoValyrio.Class;
using PIIIAltoValyrio.Operaciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIIIAltoValyrio.Operaciones;


namespace PIIIAltoValyrio
{
    public partial class FrmBorrarTraslado : Form
    {
        ArrayList arreglo = new ArrayList();
        public static int id;
        public FrmBorrarTraslado()
        {
            InitializeComponent();
            var opc = new OperacionProducto();
            //opc.gridBorrar(dataGridView1);

        }

        private void FrmBorrarTraslado_Load(object sender, EventArgs e)
        {

        }
        

        private void prueba(object sender, DataGridViewCellEventArgs e)
        {
            
            id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["idBitacora"].Value);
            
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var opc = new OperacionProducto();
            Console.WriteLine(id);
            dataGridView1.Refresh();
            opc.borraBitacora(Convert.ToInt16(id), dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opc = new OperacionProducto();
            string fecha = dateTimePicker1.Text;
            opc.buscarBitacora(fecha, dataGridView1);

        }
    }
}
