using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mercadona.Models;

namespace Mercadona.Data
{
    public class MercadonaContext : DbContext
    {
        public MercadonaContext(DbContextOptions<MercadonaContext> options) : base(options) { }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().ToTable("ctgcategorie");
            modelBuilder.Entity<Promotion>().ToTable("prmpromotion");
            modelBuilder.Entity<Produit>().ToTable("prdproduit");
            modelBuilder.Entity<User>().ToTable("usrutilisateur");
        }
    }
}
