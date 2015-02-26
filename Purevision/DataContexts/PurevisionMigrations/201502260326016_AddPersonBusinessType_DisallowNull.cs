namespace Purevision.Web.DataContexts.PurevisionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonBusinessType_DisallowNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "BusinessType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "BusinessType", c => c.Int());
        }
    }
}
