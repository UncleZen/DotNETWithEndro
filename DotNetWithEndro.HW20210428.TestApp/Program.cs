using System;

namespace DotNetWithEndro.HW20210428.TestApp
{
	class Program
	{
		static void Main(string[] args)
		{

			var mathLibrary = new MathHelper();

			var n1 = 15;
			var n2 = 4;

			var shuma = mathLibrary.Add(n1, n2);
			Console.WriteLine($"Shuma e numrave {n1} dhe {n2} eshte {shuma}");

			var diferenca = mathLibrary.Sub(n1, n2);
			Console.WriteLine($"Diferenca e numrave {n1} dhe {n2} eshte {diferenca}");

			var produkti = mathLibrary.Multiply(n1, n2);
			Console.WriteLine($"Produkti e numrave {n1} dhe {n2} eshte {produkti}");

			var pjestimi = mathLibrary.Devide(n1, n2);
			Console.WriteLine($"Pjestimi e numrave {n1} dhe {n2} eshte {pjestimi}");

			Console.WriteLine("Hello World!");
		}
	}
}
