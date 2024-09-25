using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitTest
{
	public class Calcul
	{
		public int Addition(int nb1, int nb2)
		{
			checked
			{
				try
				{
					int result = nb1 + nb2;
					return result;
				}
				catch
				{
					throw new OverflowException("Limite d'entier dépassée");
				}
			}
		}
		public int Soustraction(int nb1, int nb2)
		{
			checked
			{
				try
				{
					int result = nb1 - nb2;
					return result;
				}
				catch
				{
					throw new OverflowException("Limite d'entier dépassée");
				}
			}
		}
		public int Multiplication(int nb1, int nb2)
		{
			checked
			{
				try
				{
					int result = nb1 * nb2;
					return result;
				}
				catch
				{
					throw new OverflowException("Limite d'entier dépassée");
				}
			}
		}
		public double Division(int nb1, int nb2)
		{
			checked
			{
				if (nb2 == 0) throw new DivideByZeroException("Division par zéro impossible.");
				double result = (double)nb1 / nb2;
				return result;
			}
		}
	}
}
