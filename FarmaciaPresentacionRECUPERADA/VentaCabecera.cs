using System;
using System.Collections.Generic;



public class VentaCabecera
{
    public int ID_venta { get; set; }

    public DateTime FechaVenta { get; set; }

    public string NumeroComprobante { get; set; }

    public cliente Cliente { get; set; }

    public List<VentaDetalle> ListaVentaDetalle { get; set; }
}
