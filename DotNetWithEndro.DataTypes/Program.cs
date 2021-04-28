using System;
using System.Collections.Generic;

namespace DotNetWithEndro.DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int maxNumberOfSpoonfuls = 10;
			var maxTemperature = 20.25;
			var greeting = "Hello!";
			var answerYesOrNo = 'Y';
			var isSummer = false;

			var today = new DateTime(2021, 4, 19);

			var nycPopulationAsString = "124000";
			var albanyPopulationAsString = "75000";

			int nycPopulation;
			int albanyPopulation;

			if (int.TryParse(nycPopulationAsString, out nycPopulation)
					&& int.TryParse(albanyPopulationAsString, out albanyPopulation))
			{
				var total = nycPopulation + albanyPopulation;

				Console.WriteLine("Total population is: " + total);
			}
			else
			{
				Console.WriteLine("The provided numbers are not valid");
			}

			var price1AsString = "1587.50";
			double price1;

			if (double.TryParse(price1AsString, out price1))
			{
				Console.WriteLine("The price is: " + price1);
			}
			else
			{
				Console.WriteLine(price1AsString +  " is not a valid number");
			}

			var dateAsString = "03/21/2021";
			DateTime ditaPranveres;


			if (DateTime.TryParse(dateAsString, out ditaPranveres))
			{
				Console.WriteLine("Dita e pranveres eshte me " + ditaPranveres);
			}
			else
			{
				Console.WriteLine(dateAsString + " is not a valid date");
			}

			var num1 = 1246;
			var num2 = 2;

			var remainder = num1 % num2;

			Console.WriteLine("Remiander is: " + remainder);

			num1 = num1 + 1;
			Console.WriteLine(num1);

			Console.WriteLine(++num1);

			//arrays
			var maxNumberOfSpoonfulsList = new int[10] { 1, 3, 12, 45, 12, 5, 7, 9, 2, 8 };
			var maxTemperatures = new double[4] { 21.02, 30, 12.5, 7.25 };
			var reviews = new string[5] { "Very good", "Horrible", "Excellent product", "It sucks. I want my money back", "Piece of garbage" };
			var answers = new char[2] { 'Y', 'N' };

			Console.WriteLine("First element of the array: " + maxNumberOfSpoonfulsList[0]);
			Console.WriteLine("Last element of the array: " + maxNumberOfSpoonfulsList[9]);
			Console.WriteLine("The length of the maxNumberOfSpoonfulsList array is: " + maxNumberOfSpoonfulsList.Length);


			for (int idx = 0; idx < maxTemperatures.Length; idx++)
			{
				Console.WriteLine(maxTemperatures[idx]);
			}

			var counter = 0;

			foreach (var review in reviews)
			{
				if (IsPositiveReview(review))
				{
					Console.WriteLine(review);
				}
				else
				{
					counter++;
					Console.WriteLine("******** " + review + " ******** ");
					Console.WriteLine($"******** Bad review #{counter} {review} ********");
				}
			}

			//lists
			var maxNumberOfSpoonfulsList2 = new List<int>();
			maxNumberOfSpoonfulsList2.Add(1);
			maxNumberOfSpoonfulsList2.Add(5);



			Console.WriteLine("That's all Folks!");
		}


		private static bool IsPositiveReview(string review)
		{
			if (review.Contains("good", StringComparison.OrdinalIgnoreCase)
				|| review.Contains("excellent", StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
