using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPresentacion
{
    public class Cliente
    {
        public Cliente(int id,string nombre, string apellido, string cedula, string telefono, string direccion, string correo)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
            Direccion = direccion;
            Correo = correo;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula{ get; set; }
        public string Telefono{ get; set; }
        public string Direccion{ get; set; }
        public string Correo { get; set; }

    }
}
