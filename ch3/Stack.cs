using System;

namespace Application
{
	public class Stack<T>
	{
		static int position;
		static T[] data = new T[100];
		public void push(T obj) { data[position++] = obj;  }
		public T pop()          { return data[--position]; }
	}
	
	class Test
	{
		static void Main()
		{
			Stack<int> stack = new Stack<int>();
			stack.push (5);
			stack.push (10);
			
			Stack<int> stack2 = new Stack<int>();
			
			Console.WriteLine (stack.pop ());
			Console.WriteLine (stack2.pop ());
			
		}
	}
}

