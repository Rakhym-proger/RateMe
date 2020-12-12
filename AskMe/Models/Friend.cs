using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AskMe.Models
{
    public class Friend
    {
        [Key]
        [Column(Order=1)]
        public int CurrentUserId { get; set; }
        [Key]
        [Column(Order=2)]
        public int FriendUserId { get; set; }


        //public virtual User CurrentUser { get; set; }
        //public virtual User FriendUser { get; set; }


        public Friend()
        {

        }
    }
}