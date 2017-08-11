namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateAddedGame : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "DateAdded", c => c.DateTime(nullable: false));
        }
    }
}
