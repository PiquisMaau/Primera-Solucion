using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_OperadorCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables Salario e Impuesto
            float salarioPersona = 0, impuestoSalarial = 0;

            //LÓGICA DE NEGOCIO
            //Si el salrio es mayor o = a 1000$ se aplica impuesto de 5%
            //Si es mayor o igual a 500 paga el 3%
            Console.Write("Ingresa el salario de la persona: ");

            //salarioPersona = float.Parse(Console.ReadLine());
            salarioPersona = Convert.ToSingle(Console.ReadLine());
            impuestoSalarial = salarioPersona >= 1000 ? salarioPersona * 0.05f :
                salarioPersona >= 500  ? salarioPersona * 0.03f : 0;
            //Condición = ?, else = :

            //Console.WriteLine("El valor del impuesto a pagar es: $" + impuestoSalarial);
            Console.WriteLine("El valor del salario es: ${0} y El valor del impuesto a pagar es: ${1}",salarioPersona,impuestoSalarial);
            Console.Read();
        }
    }
}
