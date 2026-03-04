namespace Ejercicio9_METODOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludo();
            Saludo("Sebastián");
            //List<int> numerosGanadores = DevolverNumerosGanadores();
            //foreach (int ganador in DevolverNumerosGanadores())
            //{
            //    Console.WriteLine(ganador);
            //}
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(DevolverNumerosGanadores()[0]);
            }
            Console.WriteLine("Imprimir Numeros ganadores con FOR-EACH");
            foreach (int ganador in DevolverNumerosGanadores())
            {
                Console.WriteLine(ganador);
            }
            Console.WriteLine("------------------------------------------");
            List<double> calificacionesEstudiantes = new List<double>() { 5.5, 6.9, 8.0, 9.5, 8.0 };
            Console.WriteLine(ObtenerPromedioCalificaciones(calificacionesEstudiantes));

        }

        static void Saludo()
        {
            Console.WriteLine("Buenos días 3ro TI");
        }
         static void Saludo(string nombre)
        {
            Console.WriteLine($"Buenos días {nombre}");
        }
        /// <summary>
        /// Método que devuelve los numeros ganadores del sorteo del pozo millonario
        /// el proceso genera números aleatorios entre 1 y 25.
        /// </summary>
        /// <returns></returns>
        static List<int> DevolverNumerosGanadores()
        {
            List<int> listaNumerosGanadores = new List<int>();
            Random random = new Random();
            listaNumerosGanadores.Add(random.Next(1, 26));

            for (int i = 0; i < 12; i++)
            {
                int numeroAleatorio = random.Next(1, 26);
            }
            return listaNumerosGanadores;
        }
        /// <summary>
        /// El metodo toma una lista de calificacione de tipo double, y calcula el promedio. 
        /// </summary>
        /// <param name="calificacionesEstudiantes"></param>
        /// <returns>Retorna una calificación de tipo double</returns>
        static double ObtenerPromedioCalificaciones(List<double> calificacionesEstudiantes)
        {
            double suma=0, promedio = 0;
            foreach (double calificacion in calificacionesEstudiantes)
            {
                suma += calificacion;
            }
                promedio = suma / calificacionesEstudiantes.Count;
            return promedio;
        }
    }
}
