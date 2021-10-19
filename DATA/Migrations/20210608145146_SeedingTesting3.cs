using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class SeedingTesting3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Steps",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c970ddcf-f8a9-464b-9f40-def0e90c54ef"), "chicken stock" },
                    { new Guid("3ac50384-f899-4914-bde1-0f0cbf2e0ab7"), "frozen peas" },
                    { new Guid("ce13268c-1055-4034-ac93-d7ab93c39067"), "tarragon leaves" },
                    { new Guid("6468a759-b665-4898-b5be-7b4891c43d0a"), "salt" },
                    { new Guid("90070866-d8da-4761-ae22-4dfbd2a979c6"), "pancetta" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name", "Steps" },
                values: new object[] { new Guid("ed24b476-1bc6-4bce-9fb6-25a08c6fa629"), "Nigel Slater", "https://imgur.com/2g8nS0W", "Pea soup with pancetta", "Heat the chicken stock in a saucepan until it is simmering. Add the peas and simmer for 2 minutes, or until just tender. Stir in the tarragon and salt.\n Transfer the mixture to a food processor and blend for a few short blasts to a rough-textured soup. Return the soup to the saucepan and keep warm over a low heat.\n Using a pair of tongs, heat each slice of pancetta over the gas flame of your hob for a few seconds until it crisps up. (Alternatively, preheat your grill to its highest setting, lay the slices of pancetta onto a baking tray and grill for 1-2 minutes, or until crisp.)\n To serve, ladle the soup into bowls. Break the crisp pancetta into pieces and sprinkle on top of the soup." });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientEntityId", "Quantity", "RecipeEntityId", "Unit" },
                values: new object[,]
                {
                    { new Guid("0737ad1e-7c67-468f-b56b-99c82c8757e5"), new Guid("c970ddcf-f8a9-464b-9f40-def0e90c54ef"), 0f, new Guid("ed24b476-1bc6-4bce-9fb6-25a08c6fa629"), null },
                    { new Guid("b9fda1ed-82a3-41a4-83f1-7a39513f8c62"), new Guid("3ac50384-f899-4914-bde1-0f0cbf2e0ab7"), 0f, new Guid("ed24b476-1bc6-4bce-9fb6-25a08c6fa629"), null },
                    { new Guid("0597362b-c29c-4851-b554-4d11f0f72ed2"), new Guid("ce13268c-1055-4034-ac93-d7ab93c39067"), 0f, new Guid("ed24b476-1bc6-4bce-9fb6-25a08c6fa629"), null },
                    { new Guid("ea884ee6-eab3-4bcb-97a0-ce4de2415a3d"), new Guid("6468a759-b665-4898-b5be-7b4891c43d0a"), 0f, new Guid("ed24b476-1bc6-4bce-9fb6-25a08c6fa629"), null },
                    { new Guid("5da5316b-6976-4df0-9666-3ab022b00d6f"), new Guid("90070866-d8da-4761-ae22-4dfbd2a979c6"), 0f, new Guid("ed24b476-1bc6-4bce-9fb6-25a08c6fa629"), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("0597362b-c29c-4851-b554-4d11f0f72ed2"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("0737ad1e-7c67-468f-b56b-99c82c8757e5"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("5da5316b-6976-4df0-9666-3ab022b00d6f"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("b9fda1ed-82a3-41a4-83f1-7a39513f8c62"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("ea884ee6-eab3-4bcb-97a0-ce4de2415a3d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3ac50384-f899-4914-bde1-0f0cbf2e0ab7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6468a759-b665-4898-b5be-7b4891c43d0a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("90070866-d8da-4761-ae22-4dfbd2a979c6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c970ddcf-f8a9-464b-9f40-def0e90c54ef"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ce13268c-1055-4034-ac93-d7ab93c39067"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("ed24b476-1bc6-4bce-9fb6-25a08c6fa629"));

            migrationBuilder.DropColumn(
                name: "Steps",
                table: "Recipes");

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
    }
}
