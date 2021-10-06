using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Tienda_J.D.Data.Entities
{
    public class Venta
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
    }
}
