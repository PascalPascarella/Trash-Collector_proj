using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class customerpickuptostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PickupDay",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ad276ea-35c4-42d9-bcdd-591da0b8c4e6", "d9dde25c-aa31-4b33-a6a4-b97c315fdf48", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e64668da-536f-4571-9e53-70d4b2fc31a6", "b2b0535f-2d58-4834-a5c0-9a2f4ba77406", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0577252-53c3-413b-a2a0-c310f16ef9b6", "6c9db979-96f2-477c-92dc-3c1257c71dd7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ad276ea-35c4-42d9-bcdd-591da0b8c4e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0577252-53c3-413b-a2a0-c310f16ef9b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e64668da-536f-4571-9e53-70d4b2fc31a6");

            migrationBuilder.AlterColumn<int>(
                name: "PickupDay",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
