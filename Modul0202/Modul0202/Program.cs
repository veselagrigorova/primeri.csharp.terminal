using System;

namespace Modul0202
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello Aula");

	

			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 -Примери";
			string program_version = " 1.0";


			//Събиране на числа

			a = 6;
			b = 10;
			sum = a + b;

			//За програмата
			Console.WriteLine ( program_name );
			Console.WriteLine (program_version);
			Console.Write ("Версия: " + program_version + "„\n\n\n");


			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Допълнителни оператори
			Console.WriteLine ("\nИзползване на +=");
			a += b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine ( a );

			Console.WriteLine ("\nИзползване на ++");
			a++;
			Console.WriteLine ( a );

		
			Console.WriteLine ( "\nСтандартно делене:  ");
			Console.WriteLine (a / b);
			Console.WriteLine ("\nХващане на остатък: ");
			Console.WriteLine (a % b);



		}
	}
}
