using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedOrderOfTablesCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 58, 5, 76, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(4), new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(40), new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(45), new DateTime(2024, 8, 11, 21, 58, 5, 77, DateTimeKind.Local).AddTicks(47) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(789), new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 8, 11, 21, 50, 12, 221, DateTimeKind.Local).AddTicks(827) });
        }
    }
}
