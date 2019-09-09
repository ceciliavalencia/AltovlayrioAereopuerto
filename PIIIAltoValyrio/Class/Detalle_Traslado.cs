using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIIIAltoValyrio.Class
{
    public class Detalle_Traslado
    {
        public int? IdDetalle_Traslado { get; set; }
        public int IdTraslado { get; set; }
        public int IdBodega { get; set; }
        public int IdDetalle_Ingreso { get; set; }
        public int Cantidad { get; set; }
    }
}
