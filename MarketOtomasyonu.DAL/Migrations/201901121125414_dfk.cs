namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dfk : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "OrderDateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderDateTime", c => c.DateTime(nullable: false));
        }
    }
}
