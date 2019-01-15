namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s77 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "PochetteQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "PochetteQuantity");
        }
    }
}
