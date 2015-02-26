namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonProperties10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "ProvincialSalesTaxNumber", c => c.String());
            AddColumn("dbo.People", "ReferredBy", c => c.String());
            AddColumn("dbo.People", "SpecialistAssigned", c => c.String());
            AddColumn("dbo.People", "MaintenanceBookkeeperAssigned", c => c.String());
            AddColumn("dbo.People", "ProcessingRequiredFrom", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "AgreementSignedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "BusinessConsentFormSignedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "RecordOfEmploymentFormSignedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "TelpayFormSignedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "WorkToStartOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "WorkToStartOn");
            DropColumn("dbo.People", "TelpayFormSignedOn");
            DropColumn("dbo.People", "RecordOfEmploymentFormSignedOn");
            DropColumn("dbo.People", "BusinessConsentFormSignedOn");
            DropColumn("dbo.People", "AgreementSignedOn");
            DropColumn("dbo.People", "ProcessingRequiredFrom");
            DropColumn("dbo.People", "MaintenanceBookkeeperAssigned");
            DropColumn("dbo.People", "SpecialistAssigned");
            DropColumn("dbo.People", "ReferredBy");
            DropColumn("dbo.People", "ProvincialSalesTaxNumber");
        }
    }
}
