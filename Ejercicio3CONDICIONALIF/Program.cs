using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CONDICIONALIF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LÓGICA DE NEGOCIO
            //Si el salrio es mayor o = a 1000$ se aplica impuesto de 5%
            //Si es mayor o igual a 500 paga el 3%

            //DECLARACION DE LA VARIABLES
            //Entrada: Salarios, Salida: Impuesto
            float salarioPersona = 0, impuestoSalarial = 0;
            Console.Write("Ingresa el valor del Salario: ");
            salarioPersona = Convert.ToSingle(Console.ReadLine());

            if (salarioPersona >= 1000){
                impuestoSalarial = salarioPersona * 0.05f;
            }
            else if (salarioPersona >= 500){
                impuestoSalarial = salarioPersona * 0.03f;
            }

            Console.WriteLine("El valor del salario es: ${0} y El valor del impuesto a pagar es: ${1}", salarioPersona, impuestoSalarial);
            Console.Read();
        }
    }
}
