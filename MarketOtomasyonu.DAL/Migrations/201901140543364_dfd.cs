namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dfd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleDetails", "ProductSellingPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Orders", "OrderDateTime");
            DropColumn("dbo.SaleDetails", "SaleAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaleDetails", "SaleAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "OrderDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.SaleDetails", "ProductSellingPrice");
        }
    }
}
