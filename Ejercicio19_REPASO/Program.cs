using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19_REPASO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa una temperatura(Fahrenheit): ");
            double temperaturaF = double.Parse(Console.ReadLine());
            Console.Write("Ingresa una temperatura(Centígrados): ");
            double temperaturaC = double.Parse(Console.ReadLine());
            AnalisisTemperaturas temperatura1 = new AnalisisTemperaturas();
            Console.WriteLine(temperatura1.centigradosAfahrenheit(temperaturaC));
            Console.WriteLine(temperatura1.fahrenheitAcentigrados(temperaturaF));

        }
    }
}
