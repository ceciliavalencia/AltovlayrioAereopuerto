using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIIIAltoValyrio.Class
{
    public class Producto
    {
        public int? IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdCategoria { get; set; }
        public int IdPresentacion { get; set; }
        public int IdMarca { get; set; }
        public int IdBodega { get; set; }
        public string Refrigeracion { get; set; }
    }
}
