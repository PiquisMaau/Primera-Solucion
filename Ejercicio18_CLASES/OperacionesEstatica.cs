using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    public class OperacionesEstatica
    {
            public static double Sumar(double numero1, double numero2)
            {
                return numero1 + numero2;
            }
            public static double Resta(double numero1, double numero2)
            {
                return numero1 - numero2;
            }
            public static double Multiplicar(double numero1, double numero2)
            {
                return numero1 * numero2;
            }
            public static double Dividir(double numero1, double numero2)
            {
                return numero1 / numero2;
            }
            public static double Residuo(double numero1, double numero2)
            {
                return numero1 % numero2;
            }
            public static double Potencia(double numero1, double numero2)
            {
                return Math.Pow(numero1, numero2);
            }
        }
}
