namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MeetingAttendees",
                c => new
                    {
                        MeetingID = c.Int(nullable: false),
                        AttendeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MeetingID, t.AttendeeID })
                .ForeignKey("dbo.Meetings", t => t.MeetingID, cascadeDelete: true)
                .Index(t => t.MeetingID);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        MeetingID = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Title = c.String(nullable: false, storeType: "ntext"),
                        Description = c.String(storeType: "ntext"),
                        RoomID = c.Int(),
                        IsAllDay = c.Boolean(nullable: false),
                        RecurrenceRule = c.String(storeType: "ntext"),
                        RecurrenceID = c.Int(),
                        RecurrenceException = c.String(storeType: "ntext"),
                        StartTimezone = c.String(storeType: "ntext"),
                        EndTimezone = c.String(storeType: "ntext"),
                        Meeting1_MeetingID = c.Int(),
                    })
                .PrimaryKey(t => t.MeetingID)
                .ForeignKey("dbo.Meetings", t => t.Meeting1_MeetingID)
                .Index(t => t.Meeting1_MeetingID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        LastName = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 14),
                        Comments = c.String(),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Email = c.String(nullable: false, maxLength: 256),
                        CreatedByUserId = c.Int(nullable: false),
                        CreatedOnDate = c.DateTime(nullable: false),
                        LastModifiedByUserId = c.Int(),
                        LastModifiedOnDate = c.DateTime(),
                        IsAdmin = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        PropertyValue = c.String(maxLength: 3750),
                        PropertyText = c.String(),
                        Visibility = c.Int(nullable: false),
                        CreatedOnDate = c.DateTime(nullable: false),
                        CreatedByUserId = c.Int(nullable: false),
                        UpdatedOnDate = c.DateTime(nullable: false),
                        UpdatedByUserId = c.Int(nullable: false),
                        ArchivedOnDate = c.DateTime(nullable: false),
                        ArchivedByUserId = c.Int(nullable: false),
                        ExtendedVisibility = c.String(maxLength: 400),
                        ProfileProperty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProfileProperties", t => t.ProfileProperty_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProfileProperty_Id);
            
            CreateTable(
                "dbo.ProfileProperties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataType = c.Int(nullable: false),
                        Default = c.String(storeType: "ntext"),
                        Category = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Length = c.Int(nullable: false),
                        Required = c.Boolean(nullable: false),
                        Validation = c.String(maxLength: 2000),
                        Order = c.Int(nullable: false),
                        Visible = c.Boolean(nullable: false),
                        CreatedOnDate = c.DateTime(),
                        CreatedByUserID = c.Int(),
                        UpdatedOnDate = c.DateTime(),
                        UpdatedByUserID = c.Int(),
                        ArchivedOnDate = c.DateTime(),
                        ArchivedByUserID = c.Int(),
                        DefaultVisibility = c.Int(),
                        ReadOnly = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BusinessProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusinessId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        PropertyValue = c.String(maxLength: 3750),
                        PropertyText = c.String(),
                        Visibility = c.Int(nullable: false),
                        CreatedOnDate = c.DateTime(nullable: false),
                        CreatedByUserId = c.Int(nullable: false),
                        UpdatedOnDate = c.DateTime(nullable: false),
                        UpdatedByUserId = c.Int(nullable: false),
                        ArchivedOnDate = c.DateTime(nullable: false),
                        ArchivedByUserId = c.Int(nullable: false),
                        ExtendedVisibility = c.String(maxLength: 400),
                        ProfileProperty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Businesses", t => t.BusinessId, cascadeDelete: true)
                .ForeignKey("dbo.ProfileProperties", t => t.ProfileProperty_Id)
                .Index(t => t.BusinessId)
                .Index(t => t.ProfileProperty_Id);
            
            CreateTable(
                "dbo.Businesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrincipleOwnerUserId = c.Int(nullable: false),
                        Name = c.String(),
                        Number = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        PropertyValue = c.String(maxLength: 3750),
                        PropertyText = c.String(),
                        Visibility = c.Int(nullable: false),
                        CreatedOnDate = c.DateTime(nullable: false),
                        CreatedByUserId = c.Int(nullable: false),
                        UpdatedOnDate = c.DateTime(nullable: false),
                        UpdatedByUserId = c.Int(nullable: false),
                        ArchivedOnDate = c.DateTime(nullable: false),
                        ArchivedByUserId = c.Int(nullable: false),
                        ExtendedVisibility = c.String(maxLength: 400),
                        ProfileProperty_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.ProfileProperties", t => t.ProfileProperty_Id)
                .Index(t => t.ClientId)
                .Index(t => t.ProfileProperty_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfiles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserProfiles", "ProfileProperty_Id", "dbo.ProfileProperties");
            DropForeignKey("dbo.ClientProfiles", "ProfileProperty_Id", "dbo.ProfileProperties");
            DropForeignKey("dbo.ClientProfiles", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.BusinessProfiles", "ProfileProperty_Id", "dbo.ProfileProperties");
            DropForeignKey("dbo.BusinessProfiles", "BusinessId", "dbo.Businesses");
            DropForeignKey("dbo.MeetingAttendees", "MeetingID", "dbo.Meetings");
            DropForeignKey("dbo.Meetings", "Meeting1_MeetingID", "dbo.Meetings");
            DropIndex("dbo.ClientProfiles", new[] { "ProfileProperty_Id" });
            DropIndex("dbo.ClientProfiles", new[] { "ClientId" });
            DropIndex("dbo.BusinessProfiles", new[] { "ProfileProperty_Id" });
            DropIndex("dbo.BusinessProfiles", new[] { "BusinessId" });
            DropIndex("dbo.UserProfiles", new[] { "ProfileProperty_Id" });
            DropIndex("dbo.UserProfiles", new[] { "UserId" });
            DropIndex("dbo.Meetings", new[] { "Meeting1_MeetingID" });
            DropIndex("dbo.MeetingAttendees", new[] { "MeetingID" });
            DropTable("dbo.Clients");
            DropTable("dbo.ClientProfiles");
            DropTable("dbo.Businesses");
            DropTable("dbo.BusinessProfiles");
            DropTable("dbo.ProfileProperties");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Users");
            DropTable("dbo.People");
            DropTable("dbo.Meetings");
            DropTable("dbo.MeetingAttendees");
        }
    }
}
