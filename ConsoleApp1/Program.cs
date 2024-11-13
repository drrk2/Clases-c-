namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un Car
            Car myCar = new Car("Toyota", "Corolla");
            myCar.DisplayInfo();
            //Aqui el objeto mycar sera destruido cuando termine el alcance
        }
    }
}