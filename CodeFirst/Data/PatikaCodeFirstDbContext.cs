using CodeFirst.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class PatikaCodeFirstDbContext : DbContext
    {
        public PatikaCodeFirstDbContext(DbContextOptions<PatikaCodeFirstDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        // Model oluşturma işlemleri için override edilen metot
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Movie tablosu için yapılandırmalar
            modelBuilder.Entity<Movie>()
                .HasKey(m => m.Id); // Id birincil anahtar

            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired() // Title zorunlu
                .HasMaxLength(100); // Maksimum uzunluk 100 karakter

            modelBuilder.Entity<Movie>()
                .Property(m => m.Genre)
                .IsRequired() // Genre zorunlu
                .HasMaxLength(50); // Maksimum uzunluk 50 karakter

            modelBuilder.Entity<Movie>()
                .Property(m => m.ReleaseYear)
                .IsRequired(); // ReleaseYear zorunlu

            // Game tablosu için yapılandırmalar
            modelBuilder.Entity<Game>()
                .HasKey(g => g.Id); // Id birincil anahtar

            modelBuilder.Entity<Game>()
                .Property(g => g.Name)
                .IsRequired() // Name zorunlu
                .HasMaxLength(100); // Maksimum uzunluk 100 karakter

            modelBuilder.Entity<Game>()
                .Property(g => g.Platform)
                .IsRequired() // Platform zorunlu
                .HasMaxLength(50); // Maksimum uzunluk 50 karakter

            modelBuilder.Entity<Game>()
                .Property(g => g.Rating)
                .IsRequired() // Rating zorunlu
                .HasPrecision(2, 1); // 0 ile 10 arasında bir decimal değer
        }
        }
    }

