using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class SeedingUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "950af058-2ff7-4635-b38b-e4b040b1ac0c", "4e030e91-c71d-4e1b-9500-953d1ae2b898", "Normal", "NORMAL" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f85cf9b3-4a31-4ae1-ac99-5c3719dfa4ef", "ae72a98c-8bbd-4283-9eb5-6058b471bce5", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassportNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c3e1716b-9c44-4d16-80e1-d1b44a739bf1", 0, "3b50dea9-c979-40e1-9d17-b0d0a4e95c46", "admin@email.com", false, false, null, null, null, "", "AQAAAAEAACcQAAAAENUMpv7PB+as8OM4Anp/TwCWmjN7I0VI8+ArG1XjXgrcsasELBDKCKfOtfa5hHojIQ==", null, false, "e2fc5452-5ec7-4d60-9dee-48215d94d2eb", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f85cf9b3-4a31-4ae1-ac99-5c3719dfa4ef", "c3e1716b-9c44-4d16-80e1-d1b44a739bf1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "950af058-2ff7-4635-b38b-e4b040b1ac0c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f85cf9b3-4a31-4ae1-ac99-5c3719dfa4ef", "c3e1716b-9c44-4d16-80e1-d1b44a739bf1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85cf9b3-4a31-4ae1-ac99-5c3719dfa4ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3e1716b-9c44-4d16-80e1-d1b44a739bf1");
        }
    }
}
