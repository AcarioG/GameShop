namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthDay", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDay", c => c.DateTime(nullable: false));
        }
    }
}
