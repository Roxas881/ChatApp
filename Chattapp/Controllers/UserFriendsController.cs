using Chattapp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattapp.Controllers
{
    internal class UserFriendsController
    {
        public List<UserFriendsClass> GetFriends()
        {
            return new List<UserFriendsClass>();
        }
        public UserFriendsClass GetFriend(int id)
        {
            return new UserFriendsClass();
        }
        public bool CreateUserFriend(UserFriendsClass friendConnection)
        {
            return false;
        }
        public bool UpdateUserFriend(UserFriendsClass friendConnection)
        {
            return false; 
        }
        public bool DeleteUserFriend(UserFriendsClass friendConnection)
        {
            return false;
        }
    }
}
