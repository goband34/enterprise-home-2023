using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddingTicketsToFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rows",
                table: "Tickets",
                newName: "Row");

            migrationBuilder.RenameColumn(
                name: "Columns",
                table: "Tickets",
                newName: "Column");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Row",
                table: "Tickets",
                newName: "Rows");

            migrationBuilder.RenameColumn(
                name: "Column",
                table: "Tickets",
                newName: "Columns");
        }
    }
}
