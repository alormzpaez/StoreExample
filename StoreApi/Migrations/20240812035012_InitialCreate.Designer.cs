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
    [Migration("20240812035012_InitialCreate")]
    partial class InitialCreate
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
                            CreatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(761),
                            Description = "Una sudadera de material sencillo, con un estilo de programador simple.",
                            Name = "Sudadera de programador",
                            ThumbnailUrl = "https://m.media-amazon.com/images/I/71-7Wp3yqGL._UF1000,1000_QL80_.jpg",
                            UpdatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(785)
                        },
                        new
                        {
                            ProductID = 2,
                            CreatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(789),
                            Description = "Una taza para tomar cualquier líquido, con un estilo de programador simple.",
                            Name = "Taza de programador",
                            ThumbnailUrl = "https://i.etsystatic.com/19639181/r/il/a550cf/2601409584/il_794xN.2601409584_bw44.jpg",
                            UpdatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(790)
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
                            CreatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(811),
                            Currency = 0,
                            Name = "Taza oscura de programador",
                            ProductID = 2,
                            RetailPrice = 100f,
                            UpdatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(813)
                        },
                        new
                        {
                            VariantID = 2,
                            CreatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(820),
                            Currency = 0,
                            Name = "Taza blanca de programador",
                            ProductID = 2,
                            RetailPrice = 90f,
                            UpdatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(822)
                        },
                        new
                        {
                            VariantID = 3,
                            CreatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(826),
                            Currency = 0,
                            Name = "Sudadera oscura de programador",
                            ProductID = 1,
                            RetailPrice = 200f,
                            UpdatedAt = new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(827)
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