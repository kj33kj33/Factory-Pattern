using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
        public void Drive()
        {
            ConsoleLogging.CarBuildingText();

            Console.WriteLine("Your new Car is ready!");
        }
    }
}

