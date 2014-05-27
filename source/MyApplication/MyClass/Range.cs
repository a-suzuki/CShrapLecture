using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
	public class Range
	{
		public Range(int lower, int upper)
		{
			this.Lower = lower;
			this.Upper = upper;
		}

		public int Lower { get; set; }

		public int Upper { get; set; }

		public bool Within(int value)
		{
			return (this.Lower <= value) && (value <= this.Upper);
		}

		private int method()
		{
			return 1;
		}
	}
}
