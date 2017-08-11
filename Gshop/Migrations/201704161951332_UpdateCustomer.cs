namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Consoles", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Consoles", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.Consoles", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Telephone", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "BirthDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "DateAdded", c => c.DateTime());
            AlterColumn("dbo.Games", "Name", c => c.String());
            AlterColumn("dbo.Customers", "BirthDay", c => c.DateTime());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Telephone", c => c.String(maxLength: 12));
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Consoles", "DateAdded", c => c.DateTime());
            AlterColumn("dbo.Consoles", "Company", c => c.String());
            AlterColumn("dbo.Consoles", "Name", c => c.String());
        }
    }
}
