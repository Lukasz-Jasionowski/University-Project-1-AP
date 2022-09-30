using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP1
{
    internal class Users
    {
        private string userName;
        private string userEmail;
        private string userPassword;
        public Users()
        {
        }

        public Users(string userName, string userEmail, string userPassword)
        {
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
        }

        public string UserName { get => userName; set => userName = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
    }
}