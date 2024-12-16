using System.Collections.Generic;
class program{
    static void Main(string[]args){
        Dictionary<int, string> directorioEmpleados = new Dictionary<int, string>();

    directorioEmpleados.Add(101, "Juanito");
    directorioEmpleados.Add(102, "Panchito");
    directorioEmpleados.Add(103, "Mongolito");

        Console.WriteLine("Ingrese el ID del empleado a buscar: ");
        int idBuscado = int.Parse(Console.ReadLine());
        if(directorioEmpleados.ContainsKey(idBuscado)){
            Console.WriteLine($"Empleado encontrado : {directorioEmpleados}");
        }else{
            Console.WriteLine("Empleado no encontrado.");
        }

    }
}