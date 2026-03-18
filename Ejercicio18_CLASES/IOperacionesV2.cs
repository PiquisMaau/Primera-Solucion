using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    public interface IOperacionesV2
    {
        //los métodos de una interfaz no tienen ámbito, como publico, etc.
        double Sumar(double valor1, double valor2);
        double Restar(double valor1, double valor2);
        double Multiplicar(double valor1, double valor2);
        double Dividir(double valor1, double valor2);
        double Potenciacion(double valor1, double valor2);

    }
}
