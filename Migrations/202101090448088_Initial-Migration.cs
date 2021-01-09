namespace SerialPortApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCategory = c.String(),
                        Departament = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ingredients = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Numero = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        ProductId = c.String(),
                        ProductName = c.String(),
                        Peso_Bruto = c.Int(nullable: false),
                        Peso_tara = c.Int(nullable: false),
                        Peso_Neto = c.Int(nullable: false),
                        Operador = c.String(),
                        NumeroLote = c.Int(nullable: false),
                        NumeroCodeBar = c.String(),
                        comentario = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Int(nullable: false),
                        Ubicacion = c.String(),
                    })
                .PrimaryKey(t => t.Numero);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
            DropTable("dbo.Products");
        }
    }
}
