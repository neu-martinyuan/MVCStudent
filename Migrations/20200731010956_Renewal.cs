using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcStudent.Migrations
{
    public partial class Renewal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Renewal",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Renewal",
                table: "Student");
        }
    }
}
