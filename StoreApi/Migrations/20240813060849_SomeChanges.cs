using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class SomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6578), new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6597), new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6608), new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6614), new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 8, 13, 0, 8, 48, 713, DateTimeKind.Local).AddTicks(6618) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
