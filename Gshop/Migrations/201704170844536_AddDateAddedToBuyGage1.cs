namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAddedToBuyGage1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyGames", "DateAdded", c => c.DateTime());
            DropColumn("dbo.BuyGames", "DataAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BuyGames", "DataAdded", c => c.DateTime());
            DropColumn("dbo.BuyGames", "DateAdded");
        }
    }
}
