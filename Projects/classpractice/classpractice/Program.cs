using System;

namespace classpractice
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Set a = new Set(2);
			a.AddElement(3);
			a.AddElement(5);
			Set b = new Set(3);
			b.AddElement(3);
			b.AddElement(4);
			b.AddElement(5);
			Setcont sc = new Setcont(2);
			sc.AddSet(a);
			sc.AddSet(b);
			sc.PrintSets();
			Set u = a.union(b);
			Console.WriteLine("Union: ");
			u.printSet();
			Set inter = a.intersection(b);
			Console.WriteLine("Intersection: ");
			inter.printSet();
		}
	}
}
