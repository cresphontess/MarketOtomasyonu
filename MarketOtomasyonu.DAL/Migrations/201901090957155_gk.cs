namespace MarketOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderName");
        }
    }
}
