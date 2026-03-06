namespace Ejercicio12_PARÁMETROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            Console.WriteLine(numero);
            Console.WriteLine(Duplicar(numero));
            Console.WriteLine(numero);  //se imprime el valor original, no se modifica porque no se pasa por referencia

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(numero);
            Console.WriteLine(DuplicarReferencia(ref numero));
            Console.WriteLine(numero);
            String palabra = "Hola";
            Console.WriteLine(palabra);
            Console.WriteLine(AnaPalabra(ref palabra));
            Console.WriteLine(palabra);
            Matematicas mate = new Matematicas();
            Console.WriteLine();



        }
        static int Duplicar( int valor)
        {
            return valor * 2;
        }

        static int DuplicarReferencia(ref int valor)
        {
            return valor * 2;
        }

        static String AnaPalabra(ref string palabra)
        {
            return palabra + " Ana";
        }

         class Matematicas
        {
            public static int Sumar(int a, int b)
            {
                return a + b;
            }
        }
    }
}
