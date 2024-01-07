using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ChangingPasswordForAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fb79bf0-82b4-41a3-bf55-74f43e150dc3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fbf286f3-355a-406d-b107-2bcbaab2139a", "d515222e-12a0-4dcd-8871-a39f4df1f098" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbf286f3-355a-406d-b107-2bcbaab2139a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d515222e-12a0-4dcd-8871-a39f4df1f098");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2fb79bf0-82b4-41a3-bf55-74f43e150dc3", "9c695dd1-d54f-42a7-ba2b-44c1222a4b25", "Normal", "NORMAL" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbf286f3-355a-406d-b107-2bcbaab2139a", "a5d3fe2e-816b-48b6-9615-91070091df65", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassportNumber", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d515222e-12a0-4dcd-8871-a39f4df1f098", 0, "51e93285-51b2-4800-993e-a04615045079", "admin@email.com", false, false, null, null, "ADMIN", "", "AQAAAAEAACcQAAAAEJhi7VFnYQws6f/9IXYe2//s2GWawzgIkIe/1+yBRxMVbkl+1gdkEf5bY/Q4nIHUtw==", null, false, "c9beaca3-6746-4f8f-9661-0da77ad70af2", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fbf286f3-355a-406d-b107-2bcbaab2139a", "d515222e-12a0-4dcd-8871-a39f4df1f098" });
        }
    }
}
