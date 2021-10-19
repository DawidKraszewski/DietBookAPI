using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class SeedingTesting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("cde386c6-2a90-4611-b6ac-e0fa35530370"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("fbad7650-6109-479d-b884-65b1e7f69aef"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RecipeIngredients");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3815b291-f905-4233-81e2-72059e9d9f63"), "Pea" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("d4092da7-518c-4214-b6f3-2057fd690f0f"), "Dawid", "123", "Pea soup" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("3b9ac08b-e990-4751-9505-a56c347c776b"), "Monika", "456", "Apple soup" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3815b291-f905-4233-81e2-72059e9d9f63"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3b9ac08b-e990-4751-9505-a56c347c776b"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("d4092da7-518c-4214-b6f3-2057fd690f0f"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RecipeIngredients",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("fbad7650-6109-479d-b884-65b1e7f69aef"), "Dawid", "123", "Pea soup" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name" },
                values: new object[] { new Guid("cde386c6-2a90-4611-b6ac-e0fa35530370"), "Monika", "456", "Apple soup" });
        }
    }
}
