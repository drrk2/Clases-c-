public class ConvertidorUnidades{
    public double Convertir(double temperatura, string tipo){
        if (tipo == "CtoF"){
            //Celcius a fahrenheit
            return (temperatura * 9 / 5) + 32;
        }else if (tipo == "FtoC"){
            //Fahrenheit a celsius
            return (temperatura - 32)* 5 / 9;
        }else{
            throw new ArgumentException("Tipo de conversion invalido");
        }
    }
//Sobrecarga para convertir distancias
public double convertir(double distancia, string tipo, bool esDistancia){
    if (tipo == "KmToMi" && esDistancia){
        //Kilometros a millas
    return distancia * 0.621371;
    }else if(tipo == "MiToKm"){
        //millas a kilometros
        return distancia * 0.621371;
    }else{
        throw new ArgumentException("Tipo de conversion invalido");
    }
}
//Sobrecarga para convertir pesos
public double Convertir(double peso, string tipo, bool esDistancia, bool esPeso){
    if (tipo == "KgToLb" && esPeso){
        //Kilogramos a libras
        return peso * 2.20462;
    }else if (tipo == "LbToKg" && esPeso){
    //libras a kilogramos
    return peso / 2.20462;
    }else{
    throw new ArgumentException("Tipo de conversion invalido");
    }
}
}

class Program{
    static void Main(){
        ConvertidorUnidades convertidor = new ConvertidorUnidades();
        Console.WriteLine("Bienvenido al convertidor de unidades");
        while(true){
    Console.WriteLine("\n Seleccione el tipo de conversion");
    Console.WriteLine("1. Temperatura (celsius <-> fahrenheint)");
    Console.WriteLine("2. Distancia (Kilometros <-> Libras)");
    Console.WriteLine("3. Peso (Kilogramos <-> libras)");
    Console.WriteLine("4. Salir");
    int opcion = int.Parse(Console.ReadLine());
    if(opcion == 4){
        Console.WriteLine("Gracias por usar el convertidor");
        break;
    }
    Console.WriteLine("Ingrese el valor a convertir: ");
    double valor = double.Parse(Console.ReadLine());
    try{
        double resultado = 0;
    switch (opcion){
    case 1: 
    Console.WriteLine("Ingrese el tipo de conversion (CToF o FtoC)");
    string tipoTemp = Console.ReadLine();
    resultado = convertidor.Convertir(valor, tipoTemp);
    Console.WriteLine($"RResultado: {resultado}");
    break;

    case 2:
    Console.WriteLine("Ingrese el tipo de conversion (KmToMi o MiToKm)");
    string tipoDistancia = Console.ReadLine();
    resultado = convertidor.convertir(valor, tipoDistancia, true);
    Console.WriteLine($"Resultado : {resultado}");
    break;

    case 3:
    Console.WriteLine("Ingrese el tipo de conversion (KgToLb o LbToKg)");
    string tipoPeso = Console.ReadLine();
    resultado = convertidor.convertir(valor, tipoPeso, true);
    Console.WriteLine($"Resultado : {resultado}");
    break;

    default:
    Console.WriteLine("Opcion invalida");
    break;
    }
    }
catch(Exception ex){
    Console.WriteLine($"Error: {ex.Message}");
}
}
}
}