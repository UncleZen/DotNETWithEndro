using System;

namespace DotNetWithEndro.HW20210428
{
	public class MathHelper
	{
		public MathHelper()
		{
		}


		/// <summary>
		///		This method is used to calculate the sum of two numbers
		/// </summary>
		/// <param name="number1">The number of type <see cref="System.Int32"/> to add up</param>
		/// <param name="number2">The number of type <see cref="System.Int32"/> to add up</param>
		/// <returns></returns>
		public int Add(int number1, int number2)
		{
			var shuma = number1 + number2;
			return shuma;
		}

		public int Sub(int number1, int number2)
		{
			var diff = number1 - number2;
			return diff;
		}

		public int Multiply(int number1, int number2)
		{
			var product = number1 * number2;
			return product;
		}

		public int Devide(int number1, int number2)
		{
			var quotient = number1 / number2;
			return quotient;
		}
	}
}
