using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPresentacion
{
    internal class VentaDetalle
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public double PrecioVenta { get; set; }
        public double Subtoal { get; set; }
    }
}
