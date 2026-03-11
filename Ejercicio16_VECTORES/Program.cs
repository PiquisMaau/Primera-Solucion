using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_VECTORES
{
    internal class Program
    {
        #region Codigo principal

        static void Main(string[] args)
        {
            //LO UNICO QUE CAMBIA EL USO DE VECTORES CON RESPECTO A JAVA ES EL USO DE VECTORES
            //1)Definirlo con una longitud fija
            int[] estaturas = new int[5];
            string[] conserjes = new string[2];
            estaturas[0] = 168;
            estaturas[1] = 145;
            estaturas[2] = 176;
            estaturas[3] = 180;
            estaturas[4] = 165;

            conserjes[0] = "Juanito";
            conserjes[1] = "Ricky";

            //2)Definir la dimensión agregando los elementos, al crearlo
            int[] edades = new int[] { 15, 20, 25, 30, 35, 5, 6, 8, 4 };
            float[] pesos = new float[] { 60.5f, 70.2f, 80.3f, 90.4f }; //se pone f porque el tipo de dato float es de menor presedente que double
            // 3) Por demanda
            // 3.1) Declaración - Instanciación

            int[] cuota; //declaración

            float[] pesos2 = new float[] { 60.5f, 70.2f, 80.3f, 90.4f }; //se pone f porque el tipo de dato float es de menor presedente que double
            // 3) Por demanda
            // 3.1) Declaración - Instanciación

            int[] cuota2; //declaración
            int numeroCuotas = 4;
            cuota2 = new int[numeroCuotas]; //instanciación
            cuota2[0] = 40;
            cuota2[1] = 100;
            cuota2[2] = 1000;

            ImprimirVectoresEnteros(estaturas);
            ImprimirVectoresEnteros(cuota2);

            //Cargas de calificaciones
            Console.WriteLine("---------------------Carga de calificaciones----------------------");
            double[] calificaciones;
            Random r = new Random();//ésta instanciacion se hace fuera del for para que no se repitan los numeros aleatorios, si se hace dentro del for se crean varias instancias y se repiten los numeros aleatorios
            Console.WriteLine("Ingrese el numero de calificaciones: ");
            int cantidadCalificaciones = Convert.ToInt32(Console.ReadLine()); //convertir de string a entero
            calificaciones = new double[cantidadCalificaciones];
            //CargarconRandom(calificaciones, r);
            //CargarCalificaciones(calificaciones);
            //TODO: PrEGUNTAR QUE TIPO DE CARGA
            //M O m -> mANUAL, A O a  ->AUTOMATICO
            Console.WriteLine("como deseas cargar el vector: (M/A)");
            string tipoCarga = Console.ReadLine();
            if (tipoCarga.ToUpper() == "M")
            {
                CargarCalificaciones(calificaciones);

            }
            else if (tipoCarga.ToUpper() == "A")
            {
                CargarconRandom(calificaciones, r);

            }


            Console.WriteLine("---------------------Imprimir calificaciones----------------------");
            ImprimirVectoresDouble(calificaciones);
            Console.WriteLine("Promedio = {0}", CalcularPromedioVectorDouble(calificaciones));

            

        }

        private static void CargarconRandom(double[] calificaciones, Random r)
        {
            Console.WriteLine("Cargar calificaciones");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                //TODO: completar cuando tenga un rango de valores
                Console.WriteLine(calificaciones[i] = Math.Round(r.NextDouble() * 10,1));
                // calificaciones[i] = Convert.ToDouble(Console.ReadLine());
                
            }
        }
        private static void CargarCalificaciones(double[] calificaciones)
        {
            Console.WriteLine("Cargar calificaciones");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"Ingrese la calificación {i + 1}: ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        #endregion

        #region MÉTODOS PARA IMPRIMIR VECTORES

        static void ImprimirVectoresEnteros(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Posición {i} - Valor {vector[i]}");
            }
        }

        static void ImprimirVectoresDouble(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Posición {i+1} - Valor {vector[i]}");
            }

        }
        static double CalcularPromedioVectorDouble(double[] vector)
        {
            double sumatoria = 0, promedio = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sumatoria += vector[i];
            }
            promedio = sumatoria / vector.Length;
            return promedio;
        }

        #endregion

        }

    }

