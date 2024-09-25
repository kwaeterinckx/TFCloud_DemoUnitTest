using DemoUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest_XUnit
{
    public class AdditionTest
    {
        [Fact]
        public void AdditionEntierValide()
        {
            Calcul c = new Calcul();
            int result = c.Addition(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void AdditionValeurLimite()
        {
            Calcul c = new Calcul();
            Assert.Throws<OverflowException>(
                () => c.Addition(int.MaxValue, 10)
                );
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(17, 25, 42)]
        public void AdditionMultipleValeur(int a, int b, int result)
        {
            Calcul c = new Calcul();
            Assert.Equal(result, c.Addition(a, b));
        }
    }
}
