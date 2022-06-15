namespace BookStoreApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AuthorID = c.Int(nullable: false),
                        PublisherID = c.Int(nullable: false),
                        YearOfIssue = c.Int(nullable: false),
                        NumberOfPages = c.Int(nullable: false),
                        GenreID = c.Int(nullable: false),
                        QuantityInStock = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Publishers", t => t.PublisherID, cascadeDelete: true)
                .Index(t => t.AuthorID)
                .Index(t => t.PublisherID)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .Index(t => t.BookID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OfficeAddress = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOfBook = c.String(),
                        DateOfSale = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "PublisherID", "dbo.Publishers");
            DropForeignKey("dbo.Books", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Baskets", "BookID", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Baskets", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "GenreID" });
            DropIndex("dbo.Books", new[] { "PublisherID" });
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropTable("dbo.Sales");
            DropTable("dbo.Employees");
            DropTable("dbo.Publishers");
            DropTable("dbo.Genres");
            DropTable("dbo.Baskets");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
