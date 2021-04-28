using System;

namespace DotNetWithEndro.Branching
{
	class Program
	{
		static void Main(string[] args)
		{

			var temp = 17;

			if (temp > 18 && temp < 25)
			{
				Console.WriteLine("It's pretty warm. I will put on a T-shirt");
			}
			else if (temp > 25)
			{
				Console.WriteLine("It's pretty hot. I will put the shorts on");
			}
			else
			{
				Console.WriteLine("I better put on a shirt");
			}

			var isRaining = false;

			if (isRaining)
			{
				Console.WriteLine("Don't forget the ambrella");
			}

			Console.WriteLine("Let's go to school");


			var dice = RollTheDice();
			var lang = "en";

			switch (dice)
			{
				case 1:
					if (lang == "sq")
					{
						Console.WriteLine("Nje");
					}
					else
					{
						Console.WriteLine("One");
					}
					break;
				case 2:
					if (lang == "sq")
					{
						Console.WriteLine("Dy");
					}
					else
					{
						Console.WriteLine("Two");
					}
					break;
				case 3:
					if (lang == "sq")
					{
						Console.WriteLine("Tre");
					}
					else
					{
						Console.WriteLine("Three");
					}
					break;
				case 4:
					if (lang == "sq")
					{
						Console.WriteLine("Kater");
					}
					else
					{
						Console.WriteLine("Four");
					}
					
					break;
				case 5:
					if (lang == "sq")
					{
						Console.WriteLine("Pese");
					}
					else
					{
						Console.WriteLine("Five");
					}
					
					break;
				case 6:
					if (lang == "sq")
					{
						Console.WriteLine("Gjashte");
					}
					else
					{
						Console.WriteLine("Six");
					}
					break;
				default:
					Console.WriteLine("Wrong number");
					break;
			}


			Console.WriteLine("That's all Folks!");

		}


		static int RollTheDice()
		{
			var rnd = new Random();
			var randomNumber = rnd.Next(1, 7);

			return randomNumber;
		}

	}


}
