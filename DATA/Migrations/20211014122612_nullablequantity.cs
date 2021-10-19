using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class nullablequantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "CreatedOn",
            //    table: "Recipes");

            migrationBuilder.AlterColumn<float>(
                name: "Quantity",
                table: "RecipeIngredients",
                type: "float(8)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "float(8)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<float>(
                name: "Quantity",
                table: "RecipeIngredients",
                type: "float(8)",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "float(8)",
                oldNullable: true);
        }
    }
}
