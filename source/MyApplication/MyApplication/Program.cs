using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			string title = "this is my converted string";
			Console.WriteLine("String Class");
			Console.WriteLine("------------");

			//Convert string to uppercase.
			Console.WriteLine(title.ToUpper());
			//Convert string to lowercase.
			Console.WriteLine(title.ToLower());

			Console.WriteLine();
			Console.WriteLine("TextInfo Class");
			Console.WriteLine("--------------");

			//Get the culture property of the thread.
			CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
			//Create TextInfo object.
			TextInfo textInfo = cultureInfo.TextInfo;

			//Convert to uppercase.
			Console.WriteLine(textInfo.ToUpper(title));
			//Convert to lowercase.
			Console.WriteLine(textInfo.ToLower(title));
			//Convert to title case.
			Console.WriteLine(textInfo.ToTitleCase(title));
			Console.WriteLine(textInfo.ToTitleCase("atsushi"));

			Console.ReadKey();
		}
	}
}
