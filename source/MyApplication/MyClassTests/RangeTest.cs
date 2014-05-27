using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;

namespace MyClassTests
{
	[TestClass]
	public class RangeTest
	{
		[TestMethod]
		public void RangeConstructor()
		{
			int lower = 1;
			int upper = 10;
			Range range = new Range(lower, upper);

			Assert.AreEqual(lower, range.Lower);
			Assert.AreEqual(upper, range.Upper);
		}



		[TestMethod]
		public void PrivateMethodTest_ChainingAssersion()
		{
			Range range = new Range(1, 10);
			int actual = range.AsDynamic().method();
			Assert.AreEqual(1, actual);
		}

		[TestMethod]
		public void PrivateMethodTest_PrivateObject()
		{
			var range = new PrivateObject(new Range(1, 10));
			int actual = (int)range.Invoke("method");
			Assert.AreEqual(1, actual);
		}
	}
}
