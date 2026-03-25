public class Productos
{
    public int Id { get; set; }

    public string NombreComercial { get; set; }

    public string NombreGenérico { get; set; }

    public string Presentacion { get; set; }

    public double Precio { get; set; }

    public int Stock { get; set; }

    public Productos(int id, string nombreComercial, string nombreGenérico, string presentacion, double precio, int stock)
    {
        Id = id;
        NombreComercial = nombreComercial;
        NombreGenérico = nombreGenérico;
        Presentacion = presentacion;
        Precio = precio;
        Stock = stock;
    }
}
