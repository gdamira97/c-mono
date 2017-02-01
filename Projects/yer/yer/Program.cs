using System;

namespace yer
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int first=0;
			int last=0;
			int[] a = new int[10] { 1, 10, 6, 3, 5, 1, 4, 4, 9, 8};
			for (int i = 0; i < a.Length; i++)
			{
				if (a[0] < a[i] && a[i] < a[9])
				{
					last = i+1;
				}
			}
			for (int i = 0; i < a.Length; i++)
			{
				if (a[0] < a[i] && a[i] < a[9])
				{
					first = i+1;
					break;
				}
			}
			Console.WriteLine("First: " + first);
			Console.WriteLine("Last: " + last);
		}
	}
}
