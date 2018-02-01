namespace LFA.EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check_setup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        ContactNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invitations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        ContactId = c.Int(nullable: false),
                        InviteDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invitations", "EventId", "dbo.Events");
            DropForeignKey("dbo.Invitations", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Invitations", new[] { "ContactId" });
            DropIndex("dbo.Invitations", new[] { "EventId" });
            DropTable("dbo.Invitations");
            DropTable("dbo.Events");
            DropTable("dbo.Contacts");
        }
    }
}
