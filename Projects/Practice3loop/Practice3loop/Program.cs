using System;

namespace Practice3loop
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a;
			int b;
			int h;
			int n;
			double s=1;
			Console.WriteLine("Variant A:");
			do
			{
				Console.WriteLine("Enter a: ");
			} while (!int.TryParse(Console.ReadLine(), out a));
			do
			{
				Console.WriteLine("Enter b: ");
			} while (!int.TryParse(Console.ReadLine(), out b));
			do
			{
				Console.WriteLine("Enter h: ");
			} while (!int.TryParse(Console.ReadLine(), out h));
			do
			{
				Console.WriteLine("Enter n: ");
			} while (!int.TryParse(Console.ReadLine(), out n));

			int[] f = new int[b-a];
			for (int i = a; i <= b; i++)
			{
				for (int j = 0; j <= f.Length-1; j++)
				f[j] = (h + i) / 2;
			}
			foreach (int x in f)
			{
				for (int k = 0; k <= n; k++)
				{
					s *= k / (k + 1) - Math.Pow(Math.Abs(x), k);
					Console.WriteLine("For x = " + x + ": " + "S(x) = " + s);
				}
			}

			Console.WriteLine("Variant B:");
			int m;
			double sum=0;
			do
			{
				Console.WriteLine("Enter m: ");
			} while (!int.TryParse(Console.ReadLine(), out m));
			int p = 1;
			while (p != m)
			{
				sum += Math.Pow(p, 2);
				p++;
			}
			Console.WriteLine("Sum = " + sum);
		}
	}
}
