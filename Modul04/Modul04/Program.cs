using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = { 
				{ "Таня",   "Чавдарова", "19" },
				{ "Дани",    "Христов",  "24" },
				{ "Криста",  "Тодорова",    "17" },
				{ "Иван",    "Петров",      "30" },
				{ "Ваня",    "Георгиева",    "50" },
				{ "Стоян",    "Стоянов",     "29" }
			};

			//Антетка на таблица
			Console.WriteLine ("Име".PadRight (12) + "Фамилия".PadRight (12) + "Години".PadRight (12));
		
			Console.WriteLine ("--------------------------------------------");


			//тяло на таблица
//
//			for (int i = 0; i < _table.Length/3; i++)
//			{
//				for(int j =0; j<3; j++)
//				{
//					Console.Write ( _table [i, j].PadRight(12));
//		
//			}
//				Console.WriteLine();
//		}
			// пример с while
			int i = 0;

			while (i < _table.Length / 3) {
				Console.WriteLine (
					_table [i, 0].PadRight (12) +
					_table [i, 1].PadRight (12) +
					_table [i, 2].PadRight (12)
				);

				i++;
			
			}
		}
	}
}

				


	







