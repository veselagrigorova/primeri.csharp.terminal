using System;
using System.Collections.Generic;

namespace listtexplore
{
	class MainClass
	{
		public static void Main (string[] args)

		{
			// дефиниции
			string _userinput = "";
			List<int> _list = new List<int> ();

			_list.Add (9);
			_list.Add (5);
			_list.Add (6);
			_list.Add (3);

			//лист


			//потребителски вход
			do{
				Console.Write ("? ");
				_userinput=Console.ReadLine ();
				//добавяне на стойности

				//преглед на листа

				if ( _userinput.Contains ("show"))
					
				{
					Console.Write("_List: ");

					for (int i =0; i < _list.Count; i++ )
					{

						Console.Write( _list[i]);
						if(i != _list.Count -1) Console.Write (",");

					}

					Console.WriteLine();
				}

				//размер на листа

			}while(_userinput !="exit");

		}
	}
}
 



	


	



