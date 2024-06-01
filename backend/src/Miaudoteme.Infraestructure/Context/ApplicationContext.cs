using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Miaudoteme.Infraestructure.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Adopter> Adopters{ get; set; }
        public DbSet<Animal> Animals{ get; set; }
        public DbSet<Shelter> Shelters{ get; set; }
        public DbSet<Address> Address{ get; set; }
        public DbSet<Adoption> Adoptions{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=AudoteMeDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}