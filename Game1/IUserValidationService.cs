using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
