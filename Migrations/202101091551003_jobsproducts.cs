namespace SerialPortApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jobsproducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitShop", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "UnitShop");
        }
    }
}
