using DemoUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_XUnit
{
	public class DivisionTest
	{
		[Fact]
		public void DivisionEntierValide()
		{
			Calcul c = new Calcul();
			double result = c.Division(8, 2);
			Assert.Equal(4, result);
		}

		[Fact]
		public void DivisionParZero()
		{
			Calcul c = new Calcul();
			Assert.Throws<DivideByZeroException>(() => c.Division(50, 0));
		}

		[Theory]
		[InlineData(5, 5, 1)]
		[InlineData(64, 4, 16)]
		[InlineData(5, 2, 2.5)]
		public void DivisionMultipleValeur(int a, int b, double result)
		{
			Calcul c = new Calcul();
			Assert.Equal(result, c.Division(a, b));
		}
	}
}
