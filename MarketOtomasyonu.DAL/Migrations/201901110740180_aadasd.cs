namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aadasd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleDetails", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SaleDetails", "Quantity");
        }
    }
}
