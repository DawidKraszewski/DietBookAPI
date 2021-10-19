using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class SeedingTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("6df4b4dd-b67a-45b4-91db-9695fa86e8b9"), "Dawid", "123", "Pea soup" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6df4b4dd-b67a-45b4-91db-9695fa86e8b9"));
        }
    }
}
