using System;

namespace Practice3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double a;
			double b;
			double x;
			double m;
			double y;
			int ab;
			int bc;
			int ac;
			Console.WriteLine("Variant A:");
			//do
			//{
			//	Console.WriteLine("Enter a: ");
			//} while (!double.TryParse(Console.ReadLine(), out a));
			a = readvar("a");
			b = readvar("b");
			x = readvar("x");
			m = readvar("m");


			if ((a + b * Math.Pow(x, m)) > 0 && (a + b * Math.Pow(x, m)) < Math.PI)
			{
				y = Math.Pow(Math.Tan(Math.Pow(Math.Cos(Math.Abs(Math.Log10(Math.Sin(a + b * Math.Pow(x, m))))), 2)), 4 / m);
			}
			else {
				y = Math.Pow(Math.Tan(Math.Pow(Math.Tan(Math.Abs(Math.Pow(Math.Cos(Math.Sin(a + b * x)), Math.Sin(a * x)))), m)), 4 / m);
			}
			Console.WriteLine("y = " + y);

			Console.WriteLine("Variant B:");
			do
			{
				Console.WriteLine("Enter AB: ");
			} while (!int.TryParse(Console.ReadLine(), out ab));
			do
			{
				Console.WriteLine("Enter BC: ");
			} while (!int.TryParse(Console.ReadLine(), out bc));
			do
			{
				Console.WriteLine("Enter AC: ");
			} while (!int.TryParse(Console.ReadLine(), out ac));

			if (ab + bc > ac)
			{
				Console.WriteLine("They can create a triangle");
				int[] l = new int[3] { ab, bc, ac };
				int min = l[0];
				int z = 0;
				int p = 0;
				foreach (int i in l)
					if (i < min)
					{
						min = i;
						min++;
					}
				if (ab == bc || bc == ac || ab == ac)
					p = 1;
				if (min == ab)
				{
					z = 1;
				}
				else if (min == bc)
				{
					z = 2;
				}
				else {
					z = 3;
				}
				if (p == 0)
					switch (z)
					{
						case 1:
							Console.WriteLine("Sharp angle is - BCA");
							break;
						case 2:
							Console.WriteLine("Sharp angle is - BAC");
							break;
						case 3:
							Console.WriteLine("Sharp angle is - ABC");
							break;
					}
				else
					switch (z)
					{
						case 1:
							Console.WriteLine("Sharp angle is - BCA. This triangle has two or more equal sides");
							break;
						case 2:
							Console.WriteLine("Sharp angle is - BAC. This triangle has two or more equal sides");
							break;
						case 3:
							Console.WriteLine("Sharp angle is - ABC. This triangle has two or more equal sides");
							break;
					}
			}
			else
				Console.WriteLine("They can't create a triangle");
		}
		public static double readvar(string a)
		{
			double x;
		do
			{
				Console.WriteLine($"Enter {a}: ");
			} while (!double.TryParse(Console.ReadLine(), out x));
			return x;
		}
	}
}
