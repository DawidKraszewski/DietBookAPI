using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class SeedingTesting4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("316c4a37-b448-4a09-8546-061fee762dd3"), "chicken stock" },
                    { new Guid("5e2cfcbe-6433-4731-99af-dfd1a2a7bac0"), "butter" },
                    { new Guid("a37ed9c5-943f-4b13-a160-3549b237bf6c"), "baking powder" },
                    { new Guid("eb6fc2c3-88bb-462d-b446-5aaf300d8f41"), "lemon" },
                    { new Guid("1fd912b4-43d5-493f-b36a-492d6499918e"), "plain flour" },
                    { new Guid("488839ef-e848-4edc-bb4f-d491d3de1f3f"), "caster sugar" },
                    { new Guid("18402bcd-b00f-420c-af59-2ee261b7b9c7"), "egg" },
                    { new Guid("f4256ced-9d60-4f9c-b3c1-21f334d6bba8"), "butter" },
                    { new Guid("7f30cb19-8705-415e-b050-e785837a8c46"), "amaretto liqueur" },
                    { new Guid("889f3443-d79c-44a9-b0f6-a6deec7afee7"), "ground almonds" },
                    { new Guid("4a74718d-4226-4a7f-8b74-55b6f8f82cca"), "caster sugar" },
                    { new Guid("af1eb959-5785-4a0b-8deb-aa27c4f7acfb"), "egg white" },
                    { new Guid("f0c89f59-5368-4171-90e2-f59e91dea3b8"), "peanuts" },
                    { new Guid("e9220e04-aab4-42a0-b627-031f910b8571"), "chilli flakes" },
                    { new Guid("367be214-b3d8-42ca-9ef0-1ac8c3a47615"), "egg noodles" },
                    { new Guid("a9e49970-5a2a-4c1a-894c-2047678d04ba"), "salt" },
                    { new Guid("727c590b-6709-4f80-8e45-cc2912076bd4"), "pepper" },
                    { new Guid("b84ea6f7-d755-4c82-b982-98d0369b9cb2"), "cucumber" },
                    { new Guid("278c6bb2-e223-4d86-b059-f9e161a07639"), "honey" },
                    { new Guid("2fdae9d1-eb03-4fa7-9455-d6c0984cfaad"), "soy sauce" },
                    { new Guid("9df33c4d-cf43-4f85-8f78-b816e81681f7"), "vegetable oil" },
                    { new Guid("7861b2f3-28ea-4c12-b782-7ce4b9428936"), "pancetta" },
                    { new Guid("20e18e18-1929-41d6-9f37-5153d35da057"), "salt" },
                    { new Guid("60cc3129-b684-4630-b241-2b5310769d25"), "tarragon leaves" },
                    { new Guid("b610cf89-059c-40b7-9575-4ad0beae36ac"), "frozen peas" },
                    { new Guid("91164cae-4de4-48ce-b1a5-91dd3700defd"), "black pepper" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Author", "Image", "Name", "Steps" },
                values: new object[,]
                {
                    { new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"), "Gino D'Acampo", "https://i.imgur.com/HtxaFZ1.jpg", "Amaretti biscuits", "Preheat the oven to 170C/325F/Gas 3.\n In a large bowl beat the egg whites until firm. Mix the sugar and the almonds gently into it. Add the amaretto liquor and fold in gently until you have a smooth paste.\n Place some baking paper on a baking tray and lightly brush with butter. Using a teaspoon place small heaps of the mixture approximately 2cm/¾in apart, as they will expand while cooking. Bake for approximately 15 minutes until golden brown. Leave to cool slightly then serve or store in an air-tight container.\n " },
                    { new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"), "Nigel Slater", "https://imgur.com/2g8nS0W.jpg", "Pea soup with pancetta", "Heat the chicken stock in a saucepan until it is simmering. Add the peas and simmer for 2 minutes, or until just tender. Stir in the tarragon and salt.\n Transfer the mixture to a food processor and blend for a few short blasts to a rough-textured soup. Return the soup to the saucepan and keep warm over a low heat.\n Using a pair of tongs, heat each slice of pancetta over the gas flame of your hob for a few seconds until it crisps up. (Alternatively, preheat your grill to its highest setting, lay the slices of pancetta onto a baking tray and grill for 1-2 minutes, or until crisp.)\n To serve, ladle the soup into bowls. Break the crisp pancetta into pieces and sprinkle on top of the soup." },
                    { new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "Paul Rankin", "https://i.imgur.com/qvrXDy6.jpg", "Noodle salad with chilli nuts", "For the noodle salad, put the vegetable oil, soy sauce and honey in a large bowl and mix well.\n Add the cucumber, pepper and cooked noodles, season with salt and pepper and mix well.\n For the chilli nuts, heat the vegetable oil in a frying pan over a medium heat and fry the peanuts for 3-4 minutes. Drain off the oil and fry for a further 2-3 minutes, then add the salt and chilli and stir well to coat the nuts.\n Put the noodle salad in a bowl, sprinkle over the nuts and serve." },
                    { new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"), "Michel Roux Jr.", "https://i.imgur.com/cJSPnE1.jpg", "Madeleines", "Preheat the oven to 200C/400F/Gas 6. Brush the madeleine tray with melted butter then shake in a little flour to coat, tapping out the excess.\n Whisk together the eggs and the sugar in a bowl until frothy. Lightly whisk in the remaining ingredients. Leave to stand for 20 minutes before carefully pouring into the prepared madeleine tray.\n Bake for 8-10 minutes, or until the mixture has risen a little in the middle and is fully cooked through. Transfer the madeleines to a wire rack and leave for a few minutes to cool slightly. These are best eaten within an hour of cooking.\n " }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "Id", "IngredientEntityId", "Quantity", "RecipeEntityId", "Unit" },
                values: new object[,]
                {
                    { new Guid("4edc93de-0f73-4d53-967d-92d8e7413b7b"), new Guid("316c4a37-b448-4a09-8546-061fee762dd3"), 1f, new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"), "l" },
                    { new Guid("875eabc8-36b8-4b3e-97f6-cf49f9070083"), new Guid("eb6fc2c3-88bb-462d-b446-5aaf300d8f41"), 1f, new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"), "" },
                    { new Guid("36fce62c-d21f-4e90-9661-eefb5bd9f22b"), new Guid("1fd912b4-43d5-493f-b36a-492d6499918e"), 100f, new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"), "g" },
                    { new Guid("10e0030c-e05b-42ae-bc20-ed4a40c0e7e4"), new Guid("488839ef-e848-4edc-bb4f-d491d3de1f3f"), 100f, new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"), "g" },
                    { new Guid("f954740d-4fb4-40c1-af24-d4cb7ce25d34"), new Guid("18402bcd-b00f-420c-af59-2ee261b7b9c7"), 2f, new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"), "" },
                    { new Guid("2f057f9f-f4b9-4428-90c2-f5317d00d2d5"), new Guid("f4256ced-9d60-4f9c-b3c1-21f334d6bba8"), 1f, new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"), "slice" },
                    { new Guid("720da553-4837-422b-83cf-74068b85f98e"), new Guid("7f30cb19-8705-415e-b050-e785837a8c46"), 30f, new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"), "ml" },
                    { new Guid("66021a59-ed1d-47e1-bef7-6567b8f87ff2"), new Guid("889f3443-d79c-44a9-b0f6-a6deec7afee7"), 340f, new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"), "g" },
                    { new Guid("b6311938-0b58-4ae5-b4a4-a30738eeeb99"), new Guid("4a74718d-4226-4a7f-8b74-55b6f8f82cca"), 340f, new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"), "g" },
                    { new Guid("99f8126c-5823-4c96-994d-e3b20afdeefd"), new Guid("af1eb959-5785-4a0b-8deb-aa27c4f7acfb"), 4f, new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"), "" },
                    { new Guid("867f2cb9-d8d3-461b-abb5-4a147f503aec"), new Guid("e9220e04-aab4-42a0-b627-031f910b8571"), 0.5f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "tsp" },
                    { new Guid("db969668-c41a-465b-8697-b1c4a31ced97"), new Guid("f0c89f59-5368-4171-90e2-f59e91dea3b8"), 50f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "g" },
                    { new Guid("db0bdb5b-5798-4fe7-9763-e16a03c621cf"), new Guid("a37ed9c5-943f-4b13-a160-3549b237bf6c"), 0.75f, new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"), "tsp" },
                    { new Guid("43dde5a5-7e0a-4d67-8b6b-e39a54e0ee75"), new Guid("9df33c4d-cf43-4f85-8f78-b816e81681f7"), 1f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "tsp" },
                    { new Guid("014aa62d-baea-4f36-ab01-ae368bc76643"), new Guid("367be214-b3d8-42ca-9ef0-1ac8c3a47615"), 100f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "g" },
                    { new Guid("841a6255-2839-45e9-8396-fe0a41cfa9da"), new Guid("a9e49970-5a2a-4c1a-894c-2047678d04ba"), 0.5f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "tsp" },
                    { new Guid("da03ec0b-dc98-4f17-89fc-e0347214dcef"), new Guid("727c590b-6709-4f80-8e45-cc2912076bd4"), 0.25f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "" },
                    { new Guid("51f7bc43-e93d-4cea-a481-19ad20fd5a23"), new Guid("b84ea6f7-d755-4c82-b982-98d0369b9cb2"), 0.25f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "" },
                    { new Guid("9dd3cc0a-ffbb-4ac7-8939-ccc7ad2356cd"), new Guid("278c6bb2-e223-4d86-b059-f9e161a07639"), 2f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "tsp" },
                    { new Guid("fc1ffc59-ba2a-419c-8d5d-fc9de749a0b0"), new Guid("2fdae9d1-eb03-4fa7-9455-d6c0984cfaad"), 1f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "tsp" },
                    { new Guid("4d26bbae-d78f-4e4a-b351-36688a663093"), new Guid("9df33c4d-cf43-4f85-8f78-b816e81681f7"), 1f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "tsp" },
                    { new Guid("29fe14d2-a04b-4a4f-8e13-d1b119bcd7aa"), new Guid("7861b2f3-28ea-4c12-b782-7ce4b9428936"), 4f, new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"), "slice" },
                    { new Guid("0ef5894e-7956-4892-9176-3370d2c987ec"), new Guid("20e18e18-1929-41d6-9f37-5153d35da057"), 1f, new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"), "pinch" },
                    { new Guid("586763b7-4b06-4d38-9197-8fb3c3a99fe1"), new Guid("60cc3129-b684-4630-b241-2b5310769d25"), 10f, new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"), "g" },
                    { new Guid("97e80a86-8994-47cd-a736-4ecdf349b7fa"), new Guid("b610cf89-059c-40b7-9575-4ad0beae36ac"), 500f, new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"), "g" },
                    { new Guid("639e5892-206f-4e58-9d49-3ec5a72cc751"), new Guid("91164cae-4de4-48ce-b1a5-91dd3700defd"), 1f, new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"), "pinch" },
                    { new Guid("aaedbf89-5e71-4b4a-aaa6-59d7aa534cd6"), new Guid("5e2cfcbe-6433-4731-99af-dfd1a2a7bac0"), 100f, new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"), "g" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("014aa62d-baea-4f36-ab01-ae368bc76643"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("0ef5894e-7956-4892-9176-3370d2c987ec"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("10e0030c-e05b-42ae-bc20-ed4a40c0e7e4"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("29fe14d2-a04b-4a4f-8e13-d1b119bcd7aa"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("2f057f9f-f4b9-4428-90c2-f5317d00d2d5"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("36fce62c-d21f-4e90-9661-eefb5bd9f22b"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("43dde5a5-7e0a-4d67-8b6b-e39a54e0ee75"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("4d26bbae-d78f-4e4a-b351-36688a663093"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("4edc93de-0f73-4d53-967d-92d8e7413b7b"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("51f7bc43-e93d-4cea-a481-19ad20fd5a23"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("586763b7-4b06-4d38-9197-8fb3c3a99fe1"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("639e5892-206f-4e58-9d49-3ec5a72cc751"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("66021a59-ed1d-47e1-bef7-6567b8f87ff2"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("720da553-4837-422b-83cf-74068b85f98e"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("841a6255-2839-45e9-8396-fe0a41cfa9da"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("867f2cb9-d8d3-461b-abb5-4a147f503aec"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("875eabc8-36b8-4b3e-97f6-cf49f9070083"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("97e80a86-8994-47cd-a736-4ecdf349b7fa"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("99f8126c-5823-4c96-994d-e3b20afdeefd"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("9dd3cc0a-ffbb-4ac7-8939-ccc7ad2356cd"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("aaedbf89-5e71-4b4a-aaa6-59d7aa534cd6"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("b6311938-0b58-4ae5-b4a4-a30738eeeb99"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("da03ec0b-dc98-4f17-89fc-e0347214dcef"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("db0bdb5b-5798-4fe7-9763-e16a03c621cf"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("db969668-c41a-465b-8697-b1c4a31ced97"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("f954740d-4fb4-40c1-af24-d4cb7ce25d34"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumn: "Id",
                keyValue: new Guid("fc1ffc59-ba2a-419c-8d5d-fc9de749a0b0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("18402bcd-b00f-420c-af59-2ee261b7b9c7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1fd912b4-43d5-493f-b36a-492d6499918e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("20e18e18-1929-41d6-9f37-5153d35da057"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("278c6bb2-e223-4d86-b059-f9e161a07639"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2fdae9d1-eb03-4fa7-9455-d6c0984cfaad"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("316c4a37-b448-4a09-8546-061fee762dd3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("367be214-b3d8-42ca-9ef0-1ac8c3a47615"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("488839ef-e848-4edc-bb4f-d491d3de1f3f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("4a74718d-4226-4a7f-8b74-55b6f8f82cca"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5e2cfcbe-6433-4731-99af-dfd1a2a7bac0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("60cc3129-b684-4630-b241-2b5310769d25"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("727c590b-6709-4f80-8e45-cc2912076bd4"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7861b2f3-28ea-4c12-b782-7ce4b9428936"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7f30cb19-8705-415e-b050-e785837a8c46"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("889f3443-d79c-44a9-b0f6-a6deec7afee7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("91164cae-4de4-48ce-b1a5-91dd3700defd"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9df33c4d-cf43-4f85-8f78-b816e81681f7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a37ed9c5-943f-4b13-a160-3549b237bf6c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a9e49970-5a2a-4c1a-894c-2047678d04ba"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("af1eb959-5785-4a0b-8deb-aa27c4f7acfb"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b610cf89-059c-40b7-9575-4ad0beae36ac"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b84ea6f7-d755-4c82-b982-98d0369b9cb2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e9220e04-aab4-42a0-b627-031f910b8571"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("eb6fc2c3-88bb-462d-b446-5aaf300d8f41"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f0c89f59-5368-4171-90e2-f59e91dea3b8"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f4256ced-9d60-4f9c-b3c1-21f334d6bba8"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"));

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"));

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
    }
}
