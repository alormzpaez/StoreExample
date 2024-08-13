using Microsoft.EntityFrameworkCore;
using StoreApi.Models;
using System;

namespace StoreApi.DBContext
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            Product hoodie = new Product()
            {
                ProductID = 1,
                Name = "Sudadera de programador",
                Description = "Una sudadera de material sencillo, con un estilo de programador simple.",
                ThumbnailUrl = "https://m.media-amazon.com/images/I/71-7Wp3yqGL._UF1000,1000_QL80_.jpg",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            Product cup = new Product()
            {
                ProductID = 2,
                Name = "Taza de programador",
                Description = "Una taza para tomar cualquier líquido, con un estilo de programador simple.",
                ThumbnailUrl = "https://i.etsystatic.com/19639181/r/il/a550cf/2601409584/il_794xN.2601409584_bw44.jpg",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            List<Product> products = new List<Product>()
            {
                hoodie,
                cup
            };

            List<Variant> variants = new List<Variant>()
            {
                new Variant()
                {
                    VariantID = 1,
                    Name = "Taza oscura de programador",
                    Currency = Currency.MXN,
                    RetailPrice = 100,
                    ProductID = cup.ProductID,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Variant()
                {
                    VariantID = 2,
                    Name = "Taza blanca de programador",
                    Currency = Currency.MXN,
                    RetailPrice = 90,
                    ProductID = cup.ProductID,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                },
                new Variant()
                {
                    VariantID = 3,
                    Name = "Sudadera oscura de programador",
                    Currency = Currency.MXN,
                    RetailPrice = 200,
                    ProductID = hoodie.ProductID,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                }
            };

            modelBuilder.Entity<Variant>(entity =>
            {
                entity.ToTable("Variants");
                entity.HasKey(e => e.VariantID);

                entity.HasOne(e => e.Product).WithMany(e => e.Variants).HasForeignKey(e => e.ProductID);

                entity.Property(e => e.Name);
                entity.Property(e => e.RetailPrice);
                entity.Property(e => e.Currency);
                entity.Property(e => e.CreatedAt);
                entity.Property(e => e.UpdatedAt);

                entity.HasData(variants);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Products");
                entity.HasKey(e => e.ProductID);

                entity.Property(e => e.Name);
                entity.Property(e => e.ThumbnailUrl).IsRequired(false);
                entity.Property(e => e.Description);
                entity.Property(e => e.CreatedAt);
                entity.Property(e => e.UpdatedAt);

                entity.HasData(products);
            });
        }
    }
}
