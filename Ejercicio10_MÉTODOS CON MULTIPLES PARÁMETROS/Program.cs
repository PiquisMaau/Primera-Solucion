namespace Ejercicio10_MÉTODOS_CON_MULTIPLES_PARÁMETROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------Método parámetros manueales------------------------------------");
            Console.WriteLine($"Promedio {CalcularPromedioCalificaciones(8.5, 9.4)}");
            Console.WriteLine($"Promedio {CalcularPromedioCalificaciones(8.5, 9.4, 6)}");
            Console.WriteLine($"Promedio {CalcularPromedioCalificaciones(8.5, 9.4, 6, 0.1)}");
            Console.WriteLine("-----------------------------------Método multi-paramétrico------------------------------------");
            Console.WriteLine($"Promedio {CalcularPromedioCalificacionesConMuchosParámetros(8.5, 9.4)}");
            Console.WriteLine($"Promedio {CalcularPromedioCalificacionesConMuchosParámetros(8.5, 9.4, 6)}");
            Console.WriteLine($"Promedio {CalcularPromedioCalificacionesConMuchosParámetros(8.5, 9.4, 0.1, 6)}");



            Console.Read();
        }
        static double CalcularPromedioCalificacionesConMuchosParámetros(params double[] calificaciones)
        {
            double sumatoria = 0,promedio = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                sumatoria += calificaciones[i];
            }
            promedio = sumatoria / calificaciones.Length;
            return promedio;
        }

        static double CalcularPromedioCalificaciones(double nota, double nota2)
        {
            return (nota + nota2) / 2;
        }
        static double CalcularPromedioCalificaciones(double nota, double nota2, double nota3)
        {
            return (nota + nota2 + nota3) / 3;
        }
        static double CalcularPromedioCalificaciones(double nota, double nota2, double nota3, double nota4)
        {
            return (nota + nota2 + nota3 + nota4) / 4;
        }

    }
}
