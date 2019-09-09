using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIIIAltoValyrio.Class
{
    public class BitacoraTraslado
    {
        public int? IdTraslado { get; set; }
        public int IdCategoria { get; set; }
        public int IdPersonal { get; set; }
        public int IdProductoBDInicio { get; set; }
        public int IdBodega { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Cantidad { get; set; }
        public int IdProductoBDDestino { get; set; }
        public int IdBodegaFinal { get; set; }
        public DateTime FechaTraslado { get; set; }
    }
}
