using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14_Biblioteca_Clases
{
    public class Cadenas
    {
        //mostrar la longitud de una cadena
        public Cadenas() { }
        public int LongitudCadena(string cadena)
        {
            return cadena.Trim().Length;
        }
    }
}
