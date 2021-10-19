using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DATA.Migrations
{
    public partial class datanexxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
    name: "CreatedDate",
    table: "Recipes",
    type: "datetime2",
    nullable: false,
    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
