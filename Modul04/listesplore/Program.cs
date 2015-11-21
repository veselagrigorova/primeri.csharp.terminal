using System;

namespace listesplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//дефиниции

			string _userinput = "";

			//потребителски вход
			 do{
				Console.Write ("? ");

				_userinput = Console.ReadLine();

			} while (_userinput !="exit");
		}

	}
}

