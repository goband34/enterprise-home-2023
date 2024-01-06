using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddOneMoreTestFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "ID", "ArrivalDate", "Columns", "CommissionRate", "CountryFrom", "CountryTo", "DepartureDate", "Rows", "WholesalePrice" },
                values: new object[] { 4, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0.02, "Moldova", "Germany", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 300.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
