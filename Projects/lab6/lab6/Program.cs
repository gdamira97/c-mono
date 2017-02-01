using System;

namespace lab6
{
	
	class MainClass
	{
		public static void Main(string[] args)
		{
			University univer = new University(2);
			Student s = new Student("Vasya Pupkin", Occupation.IS);
			Teacher t = new Teacher("Bill Gates", Occupation.CSS, Occupation.IS);
			univer.AddHuman(s);
			univer.AddHuman(t);
			univer.PrintDetails();
		}
	}
}
