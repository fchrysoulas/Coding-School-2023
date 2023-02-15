using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epsilon.CodingSchool.EF.Migrations
{
    /// <inheritdoc />
    public partial class RestrictComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoComment_Todo_TodoId",
                schema: "App",
                table: "TodoComment");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoComment_Todo_TodoId",
                schema: "App",
                table: "TodoComment",
                column: "TodoId",
                principalSchema: "App",
                principalTable: "Todo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoComment_Todo_TodoId",
                schema: "App",
                table: "TodoComment");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoComment_Todo_TodoId",
                schema: "App",
                table: "TodoComment",
                column: "TodoId",
                principalSchema: "App",
                principalTable: "Todo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
