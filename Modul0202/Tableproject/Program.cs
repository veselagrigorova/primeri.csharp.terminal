using System;

namespace Tableproject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			//дефиниране на таблица
			string [,]table=new string[2,3];
			//въвеждане на първи ред
			table [0,0]="Весела";
			table [0,1] = "Григорова";
			table[0,2]= "50";
			//въвеждане на втори ред
			table [1,0]="Таня";
			table [1,1] = "Христова";
			table[1,2]= "20";

			//ПЕЧАТ
			Console.Write("Кой ред искате да видите: " );
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;


			Console.WriteLine ((table [_index,0])[0]+"."+table [_index,1]+ ", " + table[_index,2] + "г. ");

		



	}
  }
}

//string[] row = new string[3];
//			row [0] = "Ред 1";
//			row [1] = "Ред 2";
//			row [2] = "Ред 3";
//			Console.WriteLine ("Масив row: " + row [0] + ", " + row [1] + ", " + row [2] + ", " + "\n");
//
//			string[]parse="1,2,3,4,5,6,7,8,9".Split(',');
//			Console.WriteLine ("Броят на масива - цифрите в стринга: \n" + "1,2,3,4,5,6,7,8,9\n e: " + parse.Length);
//
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Новият стринг е: \n" + list1 + "\n\n\n");