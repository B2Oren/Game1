using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Büşra"&& gamer.LastName=="ÖREN"&& gamer.BirthYear==1993&& gamer.Id==1 && gamer.IdentityNumber==112233)
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
