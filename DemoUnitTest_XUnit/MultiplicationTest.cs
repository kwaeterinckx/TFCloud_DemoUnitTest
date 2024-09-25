using DemoUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_XUnit
{
	public class MultiplicationTest
	{
		[Fact]
		public void MultiplicationnEntierValide()
		{
			Calcul c = new Calcul();
			int result = c.Multiplication(8, 2);
			Assert.Equal(16, result);
		}

		[Fact]
		public void MutliplicationValeurLimite()
		{
			Calcul c = new Calcul();
			Assert.Throws<OverflowException>(() => c.Multiplication(int.MinValue, 10));
		}

		[Theory]
		[InlineData(5, 5, 25)]
		[InlineData(8, 9, 72)]
		[InlineData(8, -9, -72)]
		[InlineData(17, 25, 425)]
		public void MultiplicationMultipleValeur(int a, int b, int result)
		{
			Calcul c = new Calcul();
			Assert.Equal(result, c.Multiplication(a, b));
		}
	}
}
