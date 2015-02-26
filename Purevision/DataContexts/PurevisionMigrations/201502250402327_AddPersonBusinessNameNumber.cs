namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonBusinessNameNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "BusinessName", c => c.String());
            AddColumn("dbo.People", "BusinessNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "BusinessNumber");
            DropColumn("dbo.People", "BusinessName");
        }
    }
}
