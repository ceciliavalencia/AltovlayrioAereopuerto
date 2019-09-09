using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIIIAltoValyrio.Operaciones;

namespace PIIIAltoValyrio
{
    public partial class FrmReporteBit : Form
    {
        public FrmReporteBit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Refresh();
            var opc = new OperacionProducto();
            opc.gridReporteBit(dataGridView3);
        }
    }
}
