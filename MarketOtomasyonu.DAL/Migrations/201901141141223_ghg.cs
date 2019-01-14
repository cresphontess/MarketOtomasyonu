namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ghg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "PaymentType", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "SaleDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "SaleDateTime");
            DropColumn("dbo.Sales", "PaymentType");
        }
    }
}
