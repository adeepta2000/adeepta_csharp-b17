using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        private const string usernameErrorMessage = "Username must be provided";
        private const string emailErrorMessage = "Email must be provided";
        private const string passwordErrorMessage = "Password must be provided";
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return usernameErrorMessage;
            if (string.IsNullOrWhiteSpace(email))
                return emailErrorMessage;
            if (string.IsNullOrWhiteSpace(password))
                return passwordErrorMessage;

            return string.Empty;
        }
    }
}
