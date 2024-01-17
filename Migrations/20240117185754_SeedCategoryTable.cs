using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game_Menager_Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 17, 19, 57, 53, 919, DateTimeKind.Local).AddTicks(9634), 1, "Action" },
                    { 2, new DateTime(2024, 1, 17, 19, 57, 53, 919, DateTimeKind.Local).AddTicks(9710), 2, "SciFi" },
                    { 3, new DateTime(2024, 1, 17, 19, 57, 53, 919, DateTimeKind.Local).AddTicks(9712), 3, "History" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
