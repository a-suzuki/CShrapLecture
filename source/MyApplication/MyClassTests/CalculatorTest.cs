using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;

namespace MyClassTests
{
	[TestClass]
	public class CalculatorTest
	{
		[TestMethod]
		public void Add()
		{
			var target = new Calculator();
			Assert.AreEqual(3, target.Add(1, 2));
		}

		[TestMethod]
		public void Divide()
		{
			var target = new Calculator();
			Assert.AreEqual(2, target.Divide(4, 2));
		}

		[TestMethod]
		public void Divide_循環小数の場合()
		{
			var target = new Calculator();
			Assert.AreEqual(3.3, target.Divide(10, 3), 0.05);
		}

		[TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Divide_0除算の場合()
		{
			var target = new Calculator();
			try
			{
				target.Divide(2, 0);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Assert.AreEqual("right", e.ParamName);
				Assert.AreEqual("0除算です。\r\nパラメーター名: right", e.Message);
				throw;
			}
		}
	}
}
