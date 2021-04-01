using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
