using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    public partial class Parciales
    {
        public double Residuo(double numero1, double numero2)
        {
            return numero1 % numero2;
        }
        public double Potencia(double numero1, double numero2)
        {
            return Math.Pow(numero1, numero2);
        }
    }
}
