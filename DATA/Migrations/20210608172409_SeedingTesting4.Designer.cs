﻿// <auto-generated />
using System;
using DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DATA.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20210608172409_SeedingTesting4")]
    partial class SeedingTesting4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATA.Models.IngredientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("316c4a37-b448-4a09-8546-061fee762dd3"),
                            Name = "chicken stock"
                        },
                        new
                        {
                            Id = new Guid("b610cf89-059c-40b7-9575-4ad0beae36ac"),
                            Name = "frozen peas"
                        },
                        new
                        {
                            Id = new Guid("60cc3129-b684-4630-b241-2b5310769d25"),
                            Name = "tarragon leaves"
                        },
                        new
                        {
                            Id = new Guid("20e18e18-1929-41d6-9f37-5153d35da057"),
                            Name = "salt"
                        },
                        new
                        {
                            Id = new Guid("7861b2f3-28ea-4c12-b782-7ce4b9428936"),
                            Name = "pancetta"
                        },
                        new
                        {
                            Id = new Guid("9df33c4d-cf43-4f85-8f78-b816e81681f7"),
                            Name = "vegetable oil"
                        },
                        new
                        {
                            Id = new Guid("2fdae9d1-eb03-4fa7-9455-d6c0984cfaad"),
                            Name = "soy sauce"
                        },
                        new
                        {
                            Id = new Guid("278c6bb2-e223-4d86-b059-f9e161a07639"),
                            Name = "honey"
                        },
                        new
                        {
                            Id = new Guid("b84ea6f7-d755-4c82-b982-98d0369b9cb2"),
                            Name = "cucumber"
                        },
                        new
                        {
                            Id = new Guid("727c590b-6709-4f80-8e45-cc2912076bd4"),
                            Name = "pepper"
                        },
                        new
                        {
                            Id = new Guid("a9e49970-5a2a-4c1a-894c-2047678d04ba"),
                            Name = "salt"
                        },
                        new
                        {
                            Id = new Guid("367be214-b3d8-42ca-9ef0-1ac8c3a47615"),
                            Name = "egg noodles"
                        },
                        new
                        {
                            Id = new Guid("91164cae-4de4-48ce-b1a5-91dd3700defd"),
                            Name = "black pepper"
                        },
                        new
                        {
                            Id = new Guid("f0c89f59-5368-4171-90e2-f59e91dea3b8"),
                            Name = "peanuts"
                        },
                        new
                        {
                            Id = new Guid("e9220e04-aab4-42a0-b627-031f910b8571"),
                            Name = "chilli flakes"
                        },
                        new
                        {
                            Id = new Guid("af1eb959-5785-4a0b-8deb-aa27c4f7acfb"),
                            Name = "egg white"
                        },
                        new
                        {
                            Id = new Guid("4a74718d-4226-4a7f-8b74-55b6f8f82cca"),
                            Name = "caster sugar"
                        },
                        new
                        {
                            Id = new Guid("889f3443-d79c-44a9-b0f6-a6deec7afee7"),
                            Name = "ground almonds"
                        },
                        new
                        {
                            Id = new Guid("7f30cb19-8705-415e-b050-e785837a8c46"),
                            Name = "amaretto liqueur"
                        },
                        new
                        {
                            Id = new Guid("f4256ced-9d60-4f9c-b3c1-21f334d6bba8"),
                            Name = "butter"
                        },
                        new
                        {
                            Id = new Guid("18402bcd-b00f-420c-af59-2ee261b7b9c7"),
                            Name = "egg"
                        },
                        new
                        {
                            Id = new Guid("488839ef-e848-4edc-bb4f-d491d3de1f3f"),
                            Name = "caster sugar"
                        },
                        new
                        {
                            Id = new Guid("1fd912b4-43d5-493f-b36a-492d6499918e"),
                            Name = "plain flour"
                        },
                        new
                        {
                            Id = new Guid("eb6fc2c3-88bb-462d-b446-5aaf300d8f41"),
                            Name = "lemon"
                        },
                        new
                        {
                            Id = new Guid("a37ed9c5-943f-4b13-a160-3549b237bf6c"),
                            Name = "baking powder"
                        },
                        new
                        {
                            Id = new Guid("5e2cfcbe-6433-4731-99af-dfd1a2a7bac0"),
                            Name = "butter"
                        });
                });

            modelBuilder.Entity("DATA.Models.RecipeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Steps")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"),
                            Author = "Nigel Slater",
                            Image = "https://imgur.com/2g8nS0W.jpg",
                            Name = "Pea soup with pancetta",
                            Steps = "Heat the chicken stock in a saucepan until it is simmering. Add the peas and simmer for 2 minutes, or until just tender. Stir in the tarragon and salt.\n Transfer the mixture to a food processor and blend for a few short blasts to a rough-textured soup. Return the soup to the saucepan and keep warm over a low heat.\n Using a pair of tongs, heat each slice of pancetta over the gas flame of your hob for a few seconds until it crisps up. (Alternatively, preheat your grill to its highest setting, lay the slices of pancetta onto a baking tray and grill for 1-2 minutes, or until crisp.)\n To serve, ladle the soup into bowls. Break the crisp pancetta into pieces and sprinkle on top of the soup."
                        },
                        new
                        {
                            Id = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Author = "Paul Rankin",
                            Image = "https://i.imgur.com/qvrXDy6.jpg",
                            Name = "Noodle salad with chilli nuts",
                            Steps = "For the noodle salad, put the vegetable oil, soy sauce and honey in a large bowl and mix well.\n Add the cucumber, pepper and cooked noodles, season with salt and pepper and mix well.\n For the chilli nuts, heat the vegetable oil in a frying pan over a medium heat and fry the peanuts for 3-4 minutes. Drain off the oil and fry for a further 2-3 minutes, then add the salt and chilli and stir well to coat the nuts.\n Put the noodle salad in a bowl, sprinkle over the nuts and serve."
                        },
                        new
                        {
                            Id = new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"),
                            Author = "Gino D'Acampo",
                            Image = "https://i.imgur.com/HtxaFZ1.jpg",
                            Name = "Amaretti biscuits",
                            Steps = "Preheat the oven to 170C/325F/Gas 3.\n In a large bowl beat the egg whites until firm. Mix the sugar and the almonds gently into it. Add the amaretto liquor and fold in gently until you have a smooth paste.\n Place some baking paper on a baking tray and lightly brush with butter. Using a teaspoon place small heaps of the mixture approximately 2cm/¾in apart, as they will expand while cooking. Bake for approximately 15 minutes until golden brown. Leave to cool slightly then serve or store in an air-tight container.\n "
                        },
                        new
                        {
                            Id = new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"),
                            Author = "Michel Roux Jr.",
                            Image = "https://i.imgur.com/cJSPnE1.jpg",
                            Name = "Madeleines",
                            Steps = "Preheat the oven to 200C/400F/Gas 6. Brush the madeleine tray with melted butter then shake in a little flour to coat, tapping out the excess.\n Whisk together the eggs and the sugar in a bowl until frothy. Lightly whisk in the remaining ingredients. Leave to stand for 20 minutes before carefully pouring into the prepared madeleine tray.\n Bake for 8-10 minutes, or until the mixture has risen a little in the middle and is fully cooked through. Transfer the madeleines to a wire rack and leave for a few minutes to cool slightly. These are best eaten within an hour of cooking.\n "
                        });
                });

            modelBuilder.Entity("DATA.Models.RecipeIngredientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IngredientEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Quantity")
                        .HasColumnType("float(8)");

                    b.Property<Guid>("RecipeEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IngredientEntityId");

                    b.HasIndex("RecipeEntityId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4edc93de-0f73-4d53-967d-92d8e7413b7b"),
                            IngredientEntityId = new Guid("316c4a37-b448-4a09-8546-061fee762dd3"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"),
                            Unit = "l"
                        },
                        new
                        {
                            Id = new Guid("97e80a86-8994-47cd-a736-4ecdf349b7fa"),
                            IngredientEntityId = new Guid("b610cf89-059c-40b7-9575-4ad0beae36ac"),
                            Quantity = 500f,
                            RecipeEntityId = new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("586763b7-4b06-4d38-9197-8fb3c3a99fe1"),
                            IngredientEntityId = new Guid("60cc3129-b684-4630-b241-2b5310769d25"),
                            Quantity = 10f,
                            RecipeEntityId = new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("0ef5894e-7956-4892-9176-3370d2c987ec"),
                            IngredientEntityId = new Guid("20e18e18-1929-41d6-9f37-5153d35da057"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"),
                            Unit = "pinch"
                        },
                        new
                        {
                            Id = new Guid("29fe14d2-a04b-4a4f-8e13-d1b119bcd7aa"),
                            IngredientEntityId = new Guid("7861b2f3-28ea-4c12-b782-7ce4b9428936"),
                            Quantity = 4f,
                            RecipeEntityId = new Guid("6a101225-f59e-4cf6-9a9e-b6019419a235"),
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("4d26bbae-d78f-4e4a-b351-36688a663093"),
                            IngredientEntityId = new Guid("9df33c4d-cf43-4f85-8f78-b816e81681f7"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("fc1ffc59-ba2a-419c-8d5d-fc9de749a0b0"),
                            IngredientEntityId = new Guid("2fdae9d1-eb03-4fa7-9455-d6c0984cfaad"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("9dd3cc0a-ffbb-4ac7-8939-ccc7ad2356cd"),
                            IngredientEntityId = new Guid("278c6bb2-e223-4d86-b059-f9e161a07639"),
                            Quantity = 2f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("51f7bc43-e93d-4cea-a481-19ad20fd5a23"),
                            IngredientEntityId = new Guid("b84ea6f7-d755-4c82-b982-98d0369b9cb2"),
                            Quantity = 0.25f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("da03ec0b-dc98-4f17-89fc-e0347214dcef"),
                            IngredientEntityId = new Guid("727c590b-6709-4f80-8e45-cc2912076bd4"),
                            Quantity = 0.25f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("841a6255-2839-45e9-8396-fe0a41cfa9da"),
                            IngredientEntityId = new Guid("a9e49970-5a2a-4c1a-894c-2047678d04ba"),
                            Quantity = 0.5f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("014aa62d-baea-4f36-ab01-ae368bc76643"),
                            IngredientEntityId = new Guid("367be214-b3d8-42ca-9ef0-1ac8c3a47615"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("639e5892-206f-4e58-9d49-3ec5a72cc751"),
                            IngredientEntityId = new Guid("91164cae-4de4-48ce-b1a5-91dd3700defd"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "pinch"
                        },
                        new
                        {
                            Id = new Guid("43dde5a5-7e0a-4d67-8b6b-e39a54e0ee75"),
                            IngredientEntityId = new Guid("9df33c4d-cf43-4f85-8f78-b816e81681f7"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("db969668-c41a-465b-8697-b1c4a31ced97"),
                            IngredientEntityId = new Guid("f0c89f59-5368-4171-90e2-f59e91dea3b8"),
                            Quantity = 50f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("867f2cb9-d8d3-461b-abb5-4a147f503aec"),
                            IngredientEntityId = new Guid("e9220e04-aab4-42a0-b627-031f910b8571"),
                            Quantity = 0.5f,
                            RecipeEntityId = new Guid("bcdcc8a4-c3c5-4ab3-be02-1ca6684d5455"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("99f8126c-5823-4c96-994d-e3b20afdeefd"),
                            IngredientEntityId = new Guid("af1eb959-5785-4a0b-8deb-aa27c4f7acfb"),
                            Quantity = 4f,
                            RecipeEntityId = new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("b6311938-0b58-4ae5-b4a4-a30738eeeb99"),
                            IngredientEntityId = new Guid("4a74718d-4226-4a7f-8b74-55b6f8f82cca"),
                            Quantity = 340f,
                            RecipeEntityId = new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("66021a59-ed1d-47e1-bef7-6567b8f87ff2"),
                            IngredientEntityId = new Guid("889f3443-d79c-44a9-b0f6-a6deec7afee7"),
                            Quantity = 340f,
                            RecipeEntityId = new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("720da553-4837-422b-83cf-74068b85f98e"),
                            IngredientEntityId = new Guid("7f30cb19-8705-415e-b050-e785837a8c46"),
                            Quantity = 30f,
                            RecipeEntityId = new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"),
                            Unit = "ml"
                        },
                        new
                        {
                            Id = new Guid("2f057f9f-f4b9-4428-90c2-f5317d00d2d5"),
                            IngredientEntityId = new Guid("f4256ced-9d60-4f9c-b3c1-21f334d6bba8"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("b4028318-fb72-455b-94c2-f50ee0c8a898"),
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("f954740d-4fb4-40c1-af24-d4cb7ce25d34"),
                            IngredientEntityId = new Guid("18402bcd-b00f-420c-af59-2ee261b7b9c7"),
                            Quantity = 2f,
                            RecipeEntityId = new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("10e0030c-e05b-42ae-bc20-ed4a40c0e7e4"),
                            IngredientEntityId = new Guid("488839ef-e848-4edc-bb4f-d491d3de1f3f"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("36fce62c-d21f-4e90-9661-eefb5bd9f22b"),
                            IngredientEntityId = new Guid("1fd912b4-43d5-493f-b36a-492d6499918e"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("875eabc8-36b8-4b3e-97f6-cf49f9070083"),
                            IngredientEntityId = new Guid("eb6fc2c3-88bb-462d-b446-5aaf300d8f41"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("db0bdb5b-5798-4fe7-9763-e16a03c621cf"),
                            IngredientEntityId = new Guid("a37ed9c5-943f-4b13-a160-3549b237bf6c"),
                            Quantity = 0.75f,
                            RecipeEntityId = new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("aaedbf89-5e71-4b4a-aaa6-59d7aa534cd6"),
                            IngredientEntityId = new Guid("5e2cfcbe-6433-4731-99af-dfd1a2a7bac0"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("c82506c8-e832-45d6-9e95-def767f5cb54"),
                            Unit = "g"
                        });
                });

            modelBuilder.Entity("DATA.Models.RecipeIngredientEntity", b =>
                {
                    b.HasOne("DATA.Models.IngredientEntity", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATA.Models.RecipeEntity", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("DATA.Models.IngredientEntity", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("DATA.Models.RecipeEntity", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
