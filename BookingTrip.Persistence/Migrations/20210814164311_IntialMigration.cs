using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingTrip.Persistence.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    ResreverdByCustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tripDetails",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tripDetails", x => x.TripId);
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "CustomerId", "CustomerName", "Email", "Password" },
                values: new object[] { 1, "Ahmed Hassan", "ahmedHassan@gmail.com", "012345-ABcd" });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "Id", "CreationDate", "CustomerName", "Note", "ReservationDate", "ResreverdByCustomerId", "TripId" },
                values: new object[] { 1, new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed Hassan", "mxmacmcffewp", new DateTime(2011, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "tripDetails",
                columns: new[] { "TripId", "CityName", "Content", "CreationDate", "ImageUrl", "Price", "TripName" },
                values: new object[] { 1, "Cairo", " Some Content", new DateTime(2011, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "skxksxskx ", 1000, "Cairo museum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "tripDetails");
        }
    }
}
