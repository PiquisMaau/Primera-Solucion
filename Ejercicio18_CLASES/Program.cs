using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 10, numero2 = 20;
            Console.WriteLine("----Clase Normal por Intanciacion----");
            Operaciones operaciones = new Operaciones();
            Console.WriteLine("Sumar 10 y 20 = {0}",operaciones.Sumar(numero1,numero2));
            Console.WriteLine("Restar 10 y 20 = {0}", operaciones.Resta(numero1, numero2));
            Console.WriteLine("Multiplicar 10 y 20 = {0}", operaciones.Multiplicar(numero1, numero2));
            Console.WriteLine("Dividir 10 y 20 = {0}", operaciones.Dividir(numero1, numero2));
            Console.WriteLine("Residuo 10 y 20 = {0}", operaciones.Residuo(numero1, numero2));
            Console.WriteLine("Potencia 10 y 20 = {0}", operaciones.Potencia(numero1, numero2));
            Console.WriteLine("----Clase Estatica----");
            Console.WriteLine("Sumar 10 y 20 = {0}", OperacionesEstatica.Sumar(numero1,numero2));
            Console.WriteLine("Restar 10 y 20 = {0}", OperacionesEstatica.Resta(numero1, numero2));
            Console.WriteLine("Multiplicar 10 y 20 = {0}", OperacionesEstatica.Multiplicar(numero1, numero2));
            Console.WriteLine("Dividir 10 y 20 = {0}", OperacionesEstatica.Dividir(numero1, numero2));
            Console.WriteLine("Residuo 10 y 20 = {0}", OperacionesEstatica.Residuo(numero1, numero2));
            Console.WriteLine("Potencia 10 y 20 = {0}", OperacionesEstatica.Potencia(numero1, numero2));
            Console.WriteLine("----Clases Parciales----");
            Parciales parciales = new Parciales();
            Console.WriteLine("Sumar 10 y 20 = {0}", parciales.Sumar(numero1, numero2));
            Console.WriteLine("Restar 10 y 20 = {0}", parciales.Resta(numero1, numero2));
            Console.WriteLine("Multiplicar 10 y 20 = {0}", parciales.Multiplicar(numero1, numero2));
            Console.WriteLine("Dividir 10 y 20 = {0}", parciales.Dividir(numero1, numero2));
            Console.WriteLine("Residuo 10 y 20 = {0}", parciales.Residuo(numero1, numero2));
            Console.WriteLine("Potencia 10 y 20 = {0}", parciales.Potencia(numero1, numero2));
            Console.WriteLine("----Clase Hija Abstracta----");
            OperacionesHijaAbstracta hijaAbstracta = new OperacionesHijaAbstracta();
            Console.WriteLine("Sumar 10 y 20 = {0}", hijaAbstracta.Sumar(numero1, numero2));
            Console.WriteLine("Restar 10 y 20 = {0}", hijaAbstracta.Resta(numero1, numero2));
            Console.WriteLine("Multiplicar 10 y 20 = {0}", hijaAbstracta.Multiplicar(numero1, numero2));
            Console.WriteLine("Dividir 10 y 20 = {0}", hijaAbstracta.Dividir(numero1, numero2));
            Console.WriteLine("Residuo 10 y 20 = {0}", hijaAbstracta.Residuo(numero1, numero2));
            Console.WriteLine("Potencia 10 y 20 = {0}", hijaAbstracta.Potencia(numero1, numero2));
            Console.WriteLine(hijaAbstracta.ToString());

            Console.WriteLine("----------- INTERFACES ------------");
            ClaseHijaInterfaceOperaciones operacionesInterface = new ClaseHijaInterfaceOperaciones();
            Console.WriteLine("Sumar 10 y 20 = {0}", operacionesInterface.Sumar(numero1, numero2));
            Console.WriteLine("Restar 10 y 20 = {0}", operacionesInterface.Restar(numero1, numero2));
            Console.WriteLine("Multiplicar 10 y 20 = {0}", operacionesInterface.Multiplicar(numero1, numero2));
            Console.WriteLine("Dividir 10 y 20 = {0}", operacionesInterface.Dividir(numero1, numero2));
            Console.WriteLine("Potencia 10 y 20 = {0}", operacionesInterface.Potenciacion(numero1, numero2));


        }
    }
}
