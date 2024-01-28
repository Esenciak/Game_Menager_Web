using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Menager_Web.Migrations
{
    /// <inheritdoc />
    public partial class AddHeroTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Skill2",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill3",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill4",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkillDescription2",
                table: "Heroes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkillDescription3",
                table: "Heroes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkillDescription4",
                table: "Heroes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SkillRank2",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillRank3",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillRank4",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Skill2", "Skill3", "Skill4", "SkillDescription2", "SkillDescription3", "SkillDescription4", "SkillRank2", "SkillRank3", "SkillRank4" },
                values: new object[] { "Szybkie strzelanie", "Wysoki skok", "Sokole oko", "Postać Wystrzeliwuje serię strzał", "Postać skaczę wysoko", "Postać widzi na znaczną odległość", 5, 5, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill2",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Skill3",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Skill4",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SkillDescription2",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SkillDescription3",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SkillDescription4",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SkillRank2",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SkillRank3",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SkillRank4",
                table: "Heroes");
        }
    }
}
