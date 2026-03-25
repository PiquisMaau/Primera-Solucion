public class VentaDetalle
{
    public int Id_ventaDetalle { get; set; }

    public Productos Producto { get; set; }

    public int Cantidad { get; set; }

    public double PrecioVenta { get; set; }

    public double SubTotal { get; set; }
}
