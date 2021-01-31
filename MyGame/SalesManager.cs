using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
	class SalesManager:ISalesService
	{
		public void Sales(Sales sales,Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "--> " + sales.GameName + " " + " oyununu satin aldi. ");
			Console.WriteLine(" Başarılar" + " " + gamer.FirstName + " " );
		}
	}
}
