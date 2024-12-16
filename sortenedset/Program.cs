using System;
using System.Collections.Generic;

class Program{
    static void Main(string [] args){
    SortedSet <string> numeros = new SortedSet<string>();
        numeros.Add("3322446053");
        numeros.Add("3312344567");
        numeros.Add("3390787654");
        numeros.Add("3376658909");
Console.WriteLine("Lista de numeros de telefonos");
foreach (var telefono in numeros){
    Console.WriteLine(telefono);
}Console.WriteLine("\n Ingrese el numero de telefono para agregar al registro: ");
string nuevoTelefono = Console.ReadLine();
if (numeros.Add(nuevoTelefono)){
Console.WriteLine($"El numero: {nuevoTelefono} Agregado exitosamente");
}else{
    Console.WriteLine($"El numero: {nuevoTelefono}, ya se encuentra en la lista");
}
    Console.WriteLine("\n lista actualizada exitosamente.");
    foreach(var telefono in numeros){
        Console.WriteLine(telefono);
    }
}
}