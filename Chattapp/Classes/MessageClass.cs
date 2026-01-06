using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattapp.Classes
{
    internal class MessageClass
    {
        private string messageId;
        private UserFriendsClass friendConnection;
        private UserClass sender;
        private string messageContent;
        private DateTime messageDate;
        private bool messageRead;

        public MessageClass(string messageId, UserFriendsClass friendConnection, UserClass sender, string messageContent, DateTime messageDate, bool messageRead)
        {
            this.messageId = messageId;
            this.friendConnection = friendConnection;
            this.sender = sender;
            this.messageContent = messageContent;
            this.messageDate = messageDate;
            this.messageRead = messageRead;
        }
        public MessageClass(UserFriendsClass friendConnection, UserClass Sender, string messageContent, DateTime messageDate)
        {
            this.friendConnection = friendConnection;
            this.sender = Sender;
            this.messageContent = messageContent;
            this.messageDate = messageDate;
            this.messageRead = false;
        }
        public MessageClass() { }
    }
}
