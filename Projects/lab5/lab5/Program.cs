using System;
using System.Collections.Generic;

namespace lab5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = 0;
			int m = 0;
			int[] arr_1 = new int[n];
			int[] arr_2 = new int[m];

			do
			{
				Console.WriteLine("Enter the lenght of the first set: ");
				n = Convert.ToInt32(Console.ReadLine());
				string[] arr_temp = Console.ReadLine().Split(',');
				arr_1 = Array.ConvertAll(arr_temp, Int32.Parse);
			} while (arr_1.Length != n);

			do
			{
				Console.WriteLine("Enter the lenght of the second set: ");
				m = Convert.ToInt32(Console.ReadLine());
				string[] arr_temp = Console.ReadLine().Split(',');
				arr_2 = Array.ConvertAll(arr_temp, Int32.Parse);
			} while (arr_1.Length != n);

			Sets a = new Sets(arr_1);
			Sets b = new Sets(arr_2);
			a.printSet();
			b.printSet();
			a.intersect(b);
			a.union(b);
		}
	}

	class Sets
	{
		int[] _a = new int[0];
		public Sets(int[] a)
		{
			_a = a;
		}
		public int elOf(int x)
		{
			return _a[x];
		}
		public int length()
		{
			return _a.Length;
		}
		public void intersect(Sets b)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < _a.Length; i++)
			{
				for (int j = 0; j < b.length(); j++)
				{
					if (_a[i] == b.elOf(j))
					{
						result.Add(_a[i]);
					}
				}
			}
			Console.Write("Intersection: { ");
			for (int k = 0; k < result.Count; k++)
			{
				Console.Write(result[k] + " ");
			}
			Console.Write("}\n");
		}
		public void union(Sets b)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < _a.Length; i++)
			{
				result.Add(_a[i]);
			}
			for (int j = 0; j < b.length(); j++)
			{
				result.Add(b.elOf(j));
			}
			for (int i = 0; i < _a.Length; i++)
			{
				for (int j = 0; j < b.length(); j++)
				{
					if (_a[i] == b.elOf(j))
					{
						result.Remove(b.elOf(j));
					}
				}
			}
			Console.Write("Union: { ");
			for (int k = 0; k < result.Count; k++)
			{
				Console.Write(result[k] + " ");
			}
			Console.Write("}\n");
		}
		public void printSet()
		{ 
			Console.Write("{ ");
			for (int i = 0; i < _a.Length; i++)
			{
				Console.Write(_a[i] + " ");
			}
			Console.Write("}\n");
		}
	}
}
