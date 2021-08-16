using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SAV___FinalProject.SAVDataModel.Entities;


namespace SAV___FinalProject.SAVDataModel.SAVContext
{
    public class SAVDBContext : DbContext
    {
        public SAVDBContext() : base("name=Myconn")
        {
        }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<TipoCombustible> TipoCombustible { get; set; }
        public DbSet<TipoTransmision> TipoTransmision { get; set; }
        public DbSet<Alquiler> Alquiler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Cliente
            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
                .HasKey(Key => Key.Id);
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Id)
               .IsRequired()
               .HasColumnName("ClienteId");
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Nombre)
               .HasMaxLength(100)
                .HasColumnType("Varchar")
                .IsRequired(); 
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Apellido)
               .HasMaxLength(100)
                .HasColumnType("Varchar")
                .IsRequired();
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Direccion)
               .HasMaxLength(500)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Telefono)
               .HasMaxLength(20)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Correo)
               .HasMaxLength(100)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Cedula)
               .HasMaxLength(11)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.Borrado)
               .IsRequired();
            modelBuilder.Entity<Cliente>()
               .Property(Prop => Prop.FechaRegistro)
               .IsRequired();
            modelBuilder.Entity<Cliente>()
                .Property(Prop => Prop.Estatus)
                .HasMaxLength(2)
                .HasColumnType("Varchar")
                .IsRequired();
            #endregion

            #region Marca
            modelBuilder.Entity<Marca>()
                .ToTable("Marca")
                .HasKey(Key => Key.Id);
            modelBuilder.Entity<Marca>()
               .Property(Prop => Prop.Id)
               .IsRequired()
               .HasColumnName("MarcaId");
            modelBuilder.Entity<Marca>()
               .Property(Prop => Prop.Nombre)
               .HasMaxLength(100)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Marca>()
               .Property(Prop => Prop.Borrado)
               .IsRequired();
            modelBuilder.Entity<Marca>()
               .Property(Prop => Prop.FechaRegistro)
               .IsRequired();
            modelBuilder.Entity<Marca>()
                .Property(Prop => Prop.Estatus)
                .HasMaxLength(2)
                .HasColumnType("Varchar")
                .IsRequired();
            #endregion

            #region Modelo
            modelBuilder.Entity<Modelo>()
                .ToTable("Modelo")
                .HasKey(Key => Key.Id);
            modelBuilder.Entity<Modelo>()
               .Property(Prop => Prop.Id)
               .IsRequired()
               .HasColumnName("ModeloId");
            modelBuilder.Entity<Modelo>()
               .Property(Prop => Prop.MarcaId)
               .IsRequired();
            modelBuilder.Entity<Modelo>()
              .Property(Prop => Prop.Nombre)
              .HasMaxLength(100)
              .HasColumnType("Varchar")
              .IsRequired();
            modelBuilder.Entity<Modelo>()
               .Property(Prop => Prop.Borrado)
               .IsRequired();
            modelBuilder.Entity<Modelo>()
               .Property(Prop => Prop.FechaRegistro)
               .IsRequired();
            modelBuilder.Entity<Modelo>()
                .Property(Prop => Prop.Estatus)
                .HasMaxLength(2)
                .HasColumnType("Varchar")
                .IsRequired();
            #endregion

            #region TipoCombustible
            modelBuilder.Entity<TipoCombustible>()
                .ToTable("TipoCombustible")
                .HasKey(Key => Key.Id);
            modelBuilder.Entity<TipoCombustible>()
               .Property(Prop => Prop.Id)
               .IsRequired()
               .HasColumnName("TipoCombustibleId");
            modelBuilder.Entity<TipoCombustible>()
               .Property(Prop => Prop.Nombre)
               .HasMaxLength(20)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<TipoCombustible>()
               .Property(Prop => Prop.Borrado)
               .IsRequired();
            modelBuilder.Entity<TipoCombustible>()
               .Property(Prop => Prop.FechaRegistro)
               .IsRequired();
            modelBuilder.Entity<TipoCombustible>()
                .Property(Prop => Prop.Estatus)
                .HasMaxLength(2)
                .HasColumnType("Varchar")
                .IsRequired();
            #endregion

            #region TipoTransmision
            modelBuilder.Entity<TipoTransmision>()
                .ToTable("TipoTransmision")
                .HasKey(Key => Key.Id);
            modelBuilder.Entity<TipoTransmision>()
               .Property(Prop => Prop.Id)
               .IsRequired()
               .HasColumnName("TipoTransmisionId");
            modelBuilder.Entity<TipoTransmision>()
               .Property(Prop => Prop.Nombre)
               .HasMaxLength(100)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<TipoTransmision>()
               .Property(Prop => Prop.Borrado)
               .IsRequired();
            modelBuilder.Entity<TipoTransmision>()
               .Property(Prop => Prop.FechaRegistro)
               .IsRequired();
            modelBuilder.Entity<TipoTransmision>()
                .Property(Prop => Prop.Estatus)
                .HasMaxLength(2)
                .HasColumnType("Varchar")
                .IsRequired();
            #endregion

            #region Vehiculo
            modelBuilder.Entity<Vehiculo>()
                .ToTable("Vehiculo")
                .HasKey(Key => Key.Id);
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Id)
               .IsRequired()
               .HasColumnName("VehiculoId");
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.TipoTransmisionId)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.TipoCombustibleId)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
              .Property(Prop => Prop.ModeloId)
              .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Chasis)
               .HasMaxLength(100)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Placa)
               .HasMaxLength(20)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Anio)
               .HasMaxLength(4)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Color)
               .HasMaxLength(20)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Cilindraje)
               .HasMaxLength(10)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.KilometrosTablero)
               .HasMaxLength(50)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.CantidadPuertas)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Precio)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.Borrado)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
               .Property(Prop => Prop.FechaRegistro)
               .IsRequired();
            modelBuilder.Entity<Vehiculo>()
                .Property(Prop => Prop.Estatus)
                .HasMaxLength(2)
                .HasColumnType("Varchar")
                .IsRequired();
            #endregion

            #region Alquiler
            modelBuilder.Entity<Alquiler>()
                .ToTable("Alquiler")
                .HasKey(Key => Key.Id);
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.Id)
               .IsRequired()
               .HasColumnName("AlquilerId");
            modelBuilder.Entity<Alquiler>()
              .Property(Prop => Prop.ClienteId)
              .IsRequired();
            modelBuilder.Entity<Alquiler>()
              .Property(Prop => Prop.VehiculoId)
              .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.MetodoPago)
               .HasMaxLength(50)
               .HasColumnType("Varchar")
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.Costo)
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.FechaDesde)
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.FechaHasta)
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.FechaDevolucion)
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.Penalidad)
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.Borrado)
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
               .Property(Prop => Prop.FechaRegistro)
               .IsRequired();
            modelBuilder.Entity<Alquiler>()
                .Property(Prop => Prop.Estatus)
                .HasMaxLength(2)
                .HasColumnType("Varchar")
                .IsRequired();

            #endregion
        }
    }
}