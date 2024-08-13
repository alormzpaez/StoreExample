using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    VariantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetailPrice = table.Column<float>(type: "real", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.VariantID);
                    table.ForeignKey(
                        name: "FK_Variants_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CreatedAt", "Description", "Name", "ThumbnailUrl", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(761), "Una sudadera de material sencillo, con un estilo de programador simple.", "Sudadera de programador", "https://m.media-amazon.com/images/I/71-7Wp3yqGL._UF1000,1000_QL80_.jpg", new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(785) },
                    { 2, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(789), "Una taza para tomar cualquier líquido, con un estilo de programador simple.", "Taza de programador", "https://i.etsystatic.com/19639181/r/il/a550cf/2601409584/il_794xN.2601409584_bw44.jpg", new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(790) }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "VariantID", "CreatedAt", "Currency", "Name", "ProductID", "RetailPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(811), 0, "Taza oscura de programador", 2, 100f, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(813) },
                    { 2, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(820), 0, "Taza blanca de programador", 2, 90f, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(822) },
                    { 3, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(826), 0, "Sudadera oscura de programador", 1, 200f, new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(827) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductID",
                table: "Variants",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
