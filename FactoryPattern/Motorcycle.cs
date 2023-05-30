using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
        public void Drive()
        {
            ConsoleLogging.CarBuildingText();

            Console.WriteLine("Your new Motorcycle is ready!");
        }
    }
}

