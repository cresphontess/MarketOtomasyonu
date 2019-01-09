namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "PackageId", "dbo.Packages");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.OrderDetails", new[] { "PackageId" });
            AddColumn("dbo.Packages", "OrderId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "ProductBarcode", c => c.String(nullable: false));
            CreateIndex("dbo.Packages", "OrderId");
            AddForeignKey("dbo.Packages", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
            DropTable("dbo.OrderDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        PackageId = c.Int(nullable: false),
                        OrderDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.PackageId });
            
            DropForeignKey("dbo.Packages", "OrderId", "dbo.Orders");
            DropIndex("dbo.Packages", new[] { "OrderId" });
            AlterColumn("dbo.Products", "ProductBarcode", c => c.String(nullable: false, maxLength: 10));
            DropColumn("dbo.Orders", "OrderDateTime");
            DropColumn("dbo.Packages", "OrderId");
            CreateIndex("dbo.OrderDetails", "PackageId");
            CreateIndex("dbo.OrderDetails", "OrderId");
            AddForeignKey("dbo.OrderDetails", "PackageId", "dbo.Packages", "PackageId", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
        }
    }
}
