using System;

namespace Intro
{
	class Program
	{
		static void Main(string[] args)
		{

			var endrit = new Person();
			endrit.Name = "Endro";
			endrit.DateOfBirth = new DateTime(2003, 6, 4);

			
			Console.WriteLine("Hello my name is " + endrit.Name + " and I am " + endrit.Age() + " years old. Nice meeting you!");


			var ari = new Person();
			ari.Name = "Ari";
			ari.DateOfBirth = new DateTime(2012, 8, 5);

		
			Console.WriteLine("Hello my name is " + ari.Name + " and I am " + ari.Age() + " years old. Nice meeting you!");

		}
	}
}

