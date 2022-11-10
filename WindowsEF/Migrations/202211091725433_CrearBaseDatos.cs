﻿namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Precio = c.Decimal(nullable: false, storeType: "money"),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProductoID)
                .ForeignKey("dbo.Categoria", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        SID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.SID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            DropTable("dbo.Empleado");
            DropTable("dbo.Producto");
            DropTable("dbo.Categoria");
        }
    }
}
