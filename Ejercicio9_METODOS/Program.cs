namespace Ejercicio9_METODOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludo();
            Saludo("Sebastián");

            //List<int> numerosGanadores = DevolverNumerosGanadores();
            foreach (int ganador in DevolverNumerosGanadores())
            {
                Console.WriteLine(ganador);
            }
        }

        static void Saludo()
        {
            Console.WriteLine("Buenos días 3ro TI");
        }
         static void Saludo(string nombre)
        {
            Console.WriteLine($"Buenos días {nombre}");
        }
        
        static List<int> DevolverNumerosGanadores()
        {
            List<int> listaNumerosGanadores = new List<int>() {1,3,5,7,9,11,13,15,17,19};
            return listaNumerosGanadores;
        }
    }
}
