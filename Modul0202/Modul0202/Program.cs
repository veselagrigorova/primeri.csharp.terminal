﻿using System;

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


			//Събиране на числа

			a = 6;
			b = 10;
			sum = a + b;

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

			Console.WriteLine ("Стандартно делене: " + ( 7 / 3).ToString ());
			Console.WriteLine ("Стандартно делене: " + ( 7 % 3).ToString ());


		}
	}
}
