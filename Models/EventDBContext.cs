using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TapahtumaLib.Models
{
    public partial class EventDBContext : DbContext
    {
        public EventDBContext()
        {
        }

        public EventDBContext(DbContextOptions<EventDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tapahtumat> Tapahtumat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=EventDB;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tapahtumat>(entity =>
            {
                entity.HasKey(e => e.TapahtumaId)
                    .HasName("PK__Tapahtum__AD0F60D63466DC7E");

                entity.Property(e => e.TapahtumaId).HasColumnName("TapahtumaID");

                entity.Property(e => e.Hinta).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Kategoria).HasMaxLength(100);

                entity.Property(e => e.Kuvaus).HasMaxLength(1000);

                entity.Property(e => e.Linkki).HasMaxLength(40);

                entity.Property(e => e.Nimi)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Päivämäärä).HasColumnType("date");

                entity.Property(e => e.Sijainti)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
