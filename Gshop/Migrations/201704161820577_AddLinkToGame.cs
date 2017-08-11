namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLinkToGame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Link");
        }
    }
}
