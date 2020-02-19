using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionApp.Data.Migrations
{
    public partial class RoleCheck3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2505ff0b-d14a-4a30-9b61-96b9b38c6914");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42419994-4fb9-4723-be5d-e854cc329fc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f215ea6-d483-4792-9406-e0c63732ebac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7656c12-b3d8-4ae6-a1ce-16168550e661", "4bbecd42-91e9-4e8c-bcf3-c3f63130bec0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2c58362-bf57-4985-8425-9723471fd946", "62adc3ca-2c6d-4c25-92a8-c8ef50c3aa2b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04b86354-42bb-4b97-9e38-4a76f131d5b8", "a6370389-e11e-46b9-9547-376a8cd299f1", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04b86354-42bb-4b97-9e38-4a76f131d5b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c58362-bf57-4985-8425-9723471fd946");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7656c12-b3d8-4ae6-a1ce-16168550e661");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f215ea6-d483-4792-9406-e0c63732ebac", "2d4f24c5-c0a6-4606-895f-74f052300ce2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2505ff0b-d14a-4a30-9b61-96b9b38c6914", "d9ffcc31-b029-4e08-910b-194e4361424a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42419994-4fb9-4723-be5d-e854cc329fc8", "6851dd19-6637-4ae6-a309-d09eed67d4c8", "Employee", "EMPLOYEE" });
        }
    }
}
