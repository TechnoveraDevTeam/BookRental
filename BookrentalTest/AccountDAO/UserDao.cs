using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookrentalTest.AccountDAO
{
    public class UserDao
    {
        public bool login(string username,string password)
        {
            return username.Equals("sarakie", StringComparison.CurrentCultureIgnoreCase) &&
                password.Equals("12345", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}