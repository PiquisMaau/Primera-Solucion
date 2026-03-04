using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_CICLOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteSuperior = 20;
            int contador = 1;
            Console.WriteLine("Imprimir numeros del 1 al 20");

            //Mínimo de iteraciones en WHILE es 0
            while (contador <= limiteSuperior)
            {
                Console.WriteLine("Valor: {0}", contador);
                contador++;
            }
            Console.ReadKey();
        }
        }
    }

