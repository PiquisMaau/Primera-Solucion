using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_VECTORES
{
    internal class Program
    {
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
            float [] pesos = new float[] { 60.5f, 70.2f, 80.3f, 90.4f }; //se pone f porque el tipo de dato float es de menor presedente que double
            // 3) Por demanda
            // 3.1) Declaración - Instanciación

            int [] cuota; //declaración
            int numeroCuotas = 4;
            cuota = new int[numeroCuotas]; //instanciación
            cuota[0] = 40;
            cuota[1] = 100;
            cuota[2] = 1000;

        }

    }
}
