abstract class Factura{
public string Cliente {get; set;}
public double Monto {get; set;}
public int Precio {get; set;}
public int Iva {get; set;}
public Factura (string cliente, double monto, int precio, int iva){
    Cliente = cliente;
    Monto = monto;
    Precio = precio;
    Iva = iva;
}
public abstract void GenerarFactura();
}
class FacturaElectronica : Factura{
public FacturaElectronica (string cliente, double monto, int precio, int iva) : base(cliente , monto, precio, iva){ }
public override void GenerarFactura(){
Console.WriteLine($"generando factura electronica para {Cliente} por ${Monto}");
Console.WriteLine($"Detalles de la factura precio original: {Precio} IVA: ${Iva} total: {Precio + Iva}");
}
}

class program{
    static void Main (string[] args){
        FacturaElectronica factura = new FacturaElectronica("Juan", 1000, 500, 5);
        factura.GenerarFactura();
    }
}
