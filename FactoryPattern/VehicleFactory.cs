using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle BuildVehicle(int answer)
		{
			switch (answer)
			{
				case 2:
					return new Motorcycle();
				case 4:
					return new Car();
				case 6:
					return new Dualie();
				case 18:
					return new Semi();
				default:
					return new Car(); 
			}
		}
	}
}

