using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core_WebApi.Models
{
    public partial class InnerJoinExercicioContext : DbContext
    {
        public InnerJoinExercicioContext()
        {
        }

        public InnerJoinExercicioContext(DbContextOptions<InnerJoinExercicioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carros> Carros { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vendas> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carros>(entity =>
            {
                entity.Property(e => e.Ano)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DatAlt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatInc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.MarcaNavigation)
                    .WithMany(p => p.Carros)
                    .HasForeignKey(d => d.Marca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carros_Marcas");
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DatAlt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatInc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DatAlt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatInc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vendas>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DatAlt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatInc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.HasOne(d => d.CarroNavigation)
                    .WithMany(p => p.Vendas)
                    .HasForeignKey(d => d.Carro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vendas_Carros");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
