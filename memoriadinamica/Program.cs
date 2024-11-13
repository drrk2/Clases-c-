
public class Persona{
    public string Nombre {get ; set;}

    public Persona(string nombre){
        Nombre = nombre;
        Console.WriteLine("Constructor: Persona creada con nombre "+ nombre);
    }
    ~Persona(){
        Console.WriteLine("Destructor: Persona eliminada");
    }
}
public class Persona2{
    public string Saltar {get ; set;}
    public Persona2(string saltar){
        Saltar = saltar;
        Console.WriteLine("Constructor: Persona creada y esta "+ Saltar);
    }
    ~Persona2(){
        Console.WriteLine("Destructor: Persona eliminada");
    }
}
public class Persona3{
    public string Correr {get ; set;}
    public Persona3(string correr){
        Correr = correr;
        Console.WriteLine("Constructor: Persona creada y esta "+ Correr);
    }
    ~Persona3(){
        Console.WriteLine("Destructor: Persona eliminada");
    }
}

class Program{
    static void Main(string[] args) {
        Persona persona1 = new Persona("Panchito");
        Persona2 persona2 = new Persona2("Saltando");
        Persona3 persona3 = new Persona3("Corriendo");
        Console.WriteLine("Nombre: "+persona1.Nombre);
        Console.WriteLine("esta: "+persona2.Saltar);
        Console.WriteLine("Esta "+persona3.Correr);
        persona1 = null;
        persona2 = null;
        persona3 = null;
        GC.Collect(); //garbage collector
        GC.WaitForPendingFinalizers();
}
}