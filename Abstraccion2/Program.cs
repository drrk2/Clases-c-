using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
class Producto{
    public string Nombre { get; set; }
    public double Precio { get; set; }
public Producto (string nombre, double precio){
    Nombre = nombre;
    Precio = precio;
}

    public override string ToString()
    {
        return $"{Nombre} - ${Precio}";
    }
}

class program{
    static void Main (string[] args){
        List<Producto> inventario = new List<Producto>();

inventario.Add(new Producto("Procesador", 15000));
inventario.Add(new Producto("Audifonos", 300));
inventario.Add(new Producto("Celular", 11500));

Console.WriteLine("Productos en el inventario:");
foreach (Producto producto in inventario){
    Console.WriteLine(producto);
}

Producto buscando = inventario.Find(p => p.Nombre == "Celular");
if (buscando != null){
    Console.WriteLine($"Producto encontrado: {buscando}");
}
inventario.RemoveAll (p => p.Nombre == "Celular");
Console.WriteLine($"Despues de eliminar el Celular");
Console.WriteLine($"Despues de eliminar  el procesador");
foreach (Producto producto in inventario){
    Console.WriteLine(producto);
}
}
}

