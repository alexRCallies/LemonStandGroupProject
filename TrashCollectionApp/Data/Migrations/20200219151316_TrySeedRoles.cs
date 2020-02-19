using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionApp.Data.Migrations
{
    public partial class TrySeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c947fa2e-f7ea-4e07-b014-3bd61b12a4bb");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c947fa2e-f7ea-4e07-b014-3bd61b12a4bb", "15d3d6f9-54e8-40ce-8d5a-f6c71e8d7e5b", "Admin", "ADMIN" });
        }
    }
}
