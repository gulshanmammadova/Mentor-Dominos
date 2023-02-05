using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorFrontToBack.Migrations
{
    public partial class HomePageDeleteCourseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_homes_teachers_TeacherId",
                table: "homes");

            migrationBuilder.DropIndex(
                name: "IX_homes_TeacherId",
                table: "homes");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "homes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "homes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_homes_TeacherId",
                table: "homes",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_homes_teachers_TeacherId",
                table: "homes",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
