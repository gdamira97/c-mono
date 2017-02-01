using System;

namespace Practice
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Variant A
			Console.WriteLine("Variant A:");
			int[] a = new int[] { 1, 3, 5, 4, 2 };
			for (int i = 0; i < 5; i++)
				Console.Write(a[i] + " ");

			//Sum
			int s = 0;
			for (int i = 0; i < 5; i++)
			{
				s += a[i];
			}
			Console.WriteLine("\nSum = " + s);

			//Product
			int p = 1;
			for (int i = 0; i < 5; i++)
			{
				p *= a[i];
			}
			Console.WriteLine("Product = " + p);

			//Even numbers
			int counteven = 0;
			foreach (int i in a)
				if (i % 2 == 0)
					counteven++;
			Console.WriteLine("Even numbers = " + counteven);

			//Odd numbers
			int countodd = 0;
			foreach (int i in a)
				if (i % 2 != 0)
					countodd++;
			Console.WriteLine("Odd numbers = " + countodd);

			//Positive numbers
			int countpos = 0;
			foreach (int i in a)
				if (i > 0)
					countpos++;
			Console.WriteLine("Positive numbers = " + countpos);

			//Negative numbers
			int countneg = 0;
			foreach (int i in a)
				if (i < 0)
					countneg++;
			Console.WriteLine("Negative numbers = " + countneg);

			//Max
			int max = 0;
			foreach (int i in a)
				if (i > max)
					max++;
			Console.WriteLine("Max = " + max);

			//Min
			int min = a[0];
			foreach (int i in a)
				if (i < min)
					min++;
			Console.WriteLine("Min = " + min);

			//Variant B
			Console.WriteLine("Variant B:");
			int e1 = 0;
			int e2 = 0;
			int[,] l = new int[,] { { 2, 3 },
									{ 3, 3 },
									{ 1, 3 },
									{ 2, 2 } };
			for (int i = 0; i < l.GetLength(0); i++)
			{
				for (int j = 0; j < l.GetLength(1); j++)
				{
					Console.Write(string.Format("{0} ", l[i, j]));
				}
				Console.Write(Environment.NewLine + Environment.NewLine);
			}
			for (int i = 0; i < l.GetLength(0); i++)
			{
				for (int j = 1; j < l.GetLength(0) - 1; j++)
				{
					if (l[i, 0] == l[j, 0])
						e1++;
					else if (l[i, 1] == l[j, 1])
						e2++;
				}
			}

			if (e1 > e2)
				Console.WriteLine("The index of column with maximum equal elements is 1");
			else if (e1 < e2)
				Console.WriteLine("The index of column with maximum equal elements is 2");
		}
	}
}