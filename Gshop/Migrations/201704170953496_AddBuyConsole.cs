namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuyConsole : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyConsoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        GameId = c.Int(nullable: false),
                        DateAdded = c.DateTime(),
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
            DropForeignKey("dbo.BuyConsoles", "GameId", "dbo.Games");
            DropForeignKey("dbo.BuyConsoles", "CustomerId", "dbo.Customers");
            DropIndex("dbo.BuyConsoles", new[] { "GameId" });
            DropIndex("dbo.BuyConsoles", new[] { "CustomerId" });
            DropTable("dbo.BuyConsoles");
        }
    }
}
