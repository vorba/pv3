namespace Purevision.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientAddEmailComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Email", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.People", "Comments", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 10, fixedLength: true));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 10, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String(maxLength: 10, fixedLength: true));
            AlterColumn("dbo.People", "FirstName", c => c.String(maxLength: 10, fixedLength: true));
            DropColumn("dbo.People", "Comments");
            DropColumn("dbo.People", "Email");
        }
    }
}
