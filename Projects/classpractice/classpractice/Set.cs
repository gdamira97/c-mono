using System;
using System.Collections;
            
namespace classpractice
{
	public class Set
	{
		int i = 0;
		int size = 0;
		int[] array = new int[0];
		public Set(int size)
		{
			this.size = size;
			array = new int[size];
		}
		public void AddElement(int e)
		{
			array[i] = e;
			i++;
		}
		public void PrintSet()
		{
			for (int i = 0; i < size; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
		}
		public int elementOf(int x)
		{
			return array[x];
		}
		public int length()
		{
			return array.Length;
		}
		public Set union(Set array2)
		{
			ArrayList r = new ArrayList();
			for (int i = 0; i < array.Length; i++)
			{
				r.Add(array[i]);
			}
			for (int j = 0; j < array2.length(); j++)
			{
				r.Add(array2.elementOf(j));
			}
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array2.length(); j++)
				{
					if (array[i] == array2.elementOf(j))
					{
						r.Remove(array2.elementOf(j));
					}
				}
			}
			Set result = new Set(r.Count);
			foreach (int y in r)
			{
				result.AddElement(y);
			}
			return result;
		}
		public Set intersection(Set array2)
		{
			ArrayList r = new ArrayList();
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array2.length(); j++)
				{
					if (array[i] == array2.elementOf(j))
					{
						r.Add(array2.elementOf(j));
					}
				}
			}
			Set result = new Set(r.Count);
			foreach (int y in r)
			{
				result.AddElement(y);
			}
			return result;
		}
		public void printSet()
		{
			Console.Write("{ ");
			foreach (int item in array)
			{
				Console.Write(item + " ");
			}
			Console.Write("}\n");
		}
	}
}

