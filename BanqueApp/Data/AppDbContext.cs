using Microsoft.EntityFrameworkCore;
using BanqueApp.Models;

namespace BanqueApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuration de la relation Compte -> Transactions
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Compte)
                .WithMany(c => c.Transactions)
                .HasForeignKey(t => t.CompteId)
                .OnDelete(DeleteBehavior.Cascade);

            // Précision pour les décimaux
            modelBuilder.Entity<Compte>()
                .Property(c => c.SoldeActuel)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Montant)
                .HasPrecision(18, 2);
        }
    }
}
