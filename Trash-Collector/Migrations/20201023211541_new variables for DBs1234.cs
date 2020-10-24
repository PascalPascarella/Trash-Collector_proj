using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class newvariablesforDBs1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "015b50f2-9816-4991-b880-9e7db05083fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93d6dfe7-e0b7-401f-a05d-aaaca1f8ed39");

            migrationBuilder.DropColumn(
                name: "ZipTemporary",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ZipTemporary",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08dae996-577b-4dae-8cc8-70297fd0a878", "964ebff3-03bd-49f1-8944-36518b40c98e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d65eeb0b-ef8e-4dfd-a6e7-3b761c5ddd69", "db6b2a52-130c-40dc-94ba-7720940cfa95", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08dae996-577b-4dae-8cc8-70297fd0a878");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d65eeb0b-ef8e-4dfd-a6e7-3b761c5ddd69");

            migrationBuilder.AddColumn<int>(
                name: "ZipTemporary",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZipTemporary",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93d6dfe7-e0b7-401f-a05d-aaaca1f8ed39", "4c08b5f2-4fa6-41dc-8b80-019050cad01b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "015b50f2-9816-4991-b880-9e7db05083fb", "f35a5436-8ed3-4bcb-b55e-87d66151a908", "Employee", "EMPLOYEE" });
        }
    }
}
