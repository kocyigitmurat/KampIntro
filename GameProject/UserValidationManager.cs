﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName=="MURAT" && gamer.LastName== "KOÇYİĞİT" && gamer.IdentityNumber == 12345 )
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
