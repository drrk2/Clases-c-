using System;
using System.Collections.Generic;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }
    public string Id { get; set; }
    
    // Constructor
    public Producto(string nombre, double precio, int cantidad, string id)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
        Id = id;
        
    }

    // Método para mostrar la información del producto
    public void MostrarProducto()
    {
        Console.WriteLine($"Nombre del producto: {Nombre}");
        Console.WriteLine($"Precio del producto: {Precio}");
        Console.WriteLine($"Cantidad del producto: {Cantidad}");
        Console.WriteLine($"ID del producto: {Id}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Lista para almacenar productos
        List<Producto> inventario = new List<Producto>();

        // Agregar productos al inventario
        inventario.Add(new Producto("Naranja", 20.0, 5, "001"));
        inventario.Add(new Producto("Sandía", 35.0, 10, "002"));

        // Mostrar la cantidad de productos en el inventario
        Console.WriteLine($"Actualmente tienes {inventario.Count} productos en el inventario.");

        Console.WriteLine("¿Deseas ver los productos? (1 = Sí, 2 = No)");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("\nListado de productos:");
            Console.WriteLine("-------------------------------");
            foreach (var producto in inventario)
            {
                producto.MostrarProducto();
                Console.WriteLine("-------------------------------");
            }
        }
        else
        {
            Console.WriteLine("Operación terminada.");
        }
    }
}

