using Microsoft.EntityFrameworkCore;
using netcore_desde_cero.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_desde_cero.Context
{
    public partial class AtomoContext : DbContext
    {
        public AtomoContext()
        {
        }

        public AtomoContext(DbContextOptions<AtomoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Echadura> Echadura { get; set; }
        public virtual DbSet<Pagina> Pagina { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Echadura>(entity =>
            {
                entity.ToTable("Echadura", "Flow");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacionUtc).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacionUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pagina>(entity =>
            {
                entity.ToTable("Pagina", "Flow");

                entity.Property(e => e.PaginaId).ValueGeneratedNever();

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacionUtc).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacionUtc).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
