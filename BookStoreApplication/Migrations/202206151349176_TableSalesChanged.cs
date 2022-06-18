namespace BookStoreApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableSalesChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "BookID", c => c.Int(nullable: false));
            CreateIndex("dbo.Sales", "BookID");
            AddForeignKey("dbo.Sales", "BookID", "dbo.Books", "ID", cascadeDelete: true);
            DropColumn("dbo.Sales", "NameOfBook");
            DropColumn("dbo.Sales", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Sales", "NameOfBook", c => c.String());
            DropForeignKey("dbo.Sales", "BookID", "dbo.Books");
            DropIndex("dbo.Sales", new[] { "BookID" });
            DropColumn("dbo.Sales", "BookID");
        }
    }
}
