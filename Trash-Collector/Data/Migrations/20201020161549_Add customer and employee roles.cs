using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class Addcustomerandemployeeroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b71daa8-147a-47e5-8687-ba00d73428a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10146156-1844-4701-b32c-8712a9730548", "5218cc15-1eec-41f5-88a5-1a026f76dc8d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93f6cdc8-f8b7-417b-a8ff-f2118e3a0b82", "4fddec01-30de-4a8d-a1da-ca5788b443b8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87fdc092-c8d1-4855-ab27-2bac9cf2b16a", "994c1bbe-dcdf-48bc-8e84-5ae8843ee2e3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10146156-1844-4701-b32c-8712a9730548");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87fdc092-c8d1-4855-ab27-2bac9cf2b16a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93f6cdc8-f8b7-417b-a8ff-f2118e3a0b82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b71daa8-147a-47e5-8687-ba00d73428a5", "b77d84d0-37c0-41a4-bfcc-f0489a440ed9", "Admin", "ADMIN" });
        }
    }
}
