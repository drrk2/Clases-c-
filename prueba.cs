using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    // Lista de productos únicos ordenados
    SortedSet<string> productosUnicos = new SortedSet<string>(); //sortedSet almacena productos en orden ascendente

    // Pila para registro de productos (LIFO)
    Stack<string> pilaProductos = new Stack<string>(); //es una pila LIFO donde el ultimo elemento que entra es el primero en salir

    // Cola para despacho de pedidos (FIFO)
    Queue<string> colaPedidos = new Queue<string>(); //Es una cola FIFO donde el primer elemento que entra es el primero en salir

    int opcion;
    do
    {
        Console.WriteLine("\n--- Sistema de Inventarios ---");
        Console.WriteLine("1. Registrar un nuevo producto");
        Console.WriteLine("2. Despachar un pedido");
        Console.WriteLine("3. Retirar el producto más reciente de la pila");
        Console.WriteLine("4. Retirar el pedido más antiguo de la cola");
        Console.WriteLine("5. Mostrar lista de productos únicos");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opción: ");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion){
            case 1: // Registrar producto
                Console.Write("Ingrese el nombre del producto a registrar: ");
                string nuevoProducto = Console.ReadLine();
                
                // Usando Push para registrar el producto en la pila
                pilaProductos.Push(nuevoProducto);
                Console.WriteLine($"Producto '{nuevoProducto}' registrado en la pila.");

    // Agregar a la lista de productos únicos
    if (productosUnicos.Add(nuevoProducto)){
        Console.WriteLine($"Producto '{nuevoProducto}' agregado a la lista única.");
    }else{
        Console.WriteLine($"Producto '{nuevoProducto}' ya estaba en la lista única.");
    }
    break;

case 2: // Despachar pedido
    if (pilaProductos.Count > 0){ // Sacar producto de la pila y agregar a la cola
        string productoParaPedido = pilaProductos.Pop();
        colaPedidos.Enqueue(productoParaPedido);
        Console.WriteLine($"Producto '{productoParaPedido}' añadido a la cola de pedidos.");
    }else{
        Console.WriteLine("No hay productos en la pila para procesar un nuevo pedido.");
    }
    break;

case 3: // Retirar el producto
    if (pilaProductos.Count > 0){
string productoRetirado = pilaProductos.Pop();
        Console.WriteLine($"Producto '{productoRetirado}' retirado de la pila.");
}else{
        Console.WriteLine("No hay productos en la pila para retirar.");
    }
break;

case 4:
    if (colaPedidos.Count > 0){
        string pedidoRetirado = colaPedidos.Dequeue();
        Console.WriteLine($"Pedido '{pedidoRetirado}' retirado de la cola.");
    }else{
        Console.WriteLine("No hay pedidos en la cola para retirar.");
}
break;

case 5: // Mostrar lista de productos únicos
    Console.WriteLine("\nLista de productos únicos:");
    foreach (var producto in productosUnicos)
{
        Console.WriteLine($"- {producto}");
}
break;

    case 6: // Salir
    Console.WriteLine("Saliendo del sistema...");
break;

default: // Cuando la opción no es válida
Console.WriteLine("Opción no válida. Intente de nuevo.");
break;
}} while (opcion != 6);
}
}
