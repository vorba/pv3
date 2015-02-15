namespace Purevision.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePersonEmailAndPhoneLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Phone", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Phone", c => c.String());
        }
    }
}
