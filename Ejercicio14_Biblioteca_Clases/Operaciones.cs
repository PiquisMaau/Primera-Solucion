using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14_Biblioteca_Clases
{
    public class Operaciones
    {
        public double Sumar(double numero_1, double numero_2)
        {
            return numero_1 +  numero_2 ;
        }

        public double Restar(double numero_1, double numero_2)
        {
            return numero_1 - numero_2;
        }

        public double Multiplicar(double numero_1, double numero_2)
        {
            return numero_1 * numero_2;
        }

        public double Dividir(double numero_1, double numero_2)
        {
            return numero_1 / numero_2;
        }

        public double Residuo(double numero_1, double numero_2)
        {
            return numero_1 % numero_2;
        }

        public double Potencia(double numero_1, double numero_2)
        {
            return Math.Pow(numero_1,numero_2);
        }
    }
}
