namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAddedToBuyGage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuyGames", "DataAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BuyGames", "DataAdded");
        }
    }
}
