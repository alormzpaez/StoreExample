﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApi.DBContext;

#nullable disable

namespace StoreApi.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20240813060849_SomeChanges")]
    partial class SomeChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoreApi.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductID");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CreatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6578),
                            Description = "Una sudadera de material sencillo, con un estilo de programador simple.",
                            Name = "Sudadera de programador",
                            ThumbnailUrl = "https://m.media-amazon.com/images/I/71-7Wp3yqGL._UF1000,1000_QL80_.jpg",
                            UpdatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6594)
                        },
                        new
                        {
                            ProductID = 2,
                            CreatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6597),
                            Description = "Una taza para tomar cualquier líquido, con un estilo de programador simple.",
                            Name = "Taza de programador",
                            ThumbnailUrl = "https://i.etsystatic.com/19639181/r/il/a550cf/2601409584/il_794xN.2601409584_bw44.jpg",
                            UpdatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6598)
                        });
                });

            modelBuilder.Entity("StoreApi.Models.Variant", b =>
                {
                    b.Property<int>("VariantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VariantID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<float>("RetailPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("VariantID");

                    b.HasIndex("ProductID");

                    b.ToTable("Variants", (string)null);

                    b.HasData(
                        new
                        {
                            VariantID = 1,
                            CreatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6608),
                            Currency = 0,
                            Name = "Taza oscura de programador",
                            ProductID = 2,
                            RetailPrice = 100f,
                            UpdatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6609)
                        },
                        new
                        {
                            VariantID = 2,
                            CreatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6614),
                            Currency = 0,
                            Name = "Taza blanca de programador",
                            ProductID = 2,
                            RetailPrice = 90f,
                            UpdatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6615)
                        },
                        new
                        {
                            VariantID = 3,
                            CreatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6617),
                            Currency = 0,
                            Name = "Sudadera oscura de programador",
                            ProductID = 1,
                            RetailPrice = 200f,
                            UpdatedAt = new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6618)
                        });
                });

            modelBuilder.Entity("StoreApi.Models.Variant", b =>
                {
                    b.HasOne("StoreApi.Models.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreApi.Models.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
