using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    public partial class Parciales
    {
        public double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
        public double Resta(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
        public double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }
    }
}
