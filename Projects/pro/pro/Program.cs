using System;

namespace pro
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			for (int i = 0; i < 100; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					for (int k = 0; k < 100; k++)
					{
						if (i + j + k == 100 && 10*i+5*j+0.5*k==100)
						{
							Console.WriteLine(i + " ," + j + " ," + k);
							break;
						}

					}
				}
			}

		}
	}
}
