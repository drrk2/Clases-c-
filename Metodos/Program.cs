namespace Metodos{
    class program{
        static void Main(string[] args){
            try{
                Console.WriteLine("Introduce el numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                //intentar dividir
                int result = numerador / denominador;
                Console.WriteLine($"Resultado: {result}");
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("Error: No se puede dividir entre 0.");
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex){
                Console.WriteLine("Error: No se puede convertir el valor a un número.");
                Console.WriteLine($"Error: {ex.Message}");
        }
        finally{
            Console.WriteLine("Fin del programa.");
        }
    }
}
}