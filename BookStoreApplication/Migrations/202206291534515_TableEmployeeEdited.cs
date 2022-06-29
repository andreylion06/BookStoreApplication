namespace BookStoreApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableEmployeeEdited : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employees", newName: "SignIns");
            DropColumn("dbo.SignIns", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SignIns", "FullName", c => c.String());
            RenameTable(name: "dbo.SignIns", newName: "Employees");
        }
    }
}
