using System;
using Microsoft.EntityFrameworkCore;

namespace MyfirstApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catogery>().HasData(
                new Catogery { Id = 1, Name = "Active Wear - Men" },
                new Catogery { Id = 2, Name = "Active Wear - Women" },
                new Catogery { Id = 3, Name = "Mineral Water" },
                new Catogery { Id = 4, Name = "Publications" },
                new Catogery { Id = 5, Name = "Supplements" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CatogeryId = 1, Name = "Grunge Skater Jeans", Sku = "AWMGSJ", Price = 68, Isavailable = true },
                new Product { Id = 2, CatogeryId = 1, Name = "Polo Shirt", Sku = "AWMPS", Price = 35, Isavailable = true },
                new Product { Id = 3, CatogeryId = 1, Name = "Skater Graphic T-Shirt", Sku = "AWMSGT", Price = 33, Isavailable = true },
                new Product { Id = 4, CatogeryId = 1, Name = "Slicker Jacket", Sku = "AWMSJ", Price = 125, Isavailable = true },
                new Product { Id = 5, CatogeryId = 1, Name = "Thermal Fleece Jacket", Sku = "AWMTFJ", Price = 60, Isavailable = true },
                new Product { Id = 6, CatogeryId = 1, Name = "Unisex Thermal Vest", Sku = "AWMUTV", Price = 95, Isavailable = true },
                new Product { Id = 7, CatogeryId = 1, Name = "V-Neck Pullover", Sku = "AWMVNP", Price = 65, Isavailable = true },
                new Product { Id = 8, CatogeryId = 1, Name = "V-Neck Sweater", Sku = "AWMVNS", Price = 65, Isavailable = true },
                new Product { Id = 9, CatogeryId = 1, Name = "V-Neck T-Shirt", Sku = "AWMVNT", Price = 17, Isavailable = true },
                new Product { Id = 10, CatogeryId = 2, Name = "Bamboo Thermal Ski Coat", Sku = "AWWBTSC", Price = 99, Isavailable = true },
                new Product { Id = 11, CatogeryId = 2, Name = "Cross-Back Training Tank", Sku = "AWWCTT", Price = 0, Isavailable = false },
                new Product { Id = 12, CatogeryId = 2, Name = "Grunge Skater Jeans", Sku = "AWWGSJ", Price = 68, Isavailable = true },
                new Product { Id = 13, CatogeryId = 2, Name = "Slicker Jacket", Sku = "AWWSJ", Price = 125, Isavailable = true },
                new Product { Id = 14, CatogeryId = 2, Name = "Stretchy Dance Pants", Sku = "AWWSDP", Price = 55, Isavailable = true },
                new Product { Id = 15, CatogeryId = 2, Name = "Ultra-Soft Tank Top", Sku = "AWWUTT", Price = 22, Isavailable = true },
                new Product { Id = 16, CatogeryId = 2, Name = "Unisex Thermal Vest", Sku = "AWWUTV", Price = 95, Isavailable = true },
                new Product { Id = 17, CatogeryId = 2, Name = "V-Next T-Shirt", Sku = "AWWVNT", Price = 17, Isavailable = true },
                new Product { Id = 18, CatogeryId = 3, Name = "Blueberry Mineral Water", Sku = "MWB", Price = 2.8M, Isavailable = true },
                new Product { Id = 19, CatogeryId = 3, Name = "Lemon-Lime Mineral Water", Sku = "MWLL", Price = 2.8M, Isavailable = true },
                new Product { Id = 20, CatogeryId = 3, Name = "Orange Mineral Water", Sku = "MWO", Price = 2.8M, Isavailable = true },
                new Product { Id = 21, CatogeryId = 3, Name = "Peach Mineral Water", Sku = "MWP", Price = 2.8M, Isavailable = true },
                new Product { Id = 22, CatogeryId = 3, Name = "Raspberry Mineral Water", Sku = "MWR", Price = 2.8M, Isavailable = true },
                new Product { Id = 23, CatogeryId = 3, Name = "Strawberry Mineral Water", Sku = "MWS", Price = 2.8M, Isavailable = true },
                new Product { Id = 24, CatogeryId = 4, Name = "In the Kitchen with H+ Sport", Sku = "PITK", Price = 24.99M, Isavailable = true },
                new Product { Id = 25, CatogeryId = 5, Name = "Calcium 400 IU (150 tablets)", Sku = "SC400", Price = 9.99M, Isavailable = true },
                new Product { Id = 26, CatogeryId = 5, Name = "Flaxseed Oil 100 mg (90 capsules)", Sku = "SFO100", Price = 12.49M, Isavailable = true },
                new Product { Id = 27, CatogeryId = 5, Name = "Iron 65 mg (150 caplets)", Sku = "SI65", Price = 13.99M, Isavailable = true },
                new Product { Id = 28, CatogeryId = 5, Name = "Magnesium 250 mg (100 tablets)", Sku = "SM250", Price = 12.49M, Isavailable = true },
                new Product { Id = 29, CatogeryId = 5, Name = "Multi-Vitamin (90 capsules)", Sku = "SMV", Price = 9.99M, Isavailable = true },
                new Product { Id = 30, CatogeryId = 5, Name = "Vitamin A 10,000 IU (125 caplets)", Sku = "SVA", Price = 11.99M, Isavailable = true },
                new Product { Id = 31, CatogeryId = 5, Name = "Vitamin B-Complex (100 caplets)", Sku = "SVB", Price = 12.99M, Isavailable = true },
                new Product { Id = 32, CatogeryId = 5, Name = "Vitamin C 1000 mg (100 tablets)", Sku = "SVC", Price = 9.99M, Isavailable = true },
                new Product { Id = 33, CatogeryId = 5, Name = "Vitamin D3 1000 IU (100 tablets)", Sku = "SVD3", Price = 12.49M, Isavailable = true });
        }
    }
}


