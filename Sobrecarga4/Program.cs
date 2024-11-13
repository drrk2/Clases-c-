//Julio Cesar Salazar Serrano
using System;
using System.Collections.Generic;

public class Inventario{
    private Dictionary<string, int> productos = new Dictionary<string, int>();

    // Sobrecarga para agregar un producto usando solo el nombre del producto
    public void AgregarProducto(string nombreProducto){
        if (productos.ContainsKey(nombreProducto)){
            productos[nombreProducto]++;
        }else{
            productos[nombreProducto] = 1;
        }
        Console.WriteLine($"Producto '{nombreProducto}' agregado. Total: {productos[nombreProducto]}");
    }

    // Sobrecarga para agregar un producto usando el nombre y la cantidad
    public void AgregarProducto(string nombreProducto, int cantidad)
    {
        if (productos.ContainsKey(nombreProducto)){
            productos[nombreProducto] += cantidad;
        }else{
            productos[nombreProducto] = cantidad;
        }
        Console.WriteLine($"Producto '{nombreProducto}' agregado con {cantidad} unidades. Total: {productos[nombreProducto]}");
    }

    // Sobrecarga para agregar un producto usando un código y nombre del producto
    public void AgregarProducto(int codigoProducto, string nombreProducto){
        string productoConCodigo = nombreProducto + " - Código " + codigoProducto;

        if (productos.ContainsKey(productoConCodigo)){
            productos[productoConCodigo]++;
        }
        else{
            productos[productoConCodigo] = 1;
        }
        Console.WriteLine($"Producto '{productoConCodigo}' agregado. Total: {productos[productoConCodigo]}");
    }
}

public class Program{
    public static void Main(){
        Inventario inventario = new Inventario();

        // Agregar producto solo con el nombre
        inventario.AgregarProducto("Lapicero");

        // Agregar producto con nombre y cantidad
        inventario.AgregarProducto("Cuaderno", 5);

        // Agregar producto con código y nombre
        inventario.AgregarProducto(101, "Calculadora");
    }
}
