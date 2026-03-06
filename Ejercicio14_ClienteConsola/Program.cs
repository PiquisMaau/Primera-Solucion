using Ejercicio14_Biblioteca_Clases;
namespace Ejercicio14_ClienteConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 10, valor2 = 7;
            Operaciones operaciones = new Operaciones();
            Console.WriteLine("Lasuma= {0}", operaciones.Sumar(valor1, valor2));
            Console.WriteLine("La resta= {0}", operaciones.Restar(valor1, valor2));
            Console.WriteLine("La multiplicacion= {0}", operaciones.Multiplicar(valor1, valor2));
            Console.WriteLine("La division= {0}", operaciones.Dividir(valor1, valor2));
            Console.WriteLine("El residuo= {0}", operaciones.Residuo(valor1, valor2));
            Console.WriteLine("La potencia= {0}", operaciones.Potencia(valor1, valor2));

            Cadenas cadenas = new Cadenas();
            Console.WriteLine("La longitud es= {0}", cadenas.LongitudCadena("Mauro"));

            Trigonometria trigonometria = new Trigonometria();
            Console.WriteLine("El seno es= {0}", trigonometria.CalcularSeno(30));
            Console.WriteLine("El coseno es= {0}", trigonometria.calcularCoseno(30));
            Console.Read();

        }
    }
}
