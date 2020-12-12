using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AskMe.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string FirstUser { get; set; }
        public string SecondUser { get; set; }

        public virtual User First { get; set; }
        public virtual User Second { get; set; }


        public Chat()
        {

        }
    }
}