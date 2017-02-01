using System;
namespace lab6
{
	public enum Occupation { IS, CSS, Math }
	public class Human
	{
		Occupation _occupation;
		string _name;

		protected Occupation _otherOccupation;

		public Human(string name, Occupation occupation)
		{
			_name = name;
			_occupation = occupation;
		}
		public Human(string name, Occupation occupation, Occupation otherOccupation)
		{
			_name = name;
			_occupation = occupation;
			_otherOccupation = otherOccupation;
		}

		public virtual void PrintDetails()
		{
			string type = GetType().ToString();
			type = type.Substring(type.LastIndexOf('.') + 1);
			Console.WriteLine($"I'm {_name}, {type} at University and my ocupation is {_occupation}\n");
		}
	}
}

