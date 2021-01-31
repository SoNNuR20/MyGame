using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
	 interface ICampaignService
	{
		void Add(Campaign campaign, Gamer gamer, Sales sales);
		void Delete(Campaign campaign, Gamer gamer, Sales sales);
		void Update(Campaign campaign, Gamer gamer, Sales sales);
	}
}
