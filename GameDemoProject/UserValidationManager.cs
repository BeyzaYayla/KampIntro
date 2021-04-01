using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FName=="BEYZA" && gamer.LName=="YAYLA" && gamer.IdentityNumber==1234567890 && gamer.BirthYear==1999)
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
