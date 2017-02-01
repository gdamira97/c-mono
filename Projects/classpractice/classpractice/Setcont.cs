using System;
namespace classpractice
{
	public class Setcont
	{
		Set[] _sets;
		int index;
		public Setcont(int size)
		{
			_sets = new Set[size];
		}
		public bool AddSet(Set set)
		{
			if (index < _sets.Length)
			{
				_sets[index++] = set;
				return true;
			}
			else
			{
				return false;
			}
		}
		public void PrintSets()
		{
			foreach (Set s in _sets)
			{
				s.PrintSet();
			}
		}
	}
}
