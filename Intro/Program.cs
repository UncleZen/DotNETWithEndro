using System;
using System.Collections.Generic;

namespace Intro
{
	class Program
	{
		static void Main(string[] args)
		{

			var endrit = new Person("Endro", new DateTime(2003, 6, 4), "Kosovo");
						
			Console.WriteLine("Hello my name is " + endrit.Name + " and I am " + endrit.Age() + " years old. Nice meeting you!");


			var ari = new Person("Ari", new DateTime(2012, 8, 5), "Canada");
			Console.WriteLine("Hello my name is " + ari.Name + " and I am " + ari.Age() + " years old. Nice meeting you!");

			var list = new List<Person>();
			list.Add(endrit);
			list.Add(ari);

			var serializedList = Newtonsoft.Json.JsonConvert.SerializeObject(list);

			var newList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(serializedList);

			Console.WriteLine(serializedList);
		}
	}
}

