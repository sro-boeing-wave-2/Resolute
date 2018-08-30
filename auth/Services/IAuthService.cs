using System;

namespace auth.Services
{
    interface IAuthService
    {

        /**
         * Method for user login
         */
        string Login(string email, string password);

        /**
         * Method to save user credentials
         */
        Boolean AddUserCreadentials(string email, string password);

        /**
         * Method to verify user session token.
         */
        string VerifyUserToken(string token);
    }
}
