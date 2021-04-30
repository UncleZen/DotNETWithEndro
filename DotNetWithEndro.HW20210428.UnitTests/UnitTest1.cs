using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetWithEndro.HW20210428.UnitTests
{
	[TestClass]
	public class MathHelperTests
	{
		[TestMethod]
		public void when_adding_two_number_correct_result_must_be_returned()
		{

			var n1 = 34;
			var n2 = 23;

			var mathHelper = new MathHelper();

			var shuma = mathHelper.Add(n1, n2);

			Assert.AreEqual(57, shuma);

		}

		[TestMethod]
		public void when_subtracting_two_number_correct_result_must_be_returned()
		{

			var n1 = 34;
			var n2 = 23;

			var mathHelper = new MathHelper();

			var diferenca = mathHelper.Sub(n1, n2);

			Assert.AreEqual(11, diferenca);

		}
	}
}
