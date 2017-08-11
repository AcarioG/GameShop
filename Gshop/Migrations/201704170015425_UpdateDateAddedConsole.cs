namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateAddedConsole : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Consoles", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Consoles", "DateAdded", c => c.DateTime(nullable: false));
        }
    }
}
