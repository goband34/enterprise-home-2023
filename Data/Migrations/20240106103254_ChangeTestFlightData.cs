using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ChangeTestFlightData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Columns", "Rows" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Columns", "Rows" },
                values: new object[] { 12, 12 });
        }
    }
}
