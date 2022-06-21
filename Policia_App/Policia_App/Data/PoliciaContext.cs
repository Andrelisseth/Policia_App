using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Policia_App.Models;

namespace Policia_App.Data
{
    public partial class PoliciaContext : DbContext
    {
        public PoliciaContext()
        {
        }

        public PoliciaContext(DbContextOptions<PoliciaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Multum> Multa { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Policium> Policia { get; set; } = null!;
        public virtual DbSet<Vehiculo> Vehiculos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QO4O4D8;Database=Policia;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Multum>(entity =>
            {
                entity.HasKey(e => e.IdMulta)
                    .HasName("PK__Multa__295650BB526DF061");

                entity.Property(e => e.IdMulta).HasColumnName("id_multa");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdPolicia).HasColumnName("id_policia");

                entity.Property(e => e.IdVehiculo).HasColumnName("id_vehiculo");

                entity.HasOne(d => d.IdPoliciaNavigation)
                    .WithMany(p => p.Multa)
                    .HasForeignKey(d => d.IdPolicia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Multa__id_polici__2C3393D0");

                entity.HasOne(d => d.IdVehiculoNavigation)
                    .WithMany(p => p.Multa)
                    .HasForeignKey(d => d.IdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Multa__id_vehicu__2B3F6F97");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__228148B00B0F14FC");

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Policium>(entity =>
            {
                entity.HasKey(e => e.IdPolicia)
                    .HasName("PK__Policia__2AF5521FEAA3DCB7");

                entity.Property(e => e.IdPolicia).HasColumnName("id_policia");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Oni)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ONI");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PK__Vehiculo__F5DC0F394948DE98");

                entity.ToTable("Vehiculo");

                entity.Property(e => e.IdVehiculo).HasColumnName("id_vehiculo");

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("modelo");

                entity.Property(e => e.Placa)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("placa");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vehiculo__id_per__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
