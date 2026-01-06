using Chattapp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattapp.Controllers
{
    internal class MessageController
    {
        public List<MessageClass> GetMessages(string connectionId)
        {
            return new List<MessageClass>();
        }
        public MessageClass GetMessage(string connectionId)
        {
            return new MessageClass();
        }
        public bool CreateMessage(MessageClass message)
        {
            return false;
        }
        public bool DeleteMessage(MessageClass message)
        {
            return false;
        }
        public bool UpdateMessage(MessageClass message)
        {
            return false;
        }
    }
}
