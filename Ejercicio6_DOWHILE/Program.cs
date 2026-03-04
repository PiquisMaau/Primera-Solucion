using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_DOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int limiteSuperior = 20;
            int contador = 1;
            Console.WriteLine("Imprimir numeros del 1 al 20");

            //Mínimo de iteraciones en do-WHILE es 1

            do
            {
                Console.WriteLine("Valor: {0}", contador);
                contador++;
            } while (contador <= limiteSuperior);
                Console.ReadKey();

        }
    }
}
