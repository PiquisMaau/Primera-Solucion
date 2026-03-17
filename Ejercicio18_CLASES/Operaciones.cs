using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    internal class Operaciones
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
        public double Residuo(double numero1, double numero2)
        {
            return numero1 % numero2;
        }
        public double Potencia(double numero1, double numero2)
        {
            return Math.Pow(numero1,numero2);
        }

    }
}
