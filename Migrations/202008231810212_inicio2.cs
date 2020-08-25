namespace dealer1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Borrado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Venta", "Borrado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Vehiculo", "Borrado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Modelo", "Borrado", c => c.Boolean(nullable: false));
            AddColumn("dbo.usuario", "Borrado", c => c.Boolean(nullable: false));
            DropColumn("dbo.Cliente", "Estatus");
            DropColumn("dbo.Venta", "Estatus");
            DropColumn("dbo.Vehiculo", "Estatus");
            DropColumn("dbo.Modelo", "Estatus");
            DropColumn("dbo.usuario", "Estatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.usuario", "Estatus", c => c.String(maxLength: 2));
            AddColumn("dbo.Modelo", "Estatus", c => c.String(maxLength: 2));
            AddColumn("dbo.Vehiculo", "Estatus", c => c.String(maxLength: 2));
            AddColumn("dbo.Venta", "Estatus", c => c.String(maxLength: 2));
            AddColumn("dbo.Cliente", "Estatus", c => c.String(maxLength: 2));
            DropColumn("dbo.usuario", "Borrado");
            DropColumn("dbo.Modelo", "Borrado");
            DropColumn("dbo.Vehiculo", "Borrado");
            DropColumn("dbo.Venta", "Borrado");
            DropColumn("dbo.Cliente", "Borrado");
        }
    }
}
