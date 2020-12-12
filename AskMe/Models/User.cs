using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AskMe.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }


        public virtual ICollection<User> FriendUsers { get; set; }

        public User()
        {
            FriendUsers = new List<User>();
        }
    }
}