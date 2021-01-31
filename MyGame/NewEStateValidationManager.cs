using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
	class NewEStateValidationManager : IUserValidationService
	{
		public bool Validation(Gamer gamer)
		{
			return true;
		}
	}
}
