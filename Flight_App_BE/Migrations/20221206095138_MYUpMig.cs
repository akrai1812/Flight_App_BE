using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight_App_BE.Migrations
{
    public partial class MYUpMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "Fare",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "BookingStatus",
                table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "BusinessFare",
                table: "Flight",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EconomyFare",
                table: "Flight",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstClassFare",
                table: "Flight",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fare",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NPass",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PAge",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PGender",
                table: "Booking",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PName",
                table: "Booking",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessFare",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "EconomyFare",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "FirstClassFare",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Fare",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "NPass",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "PAge",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "PGender",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "PName",
                table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fare",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookingStatus",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
