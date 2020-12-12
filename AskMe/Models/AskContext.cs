using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AskMe.Models
{
    public class AskContext : DbContext
    {
        public AskContext() : base("AskContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<RequestToFriend> RequestsToFriend { get; set; }
    }


    //public class AskingDbInitializer : DropCreateDatabaseAlways<AskContext>
    //{
    //    protected override void Seed(AskContext db)
    //    {
    //        db.Users.Add(new User { Login = "Dias@mail.ru", Password = "qweqweqwe", Name = "Dias", Surname = "Kaukenbaev", BirthDate = new DateTime(1888,05,25)});
    //        db.Users.Add(new User { Login = "Rakhym@mail.ru", Password = "qweqweqwe", Name = "Rakhym", Surname = "Kurmangali", BirthDate = new DateTime(2001, 07, 02)});
    //        db.Users.Add(new User { Login = "Joma@mail.ru", Password = "qweqweqwe", Name = "Joma", Surname = "Kurmangali", BirthDate = new DateTime(1997, 05, 10) });
    //        db.Users.Add(new User { Login = "Ktoto@mail.ru", Password = "qweqweqwe", Name = "Birbale", Surname = "Birbaleev", BirthDate = new DateTime(2002, 09, 25)});

    //    }
    //}
}