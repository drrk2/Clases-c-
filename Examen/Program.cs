//Crear una aplicación que gestione un inventario de productos usando sobrecarga de métodos y paso de parámetros. 

//1.Clase Producto: Crea una clase con propiedades como nombre, precio, cantidad y id.

public class Propiedades{
    public void Nombre(string nombre){
        Console.WriteLine($"Nombre del producto: {nombre}");
    }
    public void Precio(double precio){
        Console.WriteLine($"Nombre del producto: {precio}");
    }
    public void Cantidad(int cantidad){
        Console.WriteLine($"Nombre del producto: {cantidad}");
    }
    public void Id(string id){
        Console.WriteLine($"Nombre del producto: {id}");
    }
}
//Almacenar productos o agregarlos
public class Producto{
    public string Nombre {get;set;}
    public double Precio {get;set;}
    public int Cantidad {get;set;}
    public string Id {get;set;}
    public Propiedades propiedades {get;set;}
    public Producto(string nombre, double precio, int cantidad, string id){
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
        Id = id;
        }
        public void AgregarProducto(string nombre, double precio, int cantidad, string id){
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Id = id;
            }
            public void MostrarProducto(){
                Console.WriteLine($"Nombre del producto: {Nombre}");
                Console.WriteLine($"Precio del producto: {Precio}");
                Console.WriteLine($"Cantidad del producto: {Cantidad}");
                Console.WriteLine($"Id del producto: {Id}");
                }

//Mostrar el producto
public class Program{
        static void Main(string[] args) {
            Console.WriteLine("Desea ver los productos?");
            Console.WriteLine("Seleccione una opcion (1 si) (2 no): ");
            int opcion = int.Parse(Console.ReadLine());
            Propiedades producto = new Propiedades();
            producto.Nombre("Camisa");
            producto.Precio(20.0);
            producto.Cantidad(10);
            producto.Id("001");
            Console.WriteLine("-------------------------------");
            producto.Nombre("Zapatos");
            producto.Precio(20.0);
            producto.Cantidad(10);
            producto.Id("002");
            }
        }
    }

