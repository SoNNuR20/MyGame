using System;

namespace MyGame
{
	class Program
	{
		static void Main(string[] args)
		{
			GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());
			SalesManager salesManager = new SalesManager();
			CampaignManager campaignManager = new CampaignManager();

			Gamer gamer=new Gamer()
			{
				Id = 1,
				BirthYear = 1995,
				FirstName = "Sonnur",
				LastName = "TAYFUROĞLU",
				IdentityNumber = 123456
			};

			Gamer gamer2 = new Gamer()
			{
				Id = 2,
				BirthYear =1991,
			    FirstName = "Merve",
				LastName = "Çakmak",
				IdentityNumber = 987456
			};

			Sales sales1 = new Sales();
			sales1.SalesId = 1;
			sales1.GameName = "PUBG";
			sales1.Price = 149.90;

			Sales sales2 = new Sales();
			sales2.SalesId = 2;
			sales2.GameName = "GOT:Conquest";
			sales2.Price =399.99;

			Campaign campaign1 = new Campaign();
			campaign1.CampaignName = "Yeni yıl kampanyası ";
			campaign1.CampaignPercent= 50;

			gamerManager.Delete(gamer);
			gamerManager.Update(gamer);

			Console.WriteLine("                                         ");
			salesManager.Sales(sales2, gamer);
			salesManager.Sales(sales1, gamer2);

			Console.WriteLine("                                          ");
			campaignManager.Add(campaign1,gamer, sales2);
			Console.WriteLine("                                           ");
			campaignManager.Add(campaign1, gamer2, sales1);

			Console.WriteLine("                                            ");
			campaignManager.Delete(campaign1,gamer2,sales1);

			campaignManager.Update(campaign1, gamer2, sales2);

		}
	}
}
