using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
	public class Calculator
	{
		public int Add(int left, int right)
		{
			return left + right;
		}

		public double Divide(double left, double right)
		{
			if (right == 0)
			{
				throw new ArgumentOutOfRangeException("right", "0除算です。");
			}

			return left / right;
		}
	}
}
