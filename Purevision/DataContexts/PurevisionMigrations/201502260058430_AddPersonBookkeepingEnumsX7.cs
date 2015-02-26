namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonBookkeepingEnumsX7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "BusinessType", c => c.Int(nullable: false));
            AddColumn("dbo.People", "SpecialistRequired", c => c.Int());
            AddColumn("dbo.People", "ProcessingFrequency", c => c.Int(nullable: false));
            AddColumn("dbo.People", "ReturnCorrespondance", c => c.Int(nullable: false));
            AddColumn("dbo.People", "ChklistCorrespondance", c => c.Int(nullable: false));
            AddColumn("dbo.People", "ReportCorrespondance", c => c.Int(nullable: false));
            AddColumn("dbo.People", "InvoiceCorrespondance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "InvoiceCorrespondance");
            DropColumn("dbo.People", "ReportCorrespondance");
            DropColumn("dbo.People", "ChklistCorrespondance");
            DropColumn("dbo.People", "ReturnCorrespondance");
            DropColumn("dbo.People", "ProcessingFrequency");
            DropColumn("dbo.People", "SpecialistRequired");
            DropColumn("dbo.People", "BusinessType");
        }
    }
}
