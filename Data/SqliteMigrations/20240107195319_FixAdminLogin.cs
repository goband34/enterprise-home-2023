using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FixAdminLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "708439c1-447b-4ab0-b32f-e7c3faf86c94");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e77abb8-e91b-4294-8c5f-92c499d6db0c", "dd1f5413-7dff-4fda-bd70-135b3f12f91a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e77abb8-e91b-4294-8c5f-92c499d6db0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd1f5413-7dff-4fda-bd70-135b3f12f91a");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3e77abb8-e91b-4294-8c5f-92c499d6db0c", "d01e4cfb-eedd-4d7d-b37d-ff6788fa3031", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "708439c1-447b-4ab0-b32f-e7c3faf86c94", "8efea4a2-33be-4803-8c1b-c99a90d6394d", "Normal", "NORMAL" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassportNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd1f5413-7dff-4fda-bd70-135b3f12f91a", 0, "c54ac309-52d7-415d-9c30-359a85a65fae", "admin@email.com", false, false, null, null, null, "", "AQAAAAEAACcQAAAAEJEX2Spn461CG1Lkrrp/V05FGwcghxMfJZcF6MjIRi7M1ndVemePZjd0X5qWu8fE+g==", null, false, "cc797d1f-dd30-4e6f-b104-ecba07618e86", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3e77abb8-e91b-4294-8c5f-92c499d6db0c", "dd1f5413-7dff-4fda-bd70-135b3f12f91a" });
        }
    }
}
