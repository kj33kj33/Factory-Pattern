namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your ride have?");

            var answer = int.Parse(Console.ReadLine());

            IVehicle newVehicle = VehicleFactory.BuildVehicle(answer);

            newVehicle.Drive();
        }
    }
}
