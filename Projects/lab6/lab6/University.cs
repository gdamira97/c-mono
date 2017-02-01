using System;
namespace lab6
{
	public class University
	{
		Human[] _people;
		int index;

		public University(int Capacity)
		{

			_people = new Human[Capacity];
		}

		public bool AddHuman(Human human)
		{
			if (index < _people.Length)
			{
				_people[index++] = human;
				return true;
			}
			else
			{
				return false;
			}
		}

		public virtual void PrintDetails()
		{
			foreach (Human t in _people)
			{
				t.PrintDetails();
			}
		}
	}
}

