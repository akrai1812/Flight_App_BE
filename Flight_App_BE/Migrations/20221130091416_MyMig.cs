using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_App_BE.Migrations
{
    public partial class MyMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "User",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Mobile",
                table: "User",
                type: "float",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
