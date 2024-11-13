public class Calculadora{
    //Metodo para sumar dos numeros
    public int Sumar (int a, int b)
    {return a+b;}
    //Sobrecarga del metodo con 3 numeros
    public int Sumar (int a, int b, int c)
    {return a+b+c;}
//Sobrecarga del metodo para sumar 2 numeros tipo double
    public double Sumar (double a, double b)
    {return a+b;}

//Restar
    public int Restar (int a, int b)
    {return a-b;}
    //Sobrecarga del metodo con 3 numeros
    public int Restar (int a, int b, int c)
    {return a-b-c;}
//Sobrecarga del metodo para sumar 2 numeros tipo double
    public double Restar (double a, double b)
    {return a-b;}

    //Metodo para sumar dos numeros
    public int multiplicar (int a, int b)
    {return a*b;}
    //Sobrecarga del metodo con 3 numeros
    public int multiplicar (int a, int b, int c)
    {return a*b*c;}
//Sobrecarga del metodo para sumar 2 numeros tipo double
    public double multiplicar (double a, double b)
    {return a*b;}
}
class Program{
    static void Main(string[] args){
        Calculadora calculadora = new Calculadora();
        Console.WriteLine("-------------Suma---------------");
        Console.WriteLine("Suma de dos numeros enteros"+calculadora.Sumar(2,5));
        Console.WriteLine("Suma de 3 numeros enteros"+calculadora.Sumar(2,8,5));
        Console.WriteLine("Suma de 2 numeros dobles"+calculadora.Sumar(2.3,2.5));
        Console.WriteLine("---------------Resta--------------------");
        Console.WriteLine("Suma de dos numeros enteros"+calculadora.Restar(2,5));
        Console.WriteLine("Suma de 3 numeros enteros"+calculadora.Restar(2,8,5));
        Console.WriteLine("Suma de 2 numeros dobles"+calculadora.Restar(2.3,2.5));
        Console.WriteLine("---------------Multiplicar--------------------");
        Console.WriteLine("Suma de dos numeros enteros"+calculadora.multiplicar(2,5));
        Console.WriteLine("Suma de 3 numeros enteros"+calculadora.multiplicar(2,8,5));
        Console.WriteLine("Suma de 2 numeros dobles"+calculadora.multiplicar(2.3,2.5));
    }
}