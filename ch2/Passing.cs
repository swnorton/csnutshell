using System;

namespace Application
{
	public class Passing
	{
		static void Foo(int x)
		{
			x += 1;
			Console.WriteLine (x);
		}	
		
		static void Foo(ref int x)
		{
			x += 1;
			Console.WriteLine (x);
		}
				
		static void Main()
		{
			int z = 5;
			Foo (z);
			Console.WriteLine (z);
			Foo (ref z);
			Console.WriteLine (z);
		}
	}
}

