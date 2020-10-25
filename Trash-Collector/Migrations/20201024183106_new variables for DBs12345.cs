using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class newvariablesforDBs12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PickupDay",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5cf5499-c830-4161-905b-03a4bc9ddaec", "cf56f083-452b-47e0-afb5-92103cca075e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a21a5ffa-8fc7-47de-b2b5-391fd210670a", "c23d28fe-0436-402e-bf12-592cac5de071", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a21a5ffa-8fc7-47de-b2b5-391fd210670a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cf5499-c830-4161-905b-03a4bc9ddaec");

            migrationBuilder.DropColumn(
                name: "PickupDay",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08dae996-577b-4dae-8cc8-70297fd0a878", "964ebff3-03bd-49f1-8944-36518b40c98e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d65eeb0b-ef8e-4dfd-a6e7-3b761c5ddd69", "db6b2a52-130c-40dc-94ba-7720940cfa95", "Employee", "EMPLOYEE" });
        }
    }
}
