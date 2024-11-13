using System.Reflection.Metadata;

public class Persona{
    public void Saludar(){
        Console.WriteLine("Hola?");
}
    public void Saludar (string nombre){
        Console.WriteLine($"Hola {nombre}");
}
    public void Saludar(string titulo, string nombre){
    Console.WriteLine($"Hola {titulo} {nombre}");
} 
    public void Despedida(){
        Console.WriteLine("Adios");
}
    public void Despedida (string nombre){
        Console.WriteLine($"Adios {nombre}");
}
    public void Despedida(string titulo, string nombre){
    Console.WriteLine($"Adios {titulo} {nombre}"); 
}
    public void Ambas(){
        Console.WriteLine("Hola"+" Adios");
}
    public void Ambas (string nombre){
        Console.WriteLine($"Hola"+" Adios {nombre}");
}
    public void Ambas(string titulo, string nombre){
    Console.WriteLine($"Hola"+" Adios {titulo} {nombre}");
}
class program{
    static void Main(string[] args){
        Persona persona = new Persona();
        persona.Saludar();
        /* persona.Saludar("David");
        persona.Saludar("ING.","Julio");
         //Despedir*/
        persona.Despedida();
        /* persona.Despedida("David");
        persona.Despedida("ING.","Julio"); 
        //Ambas
        persona.Ambas();
        persona.Ambas("David");
        persona.Ambas("ING.","Julio");*/
}
}
}