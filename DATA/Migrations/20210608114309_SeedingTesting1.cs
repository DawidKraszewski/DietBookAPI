using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class SeedingTesting1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6df4b4dd-b67a-45b4-91db-9695fa86e8b9"));

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("fbad7650-6109-479d-b884-65b1e7f69aef"), "Dawid", "123", "Pea soup" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("cde386c6-2a90-4611-b6ac-e0fa35530370"), "Monika", "456", "Apple soup" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("cde386c6-2a90-4611-b6ac-e0fa35530370"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("fbad7650-6109-479d-b884-65b1e7f69aef"));

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("6df4b4dd-b67a-45b4-91db-9695fa86e8b9"), "Dawid", "123", "Pea soup" });
        }
    }
}
