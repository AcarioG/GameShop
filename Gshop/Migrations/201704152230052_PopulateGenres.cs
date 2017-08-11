namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Acción')");
            Sql("INSERT INTO Genres (Name) VALUES ('Aventura')");
            Sql("INSERT INTO Genres (Name) VALUES ('Disparos')");
            Sql("INSERT INTO Genres (Name) VALUES ('RPG')");
            Sql("INSERT INTO Genres (Name) VALUES ('Simulación')");
            Sql("INSERT INTO Genres (Name) VALUES ('Deportes')");
        }
        
        public override void Down()
        {
        }
    }
}
