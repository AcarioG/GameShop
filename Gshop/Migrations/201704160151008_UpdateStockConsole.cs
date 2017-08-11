namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStockConsole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Consoles", "Stock", c => c.Int(nullable: false));
            DropColumn("dbo.Consoles", "Strock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Consoles", "Strock", c => c.Int(nullable: false));
            DropColumn("dbo.Consoles", "Stock");
        }
    }
}
