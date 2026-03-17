using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    public class OperacionesHijaAbstracta : OperacionesAbstractas
    {
        public override double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public override double Resta(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public override double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
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
            return Math.Pow(numero1, numero2);
        }

        public override string ToString()
        {
            return "Hola desde la clase sobreescrita";
        }
    }
}
