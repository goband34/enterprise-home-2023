using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class TryingToFixLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00c98e74-d87a-4371-8f18-1bf29c685bdf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa6afe5-7e92-41f5-8665-b904845f39c1", "9662f0a5-1190-4d1a-b1fd-9232a0c49ae7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5aa6afe5-7e92-41f5-8665-b904845f39c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9662f0a5-1190-4d1a-b1fd-9232a0c49ae7");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "00c98e74-d87a-4371-8f18-1bf29c685bdf", "e96755e2-00ca-4681-85c7-73af88510f78", "Normal", "NORMAL" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5aa6afe5-7e92-41f5-8665-b904845f39c1", "5444f1a7-3050-4913-b63c-1c73cbe12d40", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassportNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9662f0a5-1190-4d1a-b1fd-9232a0c49ae7", 0, "fcc0e75b-e6ad-4818-bfa4-e2276500537b", "admin@email.com", false, false, null, null, null, "", "AQAAAAEAACcQAAAAEIR6hssU8sd+809AX5ULl6q9vQHGOiTodiWZXTohSzkkzhBuTj6r+zXQ+npdnsafmQ==", null, false, "a377f18d-5640-46e8-a4af-6a18e44fb4d2", false, "admin@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5aa6afe5-7e92-41f5-8665-b904845f39c1", "9662f0a5-1190-4d1a-b1fd-9232a0c49ae7" });
        }
    }
}
