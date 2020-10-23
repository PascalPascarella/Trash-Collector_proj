using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class FKtodb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6d64f51-cd28-4bfb-a0a6-f10f4ab18c86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e48501d0-b27b-46cf-9e08-f75e5dd04dd2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "658280b1-cfd4-4f9d-b699-5bb8180d57ae", "f7c134b3-3a6a-4a20-8fdd-1be86eb64b1d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc9f5d8a-3a5f-47f0-83f5-446c61963d25", "7a52c55e-6097-41c5-be9a-f1529dd5dd79", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "658280b1-cfd4-4f9d-b699-5bb8180d57ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc9f5d8a-3a5f-47f0-83f5-446c61963d25");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e48501d0-b27b-46cf-9e08-f75e5dd04dd2", "92716827-0e94-4958-96a8-fb9cd8b39210", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6d64f51-cd28-4bfb-a0a6-f10f4ab18c86", "137df730-410e-4563-91cc-2658dee4ca16", "Employee", "EMPLOYEE" });
        }
    }
}
