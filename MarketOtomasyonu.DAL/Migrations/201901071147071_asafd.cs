namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asafd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductBarcode = c.String(nullable: false),
                        ProductStock = c.Int(nullable: false),
                        ProductPurchasingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductSellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        PackageId = c.Int(nullable: false, identity: true),
                        PackageName = c.String(nullable: false),
                        PackageBarcode = c.String(nullable: false),
                        PackagePurchasingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductQuantity = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PackageId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        PackageId = c.Int(nullable: false),
                        OrderDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.PackageId })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Packages", t => t.PackageId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.PackageId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Packages", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "PackageId", "dbo.Packages");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.OrderDetails", new[] { "PackageId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Packages", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Packages");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
