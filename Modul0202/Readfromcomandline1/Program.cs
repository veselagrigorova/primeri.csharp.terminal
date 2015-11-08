using System;

namespace Readfromcomandline1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//дефиниране на променливи
			int a = 5, b = 0;

			//въвеждане на входни параметри
			Console.Write ("Моля въведете а: ");

			b = Convert.ToInt32 (Console.ReadLine ());

			//печат на резултат

			Console.WriteLine ("Резултатът а + b e  " + (a + b ).ToString() + "\n");
			string test = "1";
			test += ", 2";
			test += ", 101";
			test += ", 4";
			test += ", 5";

			Console.WriteLine ("Събиране с += :" + test + "\n");
			test = test.Replace (", ", ";" );

			Console.WriteLine ("Работа с Replace: " + test + "\n");

			Console.WriteLine ("Трети знак: " + test.Split(';')[2]);
		}
	}
}
