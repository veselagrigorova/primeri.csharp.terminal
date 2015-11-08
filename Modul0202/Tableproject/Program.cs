using System;

namespace Tableproject
{
	class MainClass

	{
		enum tableindex {ime = 0, familia, godini};
		public static void Main (string[] args)
		{
//			//дефиниране на таблица
			string [,]table=new string[2,3];
			//въвеждане на първи ред
			table [0,(int)tableindex.ime]="Весела";
			table [0,(int)tableindex.familia] = "Григорова";
			table[0,(int)tableindex.godini]= "50";
			//въвеждане на втори ред
			table [1,(int)tableindex.ime]="Таня";
			table [1,(int)tableindex.familia] = "Христова";
			table[1,(int)tableindex.godini]= "20";

			//ПЕЧАТ
			Console.Write("Кой ред искате да видите: " );
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;


			Console.WriteLine ((
				table [_index,(int)tableindex.ime])[0]+"."+
				table [_index,(int)tableindex.familia]+ ", " +
				table[_index,(int)tableindex.godini] + "г. "
			);

		



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