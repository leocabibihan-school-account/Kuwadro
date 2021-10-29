using Microsoft.EntityFrameworkCore.Migrations;

namespace Kuwaderno.Migrations
{
    public partial class CreateArt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "AspNetUsers");
        }
    }
}
