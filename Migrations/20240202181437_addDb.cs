using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Menager_Web.Migrations
{
    /// <inheritdoc />
    public partial class addDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Strenght = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weapon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillRank = table.Column<int>(type: "int", nullable: false),
                    SkillDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Skill2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillRank2 = table.Column<int>(type: "int", nullable: false),
                    SkillDescription2 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Skill3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillRank3 = table.Column<int>(type: "int", nullable: false),
                    SkillDescription3 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Skill4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillRank4 = table.Column<int>(type: "int", nullable: false),
                    SkillDescription4 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Age", "CreatedDateTime", "Description", "Dexterity", "Gender", "Gold", "HP", "Level", "Mana", "Name", "Race", "Skill", "Skill2", "Skill3", "Skill4", "SkillDescription", "SkillDescription2", "SkillDescription3", "SkillDescription4", "SkillRank", "SkillRank2", "SkillRank3", "SkillRank4", "Speed", "Strenght", "Weapon" },
                values: new object[] { 1, 1200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elf pochodzący ze szczepu Sindarów. W Trzeciej Erze był członkiem Drużyny Pierścienia.", 100, "Male", 20, 70, 12, 20, "Legolas", "Elf", "Ciche kroki", "Szybkie strzelanie", "Wysoki skok", "Sokole oko", "Postać porusza się bezszelestnie", "Postać Wystrzeliwuje serię strzał", "Postać skaczę wysoko", "Postać widzi na znaczną odległość", 5, 5, 5, 5, 120, 40, "Bow" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
