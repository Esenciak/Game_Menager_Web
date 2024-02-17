using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Game_Menager_Web.Migrations
{
    /// <inheritdoc />
    public partial class dbupd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Heroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserEmail",
                value: "TEST@GMAIL.COM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Heroes");
        }
    }
}
