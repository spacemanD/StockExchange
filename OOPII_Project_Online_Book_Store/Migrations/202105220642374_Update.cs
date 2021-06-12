namespace StockExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bonds", "Kind", c => c.String());
            AddColumn("dbo.Possessions", "Kind", c => c.String());
            AddColumn("dbo.Stocks", "Kind", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stocks", "Kind");
            DropColumn("dbo.Possessions", "Kind");
            DropColumn("dbo.Bonds", "Kind");
        }
    }
}
