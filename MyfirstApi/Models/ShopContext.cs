using System;
using Microsoft.EntityFrameworkCore;
namespace MyfirstApi.Models
{
	public class ShopContext:DbContext
	{
		public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catogery>()
                .HasMany(c => c.Products)
                .WithOne(a => a.Catogery)
                .HasForeignKey(a => a.CatogeryId);
            modelBuilder.Seed(); 
        }
        public DbSet<Catogery> catogeries { get; set; }
		public DbSet<Product> products { get; set; }
	}
}

