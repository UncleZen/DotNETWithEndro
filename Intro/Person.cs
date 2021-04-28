using System;
using System.Collections.Generic;

namespace Intro
{
	public class Person
	{

		public Person(string name, DateTime dob, string countyOfOrigin)
		{
			Name = name;
			DateOfBirth = dob;
			CountryOfOrigin = countyOfOrigin;
		}

		public string Name { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string CountryOfOrigin { get; set; }

		public List<string> SetOfSkills { get; set; }

		public int Age()
		{
			var now = DateTime.Now;
			var lifeSpan = now - DateOfBirth;
			var age = (int)(lifeSpan.TotalDays / 365);

			return age;
		}

	}
}
