using System;

namespace Application
{
	public class Panda
	{
		public string Name;
		public static int Population;
		
		public Panda (string n) { 
			Name = n;
			Population += 1;
		}
	}
	
	class Test
	{
		static void Main()
		{
			Panda p1 = new Panda("Pan Dee");
			Panda p2 = new Panda("Pan Duh");
			
			Console.WriteLine (p1.Name);
			Console.WriteLine (p2.Name);
			Console.WriteLine (Panda.Population);
		}
	}
}

