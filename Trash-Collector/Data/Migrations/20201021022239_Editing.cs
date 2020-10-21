using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class Editing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "49591255-9694-43d9-9112-07bb3c660e0d", "9118645d-ef42-4e6d-9641-029359b4e107", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bf46bd3-8cc0-4fab-b1cd-4f7645376b60", "408dc359-e26f-4250-9672-e78b993063d2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63f1c971-14ba-4de9-a2ee-eb6c9666e34a", "1cd39e5e-9129-49eb-9bb3-743f57ca5482", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49591255-9694-43d9-9112-07bb3c660e0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63f1c971-14ba-4de9-a2ee-eb6c9666e34a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf46bd3-8cc0-4fab-b1cd-4f7645376b60");

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
    }
}
