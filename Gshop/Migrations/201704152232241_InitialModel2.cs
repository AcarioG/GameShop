namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Company = c.String(),
                        DateAdded = c.DateTime(),
                        Price = c.Long(nullable: false),
                        Strock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(),
                        DateAdded = c.DateTime(),
                        Price = c.Long(nullable: false),
                        Stock = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        ConsoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consoles", t => t.ConsoleId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.ConsoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Games", "ConsoleId", "dbo.Consoles");
            DropIndex("dbo.Games", new[] { "ConsoleId" });
            DropIndex("dbo.Games", new[] { "GenreId" });
            DropTable("dbo.Games");
            DropTable("dbo.Consoles");
        }
    }
}
