namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTelephoneCustomerforce : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Telephone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Telephone", c => c.String(nullable: false, maxLength: 12));
        }
    }
}
