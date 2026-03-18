using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19_REPASO
{
    internal class AnalisisTemperaturas : ConversorGrados
    {
        public override double centigradosAfahrenheit(double temperatura)
        {
            double centAFah = temperatura * 1.8 + 32;
            return centAFah;
            
        }

        public override double fahrenheitAcentigrados(double temperatura)
        {
            double FahAcent = (temperatura - 32) / 1.8 ;
            return FahAcent;
        }
    }
}
