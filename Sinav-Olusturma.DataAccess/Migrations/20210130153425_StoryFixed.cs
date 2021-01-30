using Microsoft.EntityFrameworkCore.Migrations;

namespace Sinav_Olusturma.DataAccess.Migrations
{
    public partial class StoryFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Stories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Stories",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Stories",
                type: "TEXT",
                nullable: true);
        }
    }
}
