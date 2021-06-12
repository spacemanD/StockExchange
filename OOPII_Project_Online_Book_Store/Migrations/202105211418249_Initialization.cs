namespace StockExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bonds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Corporation = c.String(),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Picture = c.String(),
                        Issue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        AdminConfirm = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Possessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Picture = c.String(),
                        Issue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        Code = c.String(),
                        Publisher = c.String(),
                        Percent = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Picture = c.String(),
                        Issue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stocks");
            DropTable("dbo.Possessions");
            DropTable("dbo.Customers");
            DropTable("dbo.Bonds");
        }
    }
}
