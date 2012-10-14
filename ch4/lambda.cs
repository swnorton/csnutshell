using System;

namespace Application
{
	class Test
	{
		static Func<int> MakeFunc()
		{
			int seed = 0;
			return () => seed++;
		}
		
		static void Main()
		{
			int power = 2;
			Func<int> func = new MakeFunc();
			System.Console.WriteLine(func());
			System.Console.WriteLine(func());
		}
	}
}

