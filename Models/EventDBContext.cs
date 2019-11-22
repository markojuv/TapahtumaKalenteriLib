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

        public virtual DbSet<Kayttajat> Kayttajat { get; set; }
        public virtual DbSet<Tapahtumat> Tapahtumat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer($"Server=tcp:juvo.database.windows.net,1433;Initial Catalog=EventDB;Persist Security Info=False;User ID=Juvo10;Password=Passu1985!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
                //{Environment.GetEnvironmentVariable("User")}
                //{Environment.GetEnvironmentVariable("Passu")}
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kayttajat>(entity =>
            {
                entity.HasKey(e => e.KayttajaId)
                    .HasName("PK__Kayttaja__31CD3A04EC6940CA");

                entity.Property(e => e.KayttajaId).HasColumnName("KayttajaID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nimi)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tapahtumat>(entity =>
            {
                entity.HasKey(e => e.TapahtumaId)
                    .HasName("PK__Tapahtum__AD0F60D662C415E7");

                entity.Property(e => e.TapahtumaId).HasColumnName("TapahtumaID");

                entity.Property(e => e.Hinta).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Kategoria).HasMaxLength(100);

                entity.Property(e => e.Kuvaus).HasMaxLength(1000);

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Linkki).HasMaxLength(40);

                entity.Property(e => e.Long)
                    .HasColumnName("long")
                    .HasColumnType("decimal(9, 6)");

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
