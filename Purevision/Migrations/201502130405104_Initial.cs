namespace Purevision.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AspNetRoles",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Name = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.AspNetUserClaims",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            ClaimType = c.String(),
            //            ClaimValue = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.AspNetUserLogins",
            //    c => new
            //        {
            //            LoginProvider = c.String(nullable: false, maxLength: 128),
            //            ProviderKey = c.String(nullable: false, maxLength: 128),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.Businesses",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            PrincipleOwnerUserId = c.Int(nullable: false),
            //            Name = c.String(),
            //            Number = c.String(maxLength: 10, fixedLength: true),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.BusinessProfiles",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            BusinessId = c.Int(nullable: false),
            //            PropertyId = c.Int(nullable: false),
            //            PropertyValue = c.String(maxLength: 3750),
            //            PropertyText = c.String(),
            //            Visibility = c.Int(nullable: false),
            //            CreatedOnDate = c.DateTime(nullable: false),
            //            CreatedByUserId = c.Int(nullable: false),
            //            UpdatedOnDate = c.DateTime(nullable: false),
            //            UpdatedByUserId = c.Int(nullable: false),
            //            ArchivedOnDate = c.DateTime(nullable: false),
            //            ArchivedByUserId = c.Int(nullable: false),
            //            ExtendedVisibility = c.String(maxLength: 400, unicode: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Businesses", t => t.BusinessId, cascadeDelete: true)
            //    .ForeignKey("dbo.ProfileProperties", t => t.PropertyId, cascadeDelete: true)
            //    .Index(t => t.BusinessId)
            //    .Index(t => t.PropertyId);
            
            //CreateTable(
            //    "dbo.ProfileProperties",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            DataType = c.Int(nullable: false),
            //            Default = c.String(storeType: "ntext"),
            //            Category = c.String(nullable: false, maxLength: 50),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Length = c.Int(nullable: false),
            //            Required = c.Boolean(nullable: false),
            //            Validation = c.String(maxLength: 2000),
            //            Order = c.Int(nullable: false),
            //            Visible = c.Boolean(nullable: false),
            //            CreatedOnDate = c.DateTime(),
            //            CreatedByUserID = c.Int(),
            //            UpdatedOnDate = c.DateTime(),
            //            UpdatedByUserID = c.Int(),
            //            ArchivedOnDate = c.DateTime(),
            //            ArchivedByUserID = c.Int(),
            //            DefaultVisibility = c.Int(),
            //            ReadOnly = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.ClientProfiles",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            ClientId = c.Int(nullable: false),
            //            PropertyId = c.Int(nullable: false),
            //            PropertyValue = c.String(maxLength: 3750),
            //            PropertyText = c.String(),
            //            Visibility = c.Int(nullable: false),
            //            CreatedOnDate = c.DateTime(nullable: false),
            //            CreatedByUserId = c.Int(nullable: false),
            //            UpdatedOnDate = c.DateTime(nullable: false),
            //            UpdatedByUserId = c.Int(nullable: false),
            //            ArchivedOnDate = c.DateTime(nullable: false),
            //            ArchivedByUserId = c.Int(nullable: false),
            //            ExtendedVisibility = c.String(maxLength: 400, unicode: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
            //    .ForeignKey("dbo.ProfileProperties", t => t.PropertyId, cascadeDelete: true)
            //    .Index(t => t.ClientId)
            //    .Index(t => t.PropertyId);
            
            //CreateTable(
            //    "dbo.Clients",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(maxLength: 10, fixedLength: true),
            //            UserId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.UserProfiles",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.Int(nullable: false),
            //            PropertyId = c.Int(nullable: false),
            //            PropertyValue = c.String(maxLength: 3750),
            //            PropertyText = c.String(),
            //            Visibility = c.Int(nullable: false),
            //            CreatedOnDate = c.DateTime(nullable: false),
            //            CreatedByUserId = c.Int(nullable: false),
            //            UpdatedOnDate = c.DateTime(nullable: false),
            //            UpdatedByUserId = c.Int(nullable: false),
            //            ArchivedOnDate = c.DateTime(nullable: false),
            //            ArchivedByUserId = c.Int(nullable: false),
            //            ExtendedVisibility = c.String(maxLength: 400, unicode: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
            //    .ForeignKey("dbo.ProfileProperties", t => t.PropertyId, cascadeDelete: true)
            //    .Index(t => t.UserId)
            //    .Index(t => t.PropertyId);
            
            //CreateTable(
            //    "dbo.Users",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            AspNetUserId = c.String(nullable: false, maxLength: 128),
            //            FirstName = c.String(maxLength: 50),
            //            LastName = c.String(maxLength: 50),
            //            DisplayName = c.String(nullable: false, maxLength: 256),
            //            Email = c.String(nullable: false, maxLength: 256),
            //            CreatedByUserId = c.Int(nullable: false),
            //            CreatedOnDate = c.DateTime(nullable: false),
            //            LastModifiedByUserId = c.Int(),
            //            LastModifiedOnDate = c.DateTime(),
            //            IsAdmin = c.Boolean(nullable: false),
            //            IsDeleted = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Companies",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false),
            //            ParentId = c.Int(),
            //            ClientId = c.Int(),
            //            BusinessId = c.Int(),
            //            SortOrder = c.Int(),
            //            Level = c.Int(),
            //            CreatedOnDate = c.DateTime(),
            //            CreatedByUserId = c.Int(),
            //            UpdatedOnDate = c.DateTime(),
            //            UpdatedByUserId = c.Int(),
            //            ArchivedOnDate = c.DateTime(),
            //            ArchivedByUserId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Lists",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Value = c.String(nullable: false, maxLength: 100),
            //            Text = c.String(nullable: false, maxLength: 150),
            //            ParentId = c.Int(nullable: false),
            //            Level = c.Int(nullable: false),
            //            SortOrder = c.Int(nullable: false),
            //            DefinitionId = c.Int(nullable: false),
            //            Description = c.String(maxLength: 500),
            //            IsSystem = c.Boolean(nullable: false),
            //            CreatedOnDate = c.DateTime(),
            //            CreatedByUserId = c.Int(),
            //            UpdatedOnDate = c.DateTime(),
            //            UpdatedByUserId = c.Int(),
            //            ArchivedOnDate = c.DateTime(),
            //            ArchivedByUserId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.MeetingAttendees",
            //    c => new
            //        {
            //            MeetingID = c.Int(nullable: false),
            //            AttendeeID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.MeetingID, t.AttendeeID })
            //    .ForeignKey("dbo.Meetings", t => t.MeetingID)
            //    .Index(t => t.MeetingID);
            
            //CreateTable(
            //    "dbo.Meetings",
            //    c => new
            //        {
            //            MeetingID = c.Int(nullable: false, identity: true),
            //            Start = c.DateTime(nullable: false),
            //            End = c.DateTime(nullable: false),
            //            Title = c.String(nullable: false, storeType: "ntext"),
            //            Description = c.String(storeType: "ntext"),
            //            RoomID = c.Int(),
            //            IsAllDay = c.Boolean(nullable: false),
            //            RecurrenceRule = c.String(storeType: "ntext"),
            //            RecurrenceID = c.Int(),
            //            RecurrenceException = c.String(storeType: "ntext"),
            //            StartTimezone = c.String(storeType: "ntext"),
            //            EndTimezone = c.String(storeType: "ntext"),
            //        })
            //    .PrimaryKey(t => t.MeetingID)
            //    .ForeignKey("dbo.Meetings", t => t.RecurrenceID)
            //    .Index(t => t.RecurrenceID);

            DropTable("dbo.People");

            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 10, fixedLength: true),
                        LastName = c.String(maxLength: 10, fixedLength: true),
                        //Name = c.String(maxLength: 10),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Tasks",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.AspNetUserRoles",
            //    c => new
            //        {
            //            RoleId = c.String(nullable: false, maxLength: 128),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.RoleId, t.UserId })
            //    .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.RoleId)
            //    .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Meetings", "RecurrenceID", "dbo.Meetings");
            //DropForeignKey("dbo.MeetingAttendees", "MeetingID", "dbo.Meetings");
            //DropForeignKey("dbo.UserProfiles", "PropertyId", "dbo.ProfileProperties");
            //DropForeignKey("dbo.UserProfiles", "UserId", "dbo.Users");
            //DropForeignKey("dbo.ClientProfiles", "PropertyId", "dbo.ProfileProperties");
            //DropForeignKey("dbo.ClientProfiles", "ClientId", "dbo.Clients");
            //DropForeignKey("dbo.BusinessProfiles", "PropertyId", "dbo.ProfileProperties");
            //DropForeignKey("dbo.BusinessProfiles", "BusinessId", "dbo.Businesses");
            //DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            //DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            //DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            //DropIndex("dbo.Meetings", new[] { "RecurrenceID" });
            //DropIndex("dbo.MeetingAttendees", new[] { "MeetingID" });
            //DropIndex("dbo.UserProfiles", new[] { "PropertyId" });
            //DropIndex("dbo.UserProfiles", new[] { "UserId" });
            //DropIndex("dbo.ClientProfiles", new[] { "PropertyId" });
            //DropIndex("dbo.ClientProfiles", new[] { "ClientId" });
            //DropIndex("dbo.BusinessProfiles", new[] { "PropertyId" });
            //DropIndex("dbo.BusinessProfiles", new[] { "BusinessId" });
            //DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            //DropTable("dbo.AspNetUserRoles");
            //DropTable("dbo.Tasks");
            //DropTable("dbo.People");
            //DropTable("dbo.Meetings");
            //DropTable("dbo.MeetingAttendees");
            //DropTable("dbo.Lists");
            //DropTable("dbo.Companies");
            //DropTable("dbo.Users");
            //DropTable("dbo.UserProfiles");
            //DropTable("dbo.Clients");
            //DropTable("dbo.ClientProfiles");
            //DropTable("dbo.ProfileProperties");
            //DropTable("dbo.BusinessProfiles");
            //DropTable("dbo.Businesses");
            //DropTable("dbo.AspNetUserLogins");
            //DropTable("dbo.AspNetUserClaims");
            //DropTable("dbo.AspNetUsers");
            //DropTable("dbo.AspNetRoles");
        }
    }
}
