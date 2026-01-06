using Chattapp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattapp.Controllers
{
    internal class UserController
    {
        public List<UserClass> GetListOfUsers()
        {
            return new List<UserClass>();
        }
        public UserClass GetUser(int id)
        {
            return new UserClass();
        }
        public bool CreateUser(UserClass user)
        {
            return true;
        }
        public bool UpdateUser(UserClass user)
        {
            return true;
        }
        public bool DeleteUser(int id)
        {
            return true;
        }
    }
}
