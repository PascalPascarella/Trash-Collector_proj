using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class AddressandEmployeeidamendment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd84639c-6404-4ea9-b54c-ab3d6fced999");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6037553f-9288-41b5-82d8-5d428a7114a8", "b0073a92-51bf-4201-8bcf-3733f58ba883", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6037553f-9288-41b5-82d8-5d428a7114a8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd84639c-6404-4ea9-b54c-ab3d6fced999", "67f8c5ef-0d8c-412e-b339-2b03811d0d54", "Admin", "ADMIN" });
        }
    }
}
