using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
	class CampaignManager : ICampaignService
	{
		public void Add(Campaign campaign,Gamer gamer,Sales sales)
		{
			Console.WriteLine(gamer.FirstName + " adlı kullanıcı " + sales.GameName + " oyununu % " + 
				campaign.CampaignPercent + " indirim miktarı ile " +  campaign.CampaignName + " kampanyasından faydalanarak satın almıştır ");
		}

		public void Delete(Campaign campaign, Gamer gamer, Sales sales)
		{
			Console.WriteLine(campaign.CampaignName + " kampanyası silindi ");
		}

		public void Update(Campaign campaign, Gamer gamer, Sales sales)
		{
			Console.WriteLine(campaign.CampaignName + " kampanyası yenilendi ");
		}
	}
}
