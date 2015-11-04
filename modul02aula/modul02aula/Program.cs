using System;

namespace modul02aula
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на променливи
			int a = 0, b = 0; int sum = 0;

			//Събиране на числа
			a = 2;
			b = 10; sum = a + b;
				

			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write ( b );
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори

			Console.WriteLine ("\nИзползване на +=");
			a +=b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на -=");
			a -= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на *=");
			a *= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на ++");
			a++;

			Console.WriteLine ("Стандартно делене" +( 8/3 ).ToString());
			Console.WriteLine ("Остатък от  делене" +( 8%3 ).ToString());







		}
	}
}
