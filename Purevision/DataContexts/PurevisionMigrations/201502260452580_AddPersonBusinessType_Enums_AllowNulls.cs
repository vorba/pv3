namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonBusinessType_Enums_AllowNulls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "SpecialistRequired", c => c.Int());
            AlterColumn("dbo.People", "ProcessingFrequency", c => c.Int());
            AlterColumn("dbo.People", "ReturnCorrespondance", c => c.Int());
            AlterColumn("dbo.People", "ChklistCorrespondance", c => c.Int());
            AlterColumn("dbo.People", "ReportCorrespondance", c => c.Int());
            AlterColumn("dbo.People", "InvoiceCorrespondance", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "InvoiceCorrespondance", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "ReportCorrespondance", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "ChklistCorrespondance", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "ReturnCorrespondance", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "ProcessingFrequency", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "SpecialistRequired", c => c.Int(nullable: false));
        }
    }
}
