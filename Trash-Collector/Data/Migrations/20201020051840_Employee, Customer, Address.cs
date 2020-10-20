using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class EmployeeCustomerAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "784dd107-5843-4ee8-a4fd-78a862c91824");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd84639c-6404-4ea9-b54c-ab3d6fced999", "67f8c5ef-0d8c-412e-b339-2b03811d0d54", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd84639c-6404-4ea9-b54c-ab3d6fced999");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "784dd107-5843-4ee8-a4fd-78a862c91824", "d057c2d9-1e48-4d3e-a694-ae8c65601f2e", "Admin", "ADMIN" });
        }
    }
}
