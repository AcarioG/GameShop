namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuyConsole1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BuyConsoles", "GameId", "dbo.Games");
            DropIndex("dbo.BuyConsoles", new[] { "GameId" });
            AddColumn("dbo.BuyConsoles", "ConsoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.BuyConsoles", "ConsoleId");
            AddForeignKey("dbo.BuyConsoles", "ConsoleId", "dbo.Consoles", "Id", cascadeDelete: true);
            DropColumn("dbo.BuyConsoles", "GameId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BuyConsoles", "GameId", c => c.Int(nullable: false));
            DropForeignKey("dbo.BuyConsoles", "ConsoleId", "dbo.Consoles");
            DropIndex("dbo.BuyConsoles", new[] { "ConsoleId" });
            DropColumn("dbo.BuyConsoles", "ConsoleId");
            CreateIndex("dbo.BuyConsoles", "GameId");
            AddForeignKey("dbo.BuyConsoles", "GameId", "dbo.Games", "Id", cascadeDelete: true);
        }
    }
}
