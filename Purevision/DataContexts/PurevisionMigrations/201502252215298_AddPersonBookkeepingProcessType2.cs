namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonBookkeepingProcessType2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "BookkeepingProcessType", c => c.Int());
            DropColumn("dbo.People", "BookkeepingType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "BookkeepingType", c => c.Int());
            DropColumn("dbo.People", "BookkeepingProcessType");
        }
    }
}
