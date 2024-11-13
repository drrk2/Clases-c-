namespace ConsoleApp1{
    public class Car{
        public string Brand {get; set;}
        public string Model {get; set;}
        public Car(string brand, string model){
            Brand = brand;
            Model = model;
            Console.WriteLine($"{Brand} {Model} creado.");
        }

        //destructor
        ~Car(){
            Console.Write($"{Brand} {Model} eliminado");
        }
    public void DisplayInfo(){
        Console.WriteLine($"Marca: {Brand}, Model: {Model}");
    }


}
}