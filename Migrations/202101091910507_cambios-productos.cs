namespace SerialPortApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosproductos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CodePersonolize", c => c.String(nullable: false));
            AddColumn("dbo.Tickets", "Message", c => c.String());
            AlterColumn("dbo.Products", "ProductCategory", c => c.String(nullable: false));
            DropColumn("dbo.Tickets", "comentario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "comentario", c => c.String());
            AlterColumn("dbo.Products", "ProductCategory", c => c.String());
            DropColumn("dbo.Tickets", "Message");
            DropColumn("dbo.Products", "CodePersonolize");
        }
    }
}
