namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonBookkeepingType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "BookkeepingType", c => c.Int());
            AlterColumn("dbo.People", "BusinessName", c => c.String(maxLength: 35));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "BusinessName", c => c.String());
            DropColumn("dbo.People", "BookkeepingType");
        }
    }
}
