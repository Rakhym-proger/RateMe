using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AskMe.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderId { get; set; }
        public string SenderChatId { get; set; }
        public string Text { get; set; }
        public Boolean IsRead { get; set; }
        public DateTime WrittenTime { get; set; }

        public virtual User Sender { get; set; }
        public virtual Chat SenderChat { get; set; }

        public Message()
        {

        }
    }
}