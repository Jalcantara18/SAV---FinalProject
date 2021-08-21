namespace SAV___FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SV1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alquiler", "UsuarioModifico", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "UsuarioModifico", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "UsuarioModifico", c => c.Int(nullable: false));
            AlterColumn("dbo.Vehiculo", "UsuarioModifico", c => c.Int(nullable: false));
            AlterColumn("dbo.Modelo", "UsuarioModifico", c => c.Int(nullable: false));
            AlterColumn("dbo.Marca", "UsuarioModifico", c => c.Int(nullable: false));
            AlterColumn("dbo.TipoCombustible", "UsuarioModifico", c => c.Int(nullable: false));
            AlterColumn("dbo.TipoTransmision", "UsuarioModifico", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoTransmision", "UsuarioModifico", c => c.String(nullable: false));
            AlterColumn("dbo.TipoCombustible", "UsuarioModifico", c => c.String(nullable: false));
            AlterColumn("dbo.Marca", "UsuarioModifico", c => c.String(nullable: false));
            AlterColumn("dbo.Modelo", "UsuarioModifico", c => c.String(nullable: false));
            AlterColumn("dbo.Vehiculo", "UsuarioModifico", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "UsuarioModifico", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "UsuarioModifico", c => c.String(nullable: false));
            AlterColumn("dbo.Alquiler", "UsuarioModifico", c => c.String(nullable: false));
        }
    }
}
