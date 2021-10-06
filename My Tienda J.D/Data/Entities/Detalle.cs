using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Tienda_J.D.Data.Entities
{
    public class Detalle
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public Decimal Cantidad { get; set; }
        public Decimal PrecioUnitario { get; set; }
    }
}
