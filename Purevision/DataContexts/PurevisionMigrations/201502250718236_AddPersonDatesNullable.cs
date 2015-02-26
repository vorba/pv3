namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonDatesNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "ProcessingRequiredFrom", c => c.DateTime());
            AlterColumn("dbo.People", "AgreementSignedOn", c => c.DateTime());
            AlterColumn("dbo.People", "BusinessConsentFormSignedOn", c => c.DateTime());
            AlterColumn("dbo.People", "RecordOfEmploymentFormSignedOn", c => c.DateTime());
            AlterColumn("dbo.People", "TelpayFormSignedOn", c => c.DateTime());
            AlterColumn("dbo.People", "WorkToStartOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "WorkToStartOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "TelpayFormSignedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "RecordOfEmploymentFormSignedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "BusinessConsentFormSignedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "AgreementSignedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "ProcessingRequiredFrom", c => c.DateTime(nullable: false));
        }
    }
}
