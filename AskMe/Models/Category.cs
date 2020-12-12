using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AskMe.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int CurrentUserId { get; set; }
        public int FriendId { get; set; }
        public int Smile { get; set; }
        public int Anger { get; set; }
        public int Beauty { get; set; }
        public int Nature { get; set; }
        public int Humor { get; set; }

        public virtual User CurrentUser { get; set; }
        
        public virtual User FriendUser { get; set; }


        public Category()
        {

        }
    }
}