namespace BookStoreApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableSalesEdited : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "Count", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "Count");
        }
    }
}
