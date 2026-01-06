using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattapp.Classes
{
    internal class UserFriendsClass
    {
        private string connectionId;
        private UserClass userOne;
        private UserClass userTwo;
        private DateTime friendsSince;

        public UserFriendsClass(string connectionId, UserClass userOne, UserClass userTwo, DateTime friendsSince)
        {
            this.connectionId = connectionId;
            this.userOne = userOne; 
            this.userTwo = userTwo; 
            this.friendsSince = friendsSince;
        }
        public UserFriendsClass() { }
    }
}
