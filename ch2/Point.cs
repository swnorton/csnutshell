using System;

namespace Point
{
	// public struct Point { public int x, y; }
	public class Point { public int x, y; }
	
	class Test
	{
		static void Main()
		{
			Point p1 = new Point();
			p1.x = 7;
			
			Point p2 = p1;
	
			Console.WriteLine(p1.x);
			Console.WriteLine(p2.x);
			
			p2.x = 12;
			Console.WriteLine(p1.x);
			Console.WriteLine(p2.x);
			
			Console.WriteLine(p1.x.GetType());
			Console.WriteLine(12.GetType());
			Console.WriteLine(0.0 / 0.0);
			Console.WriteLine(double.IsNaN (0.0 / 0.0));
			Console.WriteLine(0.0 / 0.0 == 0.0 / 0.0);
			Console.WriteLine(Object.Equals(0.0 / 0.0, double.NaN));
		}
	}
}
