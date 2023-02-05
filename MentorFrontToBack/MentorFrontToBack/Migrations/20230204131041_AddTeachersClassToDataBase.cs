using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorFrontToBack.Migrations
{
    public partial class AddTeachersClassToDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_taechers",
                table: "taechers");

            migrationBuilder.RenameTable(
                name: "taechers",
                newName: "teachers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teachers",
                table: "teachers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_teachers",
                table: "teachers");

            migrationBuilder.RenameTable(
                name: "teachers",
                newName: "taechers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_taechers",
                table: "taechers",
                column: "Id");
        }
    }
}
