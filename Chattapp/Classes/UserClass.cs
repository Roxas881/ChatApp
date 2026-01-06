using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattapp.Classes
{
    internal class UserClass
    {
        private string userId;
        private string userName;
        private string password;
        private bool isAdmin;
        private string userEmail;
        private string firstNameUser;
        private string lastNameUser;


        public UserClass(string userId, string userName, string password, string userEmail, string firstNameUser, string lastNameUser, bool isAdmin)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.userEmail = userEmail;
            this.firstNameUser = firstNameUser;
            this.lastNameUser = lastNameUser;
            this.isAdmin = isAdmin;
        }
        public UserClass(string userName, string password, string userEmail, string firstNameUser, string lastNameUser)
        {
            this.userName = userName;
            this.password = password;
            this.userEmail = userEmail;
            this.firstNameUser = firstNameUser;
            this.lastNameUser = lastNameUser;
            this.isAdmin = false;
        }
        public UserClass() { }
    }
}
