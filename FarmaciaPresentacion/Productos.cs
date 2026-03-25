using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPresentacion
{
    public class Productos
    {
        public Productos(int id, string nombreComercial, string nombreGenérico, string presentacion, double precio, int stock)
        {
            Id = id;
            NombreComercial = nombreComercial;
            NombreGenérico = nombreGenérico;
            Presentacion = presentacion;
            Precio = precio;
            Stock = stock;
        }

        public int Id { get; set; }
        public string NombreComercial { get; set; }
        public string NombreGenérico { get; set; }
        public string Presentacion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }



    }
}
