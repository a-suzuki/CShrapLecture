using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;

namespace MyClassTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var target = new Class1(0);
		}
	}
}
