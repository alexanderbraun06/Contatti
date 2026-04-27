using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace RubricaCompleta.Data
{
    public class ContattoDbContext : DbContext
    {
        public ContattoDbContext() : base() { }
        public ContattoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Contatto> Contatti { get; set; }
        public DbSet<Utente> Utenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Utente>()
                .HasMany(u => u.Contatti)
                .WithOne(c => c.Utente)
                .HasForeignKey(c => c.UserId);
        }
    }
}
