using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13_CONSTRUCTORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstudiantesUTA estudiante1 = new EstudiantesUTA();
            estudiante1.Id = 1;
            estudiante1.Nombre = "Sebastian";
            estudiante1.Cedula = "123456789";
            estudiante1.Edad = 21;

            EstudiantesUTA estudiante2 = new EstudiantesUTA(2, "Nicolay", "1238475", 21);

            EstudiantesUTA estudiante3 = new EstudiantesUTA("Ana", "1890456783");
            
        }
    }
}
