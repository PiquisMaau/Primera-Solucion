namespace Ejercicio9_METODOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludo();
            Saludo("Sebastián");
        }

        static void Saludo()
        {
            Console.WriteLine("Buenos días 3ro TI");
        }
         static void Saludo(string nombre)
        {
            Console.WriteLine($"Buenos días{nombre}");
        }   
    }
}
