using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIIIAltoValyrio.Class
{
    public class DetalleIngreso
    {
        public int? IdDetalle_Ingreso { get; set; }
        public int? IdIngreso { get; set; }
        public int IdBodega { get; set; }
        public int IdProducto { get; set; }
        public int Precio_Compra { get; set; }
        public int Stock_Inicial { get; set; }
        public int Stock_Actual { get; set; }
        public DateTime Fecha_Caducidad { get; set; }
        public string Fecha_Ingreso { get; set; }

    }
}
