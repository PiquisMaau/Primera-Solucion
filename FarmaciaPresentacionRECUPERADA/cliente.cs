public class cliente
{
    public int id { get; set; }

    public string Apellidos { get; set; }

    public string Nombres { get; set; }

    public string Cedula { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    public string Correo { get; set; }

    public cliente()
    {
    }

    public cliente(int id, string apellidos, string nombres, string cedula, string telefono, string direccion, string correo)
    {
        this.id = id;
        Apellidos = apellidos;
        Nombres = nombres;
        Cedula = cedula;
        Telefono = telefono;
        Direccion = direccion;
        Correo = correo;
    }
}
