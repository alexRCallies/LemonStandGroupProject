using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionApp.Data.Migrations
{
    public partial class RoleCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "428249ce-1839-439c-ae14-381a0e66cb7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71630625-7ec9-4e37-a506-4ca27471fbfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7451e95-a3aa-482a-89cd-ab449fa1cbee");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Admin",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_employees_IdentityUserId",
                table: "employees",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_IdentityUserId",
                table: "customers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_IdentityUserId",
                table: "Admin",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_AspNetUsers_IdentityUserId",
                table: "Admin",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_AspNetUsers_IdentityUserId",
                table: "customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_AspNetUsers_IdentityUserId",
                table: "employees",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_AspNetUsers_IdentityUserId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_AspNetUsers_IdentityUserId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_AspNetUsers_IdentityUserId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_IdentityUserId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_customers_IdentityUserId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_Admin_IdentityUserId",
                table: "Admin");

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

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Admin");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "428249ce-1839-439c-ae14-381a0e66cb7b", "9937f0e5-8fc8-4b8f-b560-9c1fd8a1ba9e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7451e95-a3aa-482a-89cd-ab449fa1cbee", "2c7410c7-4b73-465e-ba75-89da116d8f50", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71630625-7ec9-4e37-a506-4ca27471fbfa", "5372bec2-89df-46dc-ba48-492d8f45cf61", "Employee", "EMPLOYEE" });
        }
    }
}
