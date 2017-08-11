namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuyGames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        GameId = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        Amount = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Games", t => t.GameId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BuyGames", "GameId", "dbo.Games");
            DropForeignKey("dbo.BuyGames", "CustomerId", "dbo.Customers");
            DropIndex("dbo.BuyGames", new[] { "GameId" });
            DropIndex("dbo.BuyGames", new[] { "CustomerId" });
            DropTable("dbo.BuyGames");
        }
    }
}
