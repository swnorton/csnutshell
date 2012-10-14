using System;
namespace Application
{
	public class Test
	{
		static int Calc(int x) { return 10 / x; }
		
		static void Main()
		{
			try
			{
				int y = Calc(0);
				Console.WriteLine (y);
			}
			catch(DivideByZeroException)
			{
				Console.WriteLine ("x cannot be zero");
			}
			Console.WriteLine ("program completed");
		}
	}
}

