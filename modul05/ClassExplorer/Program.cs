using System;

namespace ClassExplorer
{
	public class person
	{
		private string simpleString = "Тестова променлива от клас";
		private string user = "";

		private string hiddenString = "";
	
		public person (string _ini)
		{
			getUser ( _ini);
			setWelcomeText ();

		}
		private void getUser (string _ini)

		{
			
			if (_ini == "Password1") hiddenString = "Потребител 1";
			if (_ini == "Password2") hiddenString = "Потребител 2";
			user = hiddenString;

		}
		private void setWelcomeText ()
		{
			if (hiddenString.Length > 0)

				simpleString = "Добре дошли отново, " +user+ "!";
			else
				simpleString = "Вие нямате достъп до тази програма.";


		}

		public string GetWelcomeMessage ()
		{

			return simpleString;
		}
	class MainClassx
	{
		public static void Main (string[] args)
			{
				Console.Write ("Парола: ");
				string _user = Console.ReadLine ();

				//Дефиниране на клас
				person _person = new person (_user);

				//Достъпване на клас

				Console.WriteLine (_person.GetWelcomeMessage());
			}
		}
	}
}
