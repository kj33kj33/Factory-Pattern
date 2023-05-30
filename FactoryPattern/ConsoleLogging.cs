using System;
namespace FactoryPattern
{
	public class ConsoleLogging
	{
		public static void CarBuildingText()
		{
			Console.WriteLine("Designing frame");
			Thread.Sleep(1000);
			Console.WriteLine("Installing body");
            Thread.Sleep(1000);
            Console.WriteLine("Adding wheels");
            Thread.Sleep(1000);
            Console.WriteLine("And:");
            Thread.Sleep(333);
			Console.WriteLine("3");
            Thread.Sleep(333);
			Console.WriteLine("2");
            Thread.Sleep(333);
			Console.WriteLine("1");
            Thread.Sleep(333);
        }
	}
}

