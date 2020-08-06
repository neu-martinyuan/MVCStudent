using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcStudent.Migrations
{
    public partial class Classroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Classroom",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classroom",
                table: "Student");
        }
    }
}
