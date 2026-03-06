using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13_CONSTRUCTORES
{
    internal class EstudiantesUTA
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        public EstudiantesUTA() { }  //se genera con un "ctor"

        public EstudiantesUTA(int id, string nombre, string cedula, int edad)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Edad = edad;
        }

        public EstudiantesUTA(string nombre, string cedula)
        {
            Nombre = nombre;
            Cedula = cedula;
        }
    }
}
