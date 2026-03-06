using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14_Biblioteca_Clases
{
    public class Trigonometria
    {
        //metodos, calcular seno y coseno de un angulo dado

        public double CalcularSeno(double angulo)
        {
            return Math.Sin(angulo * (Math.PI / 180));   //ver si la funcion recibe como parametro angulos en radianes
        }

        public double calcularCoseno(double angulo)
        {
            return Math.Cos(angulo * (Math.PI/180));
        }

    }
}
