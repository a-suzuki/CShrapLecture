using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication;

namespace MyApplicationTests
{
	[TestClass]
	public class HelloTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var target = new Hello();
			Assert.AreEqual("Hello World!", target.Say());
		}
	}
}
