using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19_EXCEPCIONES
{
    internal class Program
    {
        static void conectarBDD()
        {

        }
        static void Main(string[] args)
        {
           
            try
            {
                //Area de un triángulo
                //A = (b * h) / 2
                //EXCEPCION: es un evento de ejecucion que captura un error
                Console.Write("Ingrese la base: ");
                double base_ = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                double area = base_ * altura * 0.5;
                Console.WriteLine("Area = {0}", area);

                int divisor = 0;
                var division = 15 / divisor;
                Console.WriteLine($"Division: {division}");

                int[] edades = new int[] { 19, 20, 21 };
                Console.WriteLine(edades[3]);

                Console.WriteLine("Esto es todo amegos!!");
            }
            //catch (IndexOutOfRangeException arr)
            //{
            //    Console.WriteLine(arr.Message);
            //}
            //catch (DivideByZeroException cero)
            //{
            //    Console.WriteLine(cero.Message);
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("Se produjo un error");
            //    Console.WriteLine(fe.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo un error");
                Console.WriteLine(ex.Message);            }
            }
        }
}
