using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b16e978-cfcb-4d1d-bf9e-3b735edaa966");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3faa4752-97ee-4ed8-bcc9-8b71201cfba4", "0fb444ab-da6d-4817-919f-0dbd7d8f5b06" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3faa4752-97ee-4ed8-bcc9-8b71201cfba4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fb444ab-da6d-4817-919f-0dbd7d8f5b06");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0a4ebc2-f2c9-4519-8d39-4e37de4be8b6", "adc0e51a-94eb-4c02-b4ce-0ddfe6052b0f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5714e1b-853e-4a14-b50b-ae69fed8c591", "69653aa6-0330-4373-8db5-6003e3229be1", "Normal", "NORMAL" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassportNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4c76b3ca-502a-4ff6-a737-06905df5f1c2", 0, "2cccd894-7a11-41f1-b42a-89b14fe25fc9", "admin@email.com", true, false, null, "ADMIN@EMAIL.COM", "ADMIN@EMAIL.COM", "", "AQAAAAEAACcQAAAAENxjh7haYXCnFWEe9RyYyL3VHxnyixxLftyEJhq/xImUGdbiorLmIY4IDfaz2w4+DA==", null, false, "8beef3bf-1c58-4bda-bacb-a1d912ee40bb", false, "admin@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d0a4ebc2-f2c9-4519-8d39-4e37de4be8b6", "4c76b3ca-502a-4ff6-a737-06905df5f1c2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5714e1b-853e-4a14-b50b-ae69fed8c591");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0a4ebc2-f2c9-4519-8d39-4e37de4be8b6", "4c76b3ca-502a-4ff6-a737-06905df5f1c2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0a4ebc2-f2c9-4519-8d39-4e37de4be8b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c76b3ca-502a-4ff6-a737-06905df5f1c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b16e978-cfcb-4d1d-bf9e-3b735edaa966", "10a0b1a5-b333-4867-b14b-a8a7ed2b0610", "Normal", "NORMAL" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3faa4752-97ee-4ed8-bcc9-8b71201cfba4", "9ab560ab-ddae-42a1-bf31-469ad45684b0", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassportNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0fb444ab-da6d-4817-919f-0dbd7d8f5b06", 0, "eb46a2b4-eaae-4fe6-a469-ab23c1528dda", "admin@email.com", false, false, null, "ADMIN@EMAIL.COM", "ADMIN@EMAIL.COM", "", "AQAAAAEAACcQAAAAEKrZcXlVnryJv8D8AJ7M7RLsO78wsrO5OAbFBU7Ae2V+MRMgXCw4VBe025fSgKiMtg==", null, false, "e83ae1f4-257c-4f4a-ab1c-a6daadba8e76", false, "admin@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3faa4752-97ee-4ed8-bcc9-8b71201cfba4", "0fb444ab-da6d-4817-919f-0dbd7d8f5b06" });
        }
    }
}
