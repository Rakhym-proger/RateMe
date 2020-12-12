namespace AskMe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentUserId = c.Int(nullable: false),
                        FriendId = c.Int(nullable: false),
                        Smile = c.Int(nullable: false),
                        Anger = c.Int(nullable: false),
                        Beauty = c.Int(nullable: false),
                        Nature = c.Int(nullable: false),
                        Humor = c.Int(nullable: false),
                        FriendUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CurrentUserId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.FriendUser_Id)
                .Index(t => t.CurrentUserId)
                .Index(t => t.FriendUser_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstUser = c.String(),
                        SecondUser = c.String(),
                        First_Id = c.Int(),
                        Second_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.First_Id)
                .ForeignKey("dbo.Users", t => t.Second_Id)
                .Index(t => t.First_Id)
                .Index(t => t.Second_Id);
            
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        CurrentUserId = c.Int(nullable: false),
                        FriendUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CurrentUserId, t.FriendUserId });
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenderId = c.String(),
                        SenderChatId = c.String(),
                        Text = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        WrittenTime = c.DateTime(nullable: false),
                        Sender_Id = c.Int(),
                        SenderChat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Sender_Id)
                .ForeignKey("dbo.Chats", t => t.SenderChat_Id)
                .Index(t => t.Sender_Id)
                .Index(t => t.SenderChat_Id);
            
            CreateTable(
                "dbo.RequestToFriends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentUserId = c.Int(nullable: false),
                        FriendUserId = c.Int(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "SenderChat_Id", "dbo.Chats");
            DropForeignKey("dbo.Messages", "Sender_Id", "dbo.Users");
            DropForeignKey("dbo.Chats", "Second_Id", "dbo.Users");
            DropForeignKey("dbo.Chats", "First_Id", "dbo.Users");
            DropForeignKey("dbo.Categories", "FriendUser_Id", "dbo.Users");
            DropForeignKey("dbo.Categories", "CurrentUserId", "dbo.Users");
            DropForeignKey("dbo.Users", "User_Id", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "SenderChat_Id" });
            DropIndex("dbo.Messages", new[] { "Sender_Id" });
            DropIndex("dbo.Chats", new[] { "Second_Id" });
            DropIndex("dbo.Chats", new[] { "First_Id" });
            DropIndex("dbo.Users", new[] { "User_Id" });
            DropIndex("dbo.Categories", new[] { "FriendUser_Id" });
            DropIndex("dbo.Categories", new[] { "CurrentUserId" });
            DropTable("dbo.RequestToFriends");
            DropTable("dbo.Messages");
            DropTable("dbo.Friends");
            DropTable("dbo.Chats");
            DropTable("dbo.Users");
            DropTable("dbo.Categories");
        }
    }
}
