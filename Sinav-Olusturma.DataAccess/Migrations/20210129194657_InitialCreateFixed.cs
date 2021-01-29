using Microsoft.EntityFrameworkCore.Migrations;

namespace Sinav_Olusturma.DataAccess.Migrations
{
    public partial class InitialCreateFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Stories_StoryId1",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_StoryId1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "StoryId1",
                table: "Questions");

            migrationBuilder.AlterColumn<string>(
                name: "StoryId",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_StoryId",
                table: "Questions",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Stories_StoryId",
                table: "Questions",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Stories_StoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_StoryId",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "StoryId",
                table: "Questions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoryId1",
                table: "Questions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_StoryId1",
                table: "Questions",
                column: "StoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Stories_StoryId1",
                table: "Questions",
                column: "StoryId1",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
