using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class newvariablesforDBs123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5271f7f3-8595-4cd5-bb91-91c356b5b98b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a101f30-d6d4-40ba-b48f-0941a764e0e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93d6dfe7-e0b7-401f-a05d-aaaca1f8ed39", "4c08b5f2-4fa6-41dc-8b80-019050cad01b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "015b50f2-9816-4991-b880-9e7db05083fb", "f35a5436-8ed3-4bcb-b55e-87d66151a908", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "015b50f2-9816-4991-b880-9e7db05083fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93d6dfe7-e0b7-401f-a05d-aaaca1f8ed39");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a101f30-d6d4-40ba-b48f-0941a764e0e4", "d87fbe69-5c2b-404e-8d00-538752456d32", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5271f7f3-8595-4cd5-bb91-91c356b5b98b", "2e92ba95-3b4f-40c6-acda-95e6de943407", "Employee", "EMPLOYEE" });
        }
    }
}
