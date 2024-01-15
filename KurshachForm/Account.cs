using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurshachForm
{
    public class Account
    {
        bool admin;
        string login;
        string password;

        public Account(string login, string password, bool admin)
        {
            this.login = login;
            this.password = password;
            this.admin = admin;
        }

        public string GetLogin()
        {
            return login;
        }

        public string GetPassword()
        {
            return password;
        }

        public bool AdminStatus() 
        {
            return admin;
        }
    }
}
