namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Packages", "PackageProductQuantity", c => c.Int(nullable: false));
            DropColumn("dbo.Packages", "ProductQuantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Packages", "ProductQuantity", c => c.Int(nullable: false));
            DropColumn("dbo.Packages", "PackageProductQuantity");
        }
    }
}
