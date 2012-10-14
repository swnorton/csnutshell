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
			double power = 2;
			Func<double,double> pwr = n => Math.Pow(n, power);
			Console.WriteLine(pwr(5));
			
			Func<int> func = MakeFunc();
			Console.WriteLine(func());
			Console.WriteLine(func());
		}
	}
}

