using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "ID", "ArrivalDate", "Columns", "CommissionRate", "CountryFrom", "CountryTo", "DepartureDate", "Rows", "WholesalePrice" },
                values: new object[] { 1, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 0.5, "Italy", "France", new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 50.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "ID", "ArrivalDate", "Columns", "CommissionRate", "CountryFrom", "CountryTo", "DepartureDate", "Rows", "WholesalePrice" },
                values: new object[] { 2, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2.0, "Spain", "Japan", new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 650.0 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "ID", "ArrivalDate", "Columns", "CommissionRate", "CountryFrom", "CountryTo", "DepartureDate", "Rows", "WholesalePrice" },
                values: new object[] { 3, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1.5, "Australia", "Russia", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 450.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
