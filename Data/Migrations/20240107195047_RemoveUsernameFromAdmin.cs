using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class RemoveUsernameFromAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9758b49a-8ac0-4d4b-b614-eac7b2bcbc47");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c78d7c1f-2010-47c1-b990-61ed5b13c56d", "984689d7-c8c5-495e-85ef-9fac25f105f7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78d7c1f-2010-47c1-b990-61ed5b13c56d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "984689d7-c8c5-495e-85ef-9fac25f105f7");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9758b49a-8ac0-4d4b-b614-eac7b2bcbc47", "512c378c-c3c1-4b0b-baaf-232a70905269", "Normal", "NORMAL" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c78d7c1f-2010-47c1-b990-61ed5b13c56d", "c24c4ee6-09ff-4a74-a735-20785c59594e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassportNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "984689d7-c8c5-495e-85ef-9fac25f105f7", 0, "a20788fa-1a2d-47a8-856c-f1a74a585640", "admin@email.com", false, false, null, null, "ADMIN", "", "AQAAAAEAACcQAAAAEGvo3I1FqmrZk6ZlyB0BCknXCtnLO+IYaKBK62sLKgOrFK3vpVRw2+yt8urtm7y8kA==", null, false, "4591268a-dbc2-416a-be6b-b18d19c4fb59", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c78d7c1f-2010-47c1-b990-61ed5b13c56d", "984689d7-c8c5-495e-85ef-9fac25f105f7" });
        }
    }
}
