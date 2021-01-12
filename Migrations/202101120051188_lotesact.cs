namespace SerialPortApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lotesact : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Batchs",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            BatchNumber = c.String(nullable: false),
            //            Description = c.String(),
            //            Person = c.String(),
            //            BatchStatus = c.Boolean(nullable: false),
            //            DateOpen = c.DateTime(nullable: false),
            //            DateClose = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Batchs");
        }
    }
}
