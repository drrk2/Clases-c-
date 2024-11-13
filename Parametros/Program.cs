using System;

public class TiposDeParametros{
    // Método con paso por valor
    public static void PasoPorValor(int valor){
        valor = 10; // Este cambio no afectará la variable original en Main
        Console.WriteLine($"Dentro del método PasoPorValor, valor = {valor}");
    }

    // Método con paso por referencia
    public static void PasoPorReferencia(ref int referencia){
        referencia = 20; // Este cambio sí afectará la variable original en Main
        Console.WriteLine($"Dentro del método PasoPorReferencia, referencia = {referencia}");
    }

    // Método con parámetros de salida
    public static void ParametrosDeSalida(int numero, out int cuadrado, out int cubo){
        cuadrado = numero * numero; // Inicializando el parámetro de salida
        cubo = numero * numero * numero; // Inicializando el parámetro de salida
    }

    static void Main(string[] args){
        // Paso por valor
        int valor = 5;
        Console.WriteLine($"Antes de PasoPorValor, valor = {valor}");
        PasoPorValor(valor);
        Console.WriteLine($"Después de PasoPorValor, valor = {valor}\n");

        // Paso por referencia
        int referencia = 5;
        Console.WriteLine($"Antes de PasoPorReferencia, referencia = {referencia}");
        PasoPorReferencia(ref referencia);
        Console.WriteLine($"Después de PasoPorReferencia, referencia = {referencia}\n");

        // Parámetros de salida
        int numero = 3;
        int cuadrado, cubo; // Los out inician solos
        ParametrosDeSalida(numero, out cuadrado, out cubo);
        Console.WriteLine($"Número: {numero}, Cuadrado: {cuadrado}, Cubo: {cubo}");
    }
}
