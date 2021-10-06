using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Tienda_J.D.Data.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategorias { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }
        public Decimal Costo { get; set; }
        public Decimal Stock { get; set; }
    }
}
