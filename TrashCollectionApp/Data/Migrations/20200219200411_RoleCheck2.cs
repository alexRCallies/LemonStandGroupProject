using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionApp.Data.Migrations
{
    public partial class RoleCheck2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f2ffce9-caaf-4cfb-877a-c991ce468232");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ae7cb9-03e2-4188-b248-c65393edbaa6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be2b21ef-d881-4d25-8317-3a94c65f0e02");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7f2ffce9-caaf-4cfb-877a-c991ce468232", "d7634923-3743-4b36-9ea7-442c53d32312", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be2b21ef-d881-4d25-8317-3a94c65f0e02", "605974bc-01af-48c4-b5c1-e72b2aa900db", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83ae7cb9-03e2-4188-b248-c65393edbaa6", "868f7db1-e5c1-48c2-a9ae-a9395a6dbbfe", "Employee", "EMPLOYEE" });
        }
    }
}
