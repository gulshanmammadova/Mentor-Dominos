using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorFrontToBack.Migrations
{
    public partial class DeletedSomeProportysFromAboutClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCount",
                table: "aboutpages");

            migrationBuilder.DropColumn(
                name: "EventsCount",
                table: "aboutpages");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "aboutpages");

            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "aboutpages");

            migrationBuilder.DropColumn(
                name: "TrainersCount",
                table: "aboutpages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseCount",
                table: "aboutpages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventsCount",
                table: "aboutpages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "aboutpages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentCount",
                table: "aboutpages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainersCount",
                table: "aboutpages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
