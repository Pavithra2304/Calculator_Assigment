using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		public static int Add(int x,int y)
		{
			
			int result = x + y;
			return result;
			
			
		}
		public static int Sub(int x,int y,out int z)
		{
			
			 z = x - y;
			return z;
			
		}
		public static int Mul(int x, int y)
		{
			
			int result = x * y;
			return result;
		}
		public static int Div(int x,int y, out int z)
		{
			
			z = x - y;
			return z;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Calculator :");
			Console.WriteLine("Enter 1 for Addition");
			Console.WriteLine("Enter 2 for Subtraction");
			Console.WriteLine("Enter 3 for Multiplication");
			Console.WriteLine("Enter 4 for Division \n");
			int choice = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please Enter the First Input");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please Enter the Second Input");
			int y = Convert.ToInt32(Console.ReadLine());
			int output = 0;
			int yes = 1;
			do
			{
				switch (choice)
				{
					case 1:
						{
							output = Add(x, y);
							Console.WriteLine("The ouput is " + output);
							break;
						}
					case 2:
						{
							output = Sub(x, y, out int z);
							Console.WriteLine("The ouput is " + output);
							break;
						}
					case 3:
						{
							output = Mul(x, y);
							Console.WriteLine("The ouput is " + output);
							break;
						}
					case 4:
						{
							output = Div(x, y, out int z);
							Console.WriteLine("The ouput is " + output);
							break;
						}

						
				}
				Console.WriteLine("Do you Want to Continue 1. Yes 2. No \n");
				int action = Convert.ToInt32(Console.ReadLine());
				if (action == 2)
					yes++;

			} while (yes==1);
			
		}
		
	}
}
