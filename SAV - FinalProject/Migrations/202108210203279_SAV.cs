namespace SAV___FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SAV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alquiler",
                c => new
                    {
                        AlquilerId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        VehiculoId = c.Int(nullable: false),
                        MetodoPago = c.String(nullable: false, maxLength: 50, unicode: false),
                        Costo = c.Double(nullable: false),
                        FechaDesde = c.DateTime(nullable: false),
                        FechaHasta = c.DateTime(nullable: false),
                        FechaDevolucion = c.DateTime(nullable: false),
                        Penalidad = c.Double(nullable: false),
                        AtendidoPorId = c.Int(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.AlquilerId)
                .ForeignKey("dbo.Usuarios", t => t.AtendidoPorId, cascadeDelete: true)
                .ForeignKey("dbo.Cliente", t => t.Cliente_Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculo", t => t.VehiculoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.VehiculoId)
                .Index(t => t.AtendidoPorId)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuariosId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 11, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 100, unicode: false),
                        Correo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Sexo = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        Rol = c.String(nullable: false, maxLength: 15, unicode: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UsuariosId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 500, unicode: false),
                        Correo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cedula = c.String(nullable: false, maxLength: 11, unicode: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                        Alquiler_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Alquiler", t => t.Alquiler_Id)
                .Index(t => t.Alquiler_Id);
            
            CreateTable(
                "dbo.Vehiculo",
                c => new
                    {
                        VehiculoId = c.Int(nullable: false, identity: true),
                        TipoTransmisionId = c.Int(nullable: false),
                        TipoCombustibleId = c.Int(nullable: false),
                        ModeloId = c.Int(nullable: false),
                        Chasis = c.String(nullable: false, maxLength: 100, unicode: false),
                        Placa = c.String(nullable: false, maxLength: 20, unicode: false),
                        Anio = c.String(nullable: false, maxLength: 4, unicode: false),
                        Color = c.String(nullable: false, maxLength: 20, unicode: false),
                        Cilindraje = c.String(nullable: false, maxLength: 10, unicode: false),
                        KilometrosTablero = c.String(nullable: false, maxLength: 50, unicode: false),
                        CantidadPuertas = c.Int(nullable: false),
                        Precio = c.Double(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                        Vehiculo_Id = c.Int(),
                        Alquiler_Id = c.Int(),
                    })
                .PrimaryKey(t => t.VehiculoId)
                .ForeignKey("dbo.Modelo", t => t.ModeloId, cascadeDelete: true)
                .ForeignKey("dbo.TipoCombustible", t => t.TipoCombustibleId, cascadeDelete: true)
                .ForeignKey("dbo.TipoTransmision", t => t.TipoTransmisionId, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculo", t => t.Vehiculo_Id)
                .ForeignKey("dbo.Alquiler", t => t.Alquiler_Id)
                .Index(t => t.TipoTransmisionId)
                .Index(t => t.TipoCombustibleId)
                .Index(t => t.ModeloId)
                .Index(t => t.Vehiculo_Id)
                .Index(t => t.Alquiler_Id);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        ModeloId = c.Int(nullable: false, identity: true),
                        MarcaId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ModeloId)
                .ForeignKey("dbo.Marca", t => t.MarcaId, cascadeDelete: true)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MarcaId);
            
            CreateTable(
                "dbo.TipoCombustible",
                c => new
                    {
                        TipoCombustibleId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 20, unicode: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TipoCombustibleId);
            
            CreateTable(
                "dbo.TipoTransmision",
                c => new
                    {
                        TipoTransmisionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(),
                        UsuarioModifico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TipoTransmisionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehiculo", "Alquiler_Id", "dbo.Alquiler");
            DropForeignKey("dbo.Alquiler", "VehiculoId", "dbo.Vehiculo");
            DropForeignKey("dbo.Vehiculo", "Vehiculo_Id", "dbo.Vehiculo");
            DropForeignKey("dbo.Vehiculo", "TipoTransmisionId", "dbo.TipoTransmision");
            DropForeignKey("dbo.Vehiculo", "TipoCombustibleId", "dbo.TipoCombustible");
            DropForeignKey("dbo.Vehiculo", "ModeloId", "dbo.Modelo");
            DropForeignKey("dbo.Modelo", "MarcaId", "dbo.Marca");
            DropForeignKey("dbo.Cliente", "Alquiler_Id", "dbo.Alquiler");
            DropForeignKey("dbo.Alquiler", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Alquiler", "Cliente_Id", "dbo.Cliente");
            DropForeignKey("dbo.Alquiler", "AtendidoPorId", "dbo.Usuarios");
            DropIndex("dbo.Modelo", new[] { "MarcaId" });
            DropIndex("dbo.Vehiculo", new[] { "Alquiler_Id" });
            DropIndex("dbo.Vehiculo", new[] { "Vehiculo_Id" });
            DropIndex("dbo.Vehiculo", new[] { "ModeloId" });
            DropIndex("dbo.Vehiculo", new[] { "TipoCombustibleId" });
            DropIndex("dbo.Vehiculo", new[] { "TipoTransmisionId" });
            DropIndex("dbo.Cliente", new[] { "Alquiler_Id" });
            DropIndex("dbo.Alquiler", new[] { "Cliente_Id" });
            DropIndex("dbo.Alquiler", new[] { "AtendidoPorId" });
            DropIndex("dbo.Alquiler", new[] { "VehiculoId" });
            DropIndex("dbo.Alquiler", new[] { "ClienteId" });
            DropTable("dbo.TipoTransmision");
            DropTable("dbo.TipoCombustible");
            DropTable("dbo.Marca");
            DropTable("dbo.Modelo");
            DropTable("dbo.Vehiculo");
            DropTable("dbo.Cliente");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Alquiler");
        }
    }
}
