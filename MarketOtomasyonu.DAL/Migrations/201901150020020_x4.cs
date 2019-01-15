namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "PochetteQuantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "PochetteQuantity", c => c.Int(nullable: false));
        }
    }
}
