using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AskMe.Models
{
    public class RequestToFriend
    {
        public int Id { get; set; }
        public int CurrentUserId { get; set; }
        public int FriendUserId { get; set; }
        public string Message { get; set; }



        public RequestToFriend()
        {

        }
    }
}