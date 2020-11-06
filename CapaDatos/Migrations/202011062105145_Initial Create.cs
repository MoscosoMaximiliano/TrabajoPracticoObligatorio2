namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        ID_Categoria = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_Categoria);
            
            CreateTable(
                "dbo.Consulta",
                c => new
                    {
                        ID_Consulta = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Mail = c.String(nullable: false, maxLength: 50),
                        NumberPhone = c.String(nullable: false),
                        Message = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_Consulta);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ID_Producto = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Single(nullable: false),
                        URL = c.String(nullable: false, maxLength: 100),
                        Offer = c.Boolean(nullable: false),
                        Featured = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Producto);
            
            CreateTable(
                "dbo.SubCategoria",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FK_ID_Categoria = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categoria", t => t.FK_ID_Categoria, cascadeDelete: false)
                .Index(t => t.FK_ID_Categoria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategoria", "FK_ID_Categoria", "dbo.Categoria");
            DropIndex("dbo.SubCategoria", new[] { "FK_ID_Categoria" });
            DropTable("dbo.SubCategoria");
            DropTable("dbo.Producto");
            DropTable("dbo.Consulta");
            DropTable("dbo.Categoria");
        }
    }
}
