using System;
namespace lab6
{
	public class Teacher:Human
	{
		public Teacher(string name, Occupation ocupation, Occupation otherOccupation) : base(name, ocupation, otherOccupation)
		{
			_otherOccupation = otherOccupation;
		}
		public override void PrintDetails()
		{
			base.PrintDetails();
			Console.WriteLine($"My second occupation is {_otherOccupation}\n");
		}
	}
}

