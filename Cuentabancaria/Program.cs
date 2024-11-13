public class Cuentabancaria{
    //atributo
    public double Saldo {get; private set;}
//constructor
public Cuentabancaria(){
    Saldo = 0;
}

//metodo
public void Depositar (double cantidad){
    if(cantidad > 0){
        Saldo += cantidad;
        Console.WriteLine("$Has depositado: {cantidad}. ");
    }else{
        Console.WriteLine("No puedes depositar una cantidad negativa o cero.");
    }
}


public void Retirar(double cantidad){
    if(cantidad > ){

    }
}
}