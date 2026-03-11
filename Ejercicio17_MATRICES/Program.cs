using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17_MATRICES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz en C# es igual que en Java, lo unico que cambia es la sintaxis
            //1)Definirlo con una longitud fija
            int[,] matriz = new int[4, 3]; //matriz de 4 filas y 3 columnas

            //2)Asignando valores al momento de craerla
            int[,] matriz2 = new int[,] { { 1, 2, 3 }, 
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12 } };

            //3)Por demanda
            int filas = 4, columnas = 3;
            int[,] matriz3 = new int[filas, columnas];

            //Barrido de matrices
               //HORIZONTAL (f,c)
               for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                       for (int c = 0; c < matriz2.GetLength(1); c++) {
                       Console.Write(matriz2[f, c] + " ");
                   }
                   Console.WriteLine();

            }
            Console.WriteLine("------------------------");
              //VERTICAL (c,f)
              for (int c = 0; c < matriz2.GetLength(1); c++)
            {
                for (int f = 0; f < matriz2.GetLength(0); f++)
                {
                    Console.Write(matriz2[f, c] + " ");
                }
                Console.WriteLine();
            }

            //Generar un método de carga automática 
            //Metodo de carga manual
            //Método para imprimir matriz

        }
    }
}
