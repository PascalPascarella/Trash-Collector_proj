using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aed1de73-9246-4bd1-bb70-7f8dedbec376", "3da1da79-df7f-4703-9d8e-5a12f26965a1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2824d1b5-7622-497c-984c-5ba57905e309", "f5df440e-e9a9-4fd9-957f-8c3cdda98303", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77bed792-5430-4917-aee2-11fdd07aee42", "87968d4a-8776-44c2-9bd4-fe8f085c6112", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2824d1b5-7622-497c-984c-5ba57905e309");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77bed792-5430-4917-aee2-11fdd07aee42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed1de73-9246-4bd1-bb70-7f8dedbec376");

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
    }
}
