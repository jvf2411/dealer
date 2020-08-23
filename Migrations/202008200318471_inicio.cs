namespace dealer1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        Apellido = c.String(maxLength: 100),
                        Direccion = c.String(maxLength: 500),
                        Telefono = c.String(maxLength: 20),
                        Correo = c.String(maxLength: 100),
                        Cedula = c.String(maxLength: 11),
                        Estatus = c.String(maxLength: 2),
                        FechaRegistro = c.DateTime(),
                        FechaModificacion = c.DateTime(),
                        creadopor = c.String(maxLength: 255),
                        Modificadopor = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        MetodoPago = c.String(maxLength: 50),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estatus = c.String(maxLength: 2),
                        FechaRegistro = c.DateTime(),
                        FechaModificacion = c.DateTime(),
                        creadopor = c.String(maxLength: 255),
                        Modificadopor = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculo", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.VehiculoId);
            
            CreateTable(
                "dbo.Vehiculo",
                c => new
                    {
                        VehiculoId = c.Int(nullable: false, identity: true),
                        TipoTransmisionId = c.Int(nullable: false),
                        TipoCombustibleId = c.Int(nullable: false),
                        ModeloId = c.Int(nullable: false),
                        Chasis = c.String(maxLength: 100),
                        Placa = c.String(maxLength: 20),
                        Año = c.String(maxLength: 4),
                        Color = c.String(maxLength: 20),
                        Cilindraje = c.String(maxLength: 10),
                        KilometrosTablero = c.String(maxLength: 50),
                        CantidadPuertas = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estatus = c.String(maxLength: 2),
                        FechaRegistro = c.DateTime(),
                        FechaModificacion = c.DateTime(),
                        creadopor = c.String(maxLength: 255),
                        Modificadopor = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.VehiculoId)
                .ForeignKey("dbo.Modelo", t => t.ModeloId, cascadeDelete: true)
                .Index(t => t.ModeloId);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        ModeloId = c.Int(nullable: false, identity: true),
                        MarcaId = c.Int(),
                        Nombre = c.String(maxLength: 100),
                        Estatus = c.String(maxLength: 2),
                        FechaRegistro = c.DateTime(),
                        FechaModificacion = c.DateTime(),
                        creadopor = c.String(maxLength: 255),
                        Modificadopor = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ModeloId);
            
            CreateTable(
                "dbo.usuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 10),
                        pass = c.String(maxLength: 10),
                        Estatus = c.String(maxLength: 2),
                        FechaRegistro = c.DateTime(),
                        FechaModificacion = c.DateTime(),
                        creadopor = c.String(maxLength: 255),
                        Modificadopor = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venta", "VehiculoId", "dbo.Vehiculo");
            DropForeignKey("dbo.Vehiculo", "ModeloId", "dbo.Modelo");
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Vehiculo", new[] { "ModeloId" });
            DropIndex("dbo.Venta", new[] { "VehiculoId" });
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            DropTable("dbo.usuario");
            DropTable("dbo.Modelo");
            DropTable("dbo.Vehiculo");
            DropTable("dbo.Venta");
            DropTable("dbo.Cliente");
        }
    }
}
