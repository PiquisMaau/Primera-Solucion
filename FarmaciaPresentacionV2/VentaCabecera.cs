using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPresentacion
{
    internal class VentaCabecera
    {
        public int Id { get; set; }
        public DateTime FechaVentas { get; set; }
        
        public string NumeroComprobante { get; set; } 
        public Cliente Cliente { get; set; }
        public List<VentaDetalle> ListaVentaDetalle { get; set; }
    }
}
