using System;

namespace practice2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Example
			//double x = 2.444;
			//double y = 0.0869;
			//double z = -130.0;
			//double h = ((Math.Pow(x, y + 1) + Math.Exp(y - 1)) / (1 + x * Math.Abs(y - Math.Tan(z)))) * (1 + Math.Abs(y - x)) + (Math.Pow(Math.Abs(y - x), 2) / 2) - (Math.Pow(Math.Abs(y - x), 3) / 3);
			//Console.WriteLine(h);

			//A Variant
			Console.WriteLine("b:");
			double b = double.Parse(Console.ReadLine());
			Console.WriteLine("x:");
			double x = double.Parse(Console.ReadLine());
			double y = b + Math.Exp(Math.Sqrt(Math.Abs(x + Math.Cos(x) - Math.Tan(Math.Pow(x, 3)))));
			Console.WriteLine("Y = " + y);

			//B Variant
			//double a;
			//do
			//{
			//	Console.WriteLine("Enter the area of the circle:");
			//} while (!double.TryParse(Console.ReadLine(), out a));
			//double r = Math.Sqrt(a / Math.PI);
			//double l = r * Math.PI;
			//Console.WriteLine("The length of the circle: " + l);
		}
	}
}
