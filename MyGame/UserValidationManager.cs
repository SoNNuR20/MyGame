using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
	class UserValidationManager : IUserValidationService
	{
		public bool Validation(Gamer gamer)
		{
			if (gamer.BirthYear==1995 && gamer.FirstName=="Sonnur" && gamer.LastName=="Tayfuroğlu" && gamer.IdentityNumber==123456)
			{
				
				return true;
			}
			else
			{
				
				return false;
			}
		}
	}
}
