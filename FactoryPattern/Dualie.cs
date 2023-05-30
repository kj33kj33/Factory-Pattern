using System;
namespace FactoryPattern
{
    public class Dualie : IVehicle
    {
        public void Drive()
        {
            ConsoleLogging.CarBuildingText();

            Console.WriteLine("Your new Dualie is ready!");
        }
    }
}

