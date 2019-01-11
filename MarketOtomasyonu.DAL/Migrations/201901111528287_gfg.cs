namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gfg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaleDetails",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        SaleId = c.Int(nullable: false),
                        SaleDateTime = c.DateTime(nullable: false),
                        SaleAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentType = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ReceivedAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GivenAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ProductId, t.SaleId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SaleId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SaleId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetails", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.SaleDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.SaleDetails", new[] { "SaleId" });
            DropIndex("dbo.SaleDetails", new[] { "ProductId" });
            DropTable("dbo.Sales");
            DropTable("dbo.SaleDetails");
        }
    }
}
