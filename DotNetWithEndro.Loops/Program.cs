using System;

namespace DotNetWithEndro.Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			var maxNumberOfSugarSpoonfuls = 5;
			var lugeSheqer = 10; 
			var counter = 1;
			
			while (counter <= lugeSheqer)
 			{

				if (counter > maxNumberOfSugarSpoonfuls)
				{
					break;
				}

				Console.WriteLine("Qite sheqer");
				counter++;
			}

			Console.WriteLine("Pije qajin");

			for(counter = 1; counter <= lugeSheqer; counter++)
			{
				if (counter > maxNumberOfSugarSpoonfuls)
				{
					break;
				}
				Console.WriteLine("Qite sheqer");
			}

			Console.WriteLine("Pije qajin");


			var reviews = new string[5] { "Very good", "Horrible", "Excellent product", "It sucks. I want my money back", "Piece of garbage" };

						
			var length = reviews.Length;

			for(var index = 0; index < length; index++)
			{
				Console.WriteLine(reviews[index]);
			}


			var lugeTeKafes = 0;
			counter = 1;


			do
			{
				Console.WriteLine("Qite kafe");
				counter++;
			} while (counter <= lugeTeKafes);

			Console.WriteLine("Pije kafen");



			Console.WriteLine("That's all Folks!");
		}
	}
}
