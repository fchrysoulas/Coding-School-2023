using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epsilon.CodingSchool.EF.Migrations
{
    /// <inheritdoc />
    public partial class TodoTypeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TodoType",
                schema: "App",
                table: "Todo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TodoType",
                schema: "App",
                table: "Todo");
        }
    }
}
