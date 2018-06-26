using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentEnrollment.Migrations
{
    public partial class studentgpa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "LastName");

            migrationBuilder.AlterColumn<decimal>(
                name: "GPA",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Students",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "GPA",
                table: "Students",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
