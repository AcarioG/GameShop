namespace Gshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTelephoneCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Telephone", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Telephone", c => c.Long(nullable: false));
        }
    }
}
