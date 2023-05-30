using System;
namespace FactoryPattern
{
	public class Semi : IVehicle
	{
        public void Drive()
        {
            ConsoleLogging.CarBuildingText();

            Console.WriteLine("Your new Semi is ready!");
        }    
    }
}

