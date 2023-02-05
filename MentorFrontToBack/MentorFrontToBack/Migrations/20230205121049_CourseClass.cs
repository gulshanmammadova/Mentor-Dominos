using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorFrontToBack.Migrations
{
    public partial class CourseClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courses_TeacherId",
                table: "courses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_teachers_TeacherId",
                table: "courses",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_teachers_TeacherId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_TeacherId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "courses");
        }
    }
}
