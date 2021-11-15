using Microsoft.EntityFrameworkCore.Migrations;

namespace Kuwaderno.Migrations
{
    public partial class AddKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artList_AspNetUsers_UserId1",
                table: "artList");

            migrationBuilder.DropIndex(
                name: "IX_artList_UserId1",
                table: "artList");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "artList");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "artList",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_artList_UserId",
                table: "artList",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_artList_AspNetUsers_UserId",
                table: "artList",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artList_AspNetUsers_UserId",
                table: "artList");

            migrationBuilder.DropIndex(
                name: "IX_artList_UserId",
                table: "artList");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "artList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "artList",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_artList_UserId1",
                table: "artList",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_artList_AspNetUsers_UserId1",
                table: "artList",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
