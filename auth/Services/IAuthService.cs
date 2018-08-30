using System;
using System.Collections.Generic;
using System.Text;

namespace auth.Services
{
    interface IAuthService
    {

        string Login(string email, string password);

        Boolean AddUserCreadentials(string email, string password);

        Boolean VerifyUserToken(string token);
    }
}
