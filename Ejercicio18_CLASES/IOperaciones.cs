using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo17_Clases
{
    public interface IOperaciones
    {
        double Suma(double numero1, double numero2);
        double Resta(double numero1, double numero2);
        double Multiplicacion(double numero1, double numero2);
        double Division(double numero1, double numero2);
        double Residuo(double numero1, double numero2);
        double Potencia(double numero1, double numero2);

    }
}
