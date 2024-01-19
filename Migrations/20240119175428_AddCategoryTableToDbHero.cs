using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Game_Menager_Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTableToDbHero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Age", "CreatedDateTime", "Description", "Dexterity", "Gold", "HP", "Male", "Mana", "Name", "Race", "Skill", "SkillDescription", "SkillRank", "Speed", "Strenght", "Weapon" },
                values: new object[] { 1, 1200, new DateTime(2024, 1, 19, 18, 54, 28, 98, DateTimeKind.Local).AddTicks(8225), "elf pochodzący ze szczepu Sindarów. W Trzeciej Erze był członkiem Drużyny Pierścienia.", 100, 20, 70, 0, 20, "Legolas", "Elf", "Ciche kroki", "Postać porusza się bezszelestnie", 5, 120, 40, "Bow" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 19, 16, 52, 41, 595, DateTimeKind.Local).AddTicks(8389), 1, "Action" },
                    { 2, new DateTime(2024, 1, 19, 16, 52, 41, 595, DateTimeKind.Local).AddTicks(8440), 2, "SciFi" },
                    { 3, new DateTime(2024, 1, 19, 16, 52, 41, 595, DateTimeKind.Local).AddTicks(8443), 3, "History" }
                });
        }
    }
}
