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
    [Migration("20210614082024_SeedingWithSymbols")]
    partial class SeedingWithSymbols
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
                            Id = new Guid("3a9f3a5c-baa5-422d-a9d9-17d90b6766d3"),
                            Name = "chicken stock"
                        },
                        new
                        {
                            Id = new Guid("7e9b801f-a065-4a17-aa5c-ed9ed0c10d6e"),
                            Name = "frozen peas"
                        },
                        new
                        {
                            Id = new Guid("646503dc-06f1-4f40-87d1-a0608885e913"),
                            Name = "tarragon leaves"
                        },
                        new
                        {
                            Id = new Guid("9b45ffa0-0349-4d7d-a586-1372c55f9568"),
                            Name = "salt"
                        },
                        new
                        {
                            Id = new Guid("07aca786-45da-46ac-b231-3a0d1ec611f1"),
                            Name = "pancetta"
                        },
                        new
                        {
                            Id = new Guid("32d979ce-fdd5-4aff-b93b-55e7ac020248"),
                            Name = "vegetable oil"
                        },
                        new
                        {
                            Id = new Guid("edd1a3a1-3d38-4295-b88b-14c41fbb88cf"),
                            Name = "soy sauce"
                        },
                        new
                        {
                            Id = new Guid("8292f4ba-8241-4fc7-ac68-f28236af762c"),
                            Name = "honey"
                        },
                        new
                        {
                            Id = new Guid("a8746363-b729-4e96-a9b4-ee769ff6fa19"),
                            Name = "cucumber"
                        },
                        new
                        {
                            Id = new Guid("b4d62cb7-3d42-4cc3-993f-11755dc7cb6c"),
                            Name = "pepper"
                        },
                        new
                        {
                            Id = new Guid("d16ae491-8610-474f-9191-ffd6d074660a"),
                            Name = "salt"
                        },
                        new
                        {
                            Id = new Guid("106f2561-425d-4c60-9e9e-9ee018223548"),
                            Name = "egg noodles"
                        },
                        new
                        {
                            Id = new Guid("d36da2cf-d238-4196-990b-58c28a6bd02a"),
                            Name = "black pepper"
                        },
                        new
                        {
                            Id = new Guid("0a8499bc-010b-43e0-8710-c713d29d01bf"),
                            Name = "peanuts"
                        },
                        new
                        {
                            Id = new Guid("2b1ec308-d15c-4d4f-b397-a0a8e48e3f5b"),
                            Name = "chilli flakes"
                        },
                        new
                        {
                            Id = new Guid("2ab1ad8f-e431-4d66-89ab-4232b081bfc4"),
                            Name = "egg white"
                        },
                        new
                        {
                            Id = new Guid("2982685d-d3e5-40d4-902f-6642109a46c7"),
                            Name = "caster sugar"
                        },
                        new
                        {
                            Id = new Guid("9f642f0e-4e45-436e-93ba-76352cc0821a"),
                            Name = "ground almonds"
                        },
                        new
                        {
                            Id = new Guid("c0956806-61ea-4387-aeeb-5c13b4e32e77"),
                            Name = "amaretto liqueur"
                        },
                        new
                        {
                            Id = new Guid("4ead7340-9080-4d8f-908c-c0469f73fb50"),
                            Name = "butter"
                        },
                        new
                        {
                            Id = new Guid("c3ae7682-6a55-4bcc-abdc-c8736726a35d"),
                            Name = "egg"
                        },
                        new
                        {
                            Id = new Guid("c674fa38-d5be-44f4-ace7-f99721235a73"),
                            Name = "caster sugar"
                        },
                        new
                        {
                            Id = new Guid("414df428-a099-4034-a667-4cdb27a735a8"),
                            Name = "plain flour"
                        },
                        new
                        {
                            Id = new Guid("425615ff-d048-4595-b3a2-168382a29051"),
                            Name = "lemon"
                        },
                        new
                        {
                            Id = new Guid("43572815-71ff-4ba8-b5b2-3d564e4fe129"),
                            Name = "baking powder"
                        },
                        new
                        {
                            Id = new Guid("e21b260a-f289-47d1-ac43-e1b484b812c2"),
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
                            Id = new Guid("23ee3bd1-9768-4e92-a409-3361b66d90e9"),
                            Author = "Nigel Slater",
                            Image = "https://imgur.com/2g8nS0W.jpg",
                            Name = "Pea soup with pancetta",
                            Steps = "Heat the chicken stock in a saucepan until it is simmering. Add the peas and simmer for 2 minutes, or until just tender. Stir in the tarragon and salt.## Transfer the mixture to a food processor and blend for a few short blasts to a rough-textured soup. Return the soup to the saucepan and keep warm over a low heat.## Using a pair of tongs, heat each slice of pancetta over the gas flame of your hob for a few seconds until it crisps up. (Alternatively, preheat your grill to its highest setting, lay the slices of pancetta onto a baking tray and grill for 1-2 minutes, or until crisp.)##To serve, ladle the soup into bowls. Break the crisp pancetta into pieces and sprinkle on top of the soup."
                        },
                        new
                        {
                            Id = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Author = "Paul Rankin",
                            Image = "https://i.imgur.com/qvrXDy6.jpg",
                            Name = "Noodle salad with chilli nuts",
                            Steps = "For the noodle salad, put the vegetable oil, soy sauce and honey in a large bowl and mix well.##Add the cucumber, pepper and cooked noodles, season with salt and pepper and mix well.##For the chilli nuts, heat the vegetable oil in a frying pan over a medium heat and fry the peanuts for 3-4 minutes. Drain off the oil and fry for a further 2-3 minutes, then add the salt and chilli and stir well to coat the nuts.##Put the noodle salad in a bowl, sprinkle over the nuts and serve."
                        },
                        new
                        {
                            Id = new Guid("959f6916-b755-44fb-a8c0-74adf54582f8"),
                            Author = "Gino D'Acampo",
                            Image = "https://i.imgur.com/HtxaFZ1.jpg",
                            Name = "Amaretti biscuits",
                            Steps = "Preheat the oven to 170C/325F/Gas 3.##In a large bowl beat the egg whites until firm. Mix the sugar and the almonds gently into it. Add the amaretto liquor and fold in gently until you have a smooth paste.##Place some baking paper on a baking tray and lightly brush with butter. Using a teaspoon place small heaps of the mixture approximately 2cm/¾in apart, as they will expand while cooking. Bake for approximately 15 minutes until golden brown. Leave to cool slightly then serve or store in an air-tight container.##"
                        },
                        new
                        {
                            Id = new Guid("441e962c-b271-43c8-8bd2-13a3ab52b169"),
                            Author = "Michel Roux Jr.",
                            Image = "https://i.imgur.com/cJSPnE1.jpg",
                            Name = "Madeleines",
                            Steps = "Preheat the oven to 200C/400F/Gas 6. Brush the madeleine tray with melted butter then shake in a little flour to coat, tapping out the excess.##Whisk together the eggs and the sugar in a bowl until frothy. Lightly whisk in the remaining ingredients. Leave to stand for 20 minutes before carefully pouring into the prepared madeleine tray.##Bake for 8-10 minutes, or until the mixture has risen a little in the middle and is fully cooked through. Transfer the madeleines to a wire rack and leave for a few minutes to cool slightly. These are best eaten within an hour of cooking.##"
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
                            Id = new Guid("ec9ba8f8-c39c-4906-a7e5-226a7ed47748"),
                            IngredientEntityId = new Guid("3a9f3a5c-baa5-422d-a9d9-17d90b6766d3"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("23ee3bd1-9768-4e92-a409-3361b66d90e9"),
                            Unit = "l"
                        },
                        new
                        {
                            Id = new Guid("3ccbbcf0-25b4-4e3a-9b04-de3a3d8ba109"),
                            IngredientEntityId = new Guid("7e9b801f-a065-4a17-aa5c-ed9ed0c10d6e"),
                            Quantity = 500f,
                            RecipeEntityId = new Guid("23ee3bd1-9768-4e92-a409-3361b66d90e9"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("1064d7c0-e541-47b6-99ec-b25481268c85"),
                            IngredientEntityId = new Guid("646503dc-06f1-4f40-87d1-a0608885e913"),
                            Quantity = 10f,
                            RecipeEntityId = new Guid("23ee3bd1-9768-4e92-a409-3361b66d90e9"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("126260dc-8584-4d06-8e0e-f75fec2268ad"),
                            IngredientEntityId = new Guid("9b45ffa0-0349-4d7d-a586-1372c55f9568"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("23ee3bd1-9768-4e92-a409-3361b66d90e9"),
                            Unit = "pinch"
                        },
                        new
                        {
                            Id = new Guid("cb8082c6-98cd-4ba3-a0a5-4a868f8b6c6b"),
                            IngredientEntityId = new Guid("07aca786-45da-46ac-b231-3a0d1ec611f1"),
                            Quantity = 4f,
                            RecipeEntityId = new Guid("23ee3bd1-9768-4e92-a409-3361b66d90e9"),
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("6fcf7d7e-41bb-4fa3-8f52-7840bdbab9c6"),
                            IngredientEntityId = new Guid("32d979ce-fdd5-4aff-b93b-55e7ac020248"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("e1cf8f0c-98dd-44d1-aff9-347c4a6e3670"),
                            IngredientEntityId = new Guid("edd1a3a1-3d38-4295-b88b-14c41fbb88cf"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("35849daf-3f9d-468d-96a9-e2bce993e56b"),
                            IngredientEntityId = new Guid("8292f4ba-8241-4fc7-ac68-f28236af762c"),
                            Quantity = 2f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("7d0a6956-8c29-4c7b-8af8-c7e96a4b4ac6"),
                            IngredientEntityId = new Guid("a8746363-b729-4e96-a9b4-ee769ff6fa19"),
                            Quantity = 0.25f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("d497303c-4490-4a44-b438-65292ed801e3"),
                            IngredientEntityId = new Guid("b4d62cb7-3d42-4cc3-993f-11755dc7cb6c"),
                            Quantity = 0.25f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("c7e2f519-c56a-426e-b0d1-967b70096a34"),
                            IngredientEntityId = new Guid("d16ae491-8610-474f-9191-ffd6d074660a"),
                            Quantity = 0.5f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("cf66f789-1f9b-4d20-9aed-530950536b17"),
                            IngredientEntityId = new Guid("106f2561-425d-4c60-9e9e-9ee018223548"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("b1566b34-f328-4486-bb63-160ad87717f4"),
                            IngredientEntityId = new Guid("d36da2cf-d238-4196-990b-58c28a6bd02a"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "pinch"
                        },
                        new
                        {
                            Id = new Guid("aac1d4e7-3f83-453d-9e99-c13a297eda63"),
                            IngredientEntityId = new Guid("32d979ce-fdd5-4aff-b93b-55e7ac020248"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("f92ca97f-3e6e-478e-bf87-a3fc5d4e4b56"),
                            IngredientEntityId = new Guid("0a8499bc-010b-43e0-8710-c713d29d01bf"),
                            Quantity = 50f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("622e10df-6c55-42ac-afad-25b1faab16bf"),
                            IngredientEntityId = new Guid("2b1ec308-d15c-4d4f-b397-a0a8e48e3f5b"),
                            Quantity = 0.5f,
                            RecipeEntityId = new Guid("528d2d5a-9e9a-48a6-ac37-04fceee6fd48"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("b4fa4783-dfaa-493b-b241-914d8663e534"),
                            IngredientEntityId = new Guid("2ab1ad8f-e431-4d66-89ab-4232b081bfc4"),
                            Quantity = 4f,
                            RecipeEntityId = new Guid("959f6916-b755-44fb-a8c0-74adf54582f8"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("43c0c89e-35c8-4e76-80d6-b212285945f5"),
                            IngredientEntityId = new Guid("2982685d-d3e5-40d4-902f-6642109a46c7"),
                            Quantity = 340f,
                            RecipeEntityId = new Guid("959f6916-b755-44fb-a8c0-74adf54582f8"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("38ba9a66-154f-442e-ba53-41e1d0698c0b"),
                            IngredientEntityId = new Guid("9f642f0e-4e45-436e-93ba-76352cc0821a"),
                            Quantity = 340f,
                            RecipeEntityId = new Guid("959f6916-b755-44fb-a8c0-74adf54582f8"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("ee684160-199d-4bbd-8110-3a000e024803"),
                            IngredientEntityId = new Guid("c0956806-61ea-4387-aeeb-5c13b4e32e77"),
                            Quantity = 30f,
                            RecipeEntityId = new Guid("959f6916-b755-44fb-a8c0-74adf54582f8"),
                            Unit = "ml"
                        },
                        new
                        {
                            Id = new Guid("427b9a0f-12c1-498d-89b9-2c2676d219c9"),
                            IngredientEntityId = new Guid("4ead7340-9080-4d8f-908c-c0469f73fb50"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("959f6916-b755-44fb-a8c0-74adf54582f8"),
                            Unit = "slice"
                        },
                        new
                        {
                            Id = new Guid("475f22cd-d47c-4c62-afce-920e5f58d6b1"),
                            IngredientEntityId = new Guid("c3ae7682-6a55-4bcc-abdc-c8736726a35d"),
                            Quantity = 2f,
                            RecipeEntityId = new Guid("441e962c-b271-43c8-8bd2-13a3ab52b169"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("9c6c6cad-2a0d-4408-af91-677b16150980"),
                            IngredientEntityId = new Guid("c674fa38-d5be-44f4-ace7-f99721235a73"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("441e962c-b271-43c8-8bd2-13a3ab52b169"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("6bede9c2-e275-4c7b-b9bc-d869e9615226"),
                            IngredientEntityId = new Guid("414df428-a099-4034-a667-4cdb27a735a8"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("441e962c-b271-43c8-8bd2-13a3ab52b169"),
                            Unit = "g"
                        },
                        new
                        {
                            Id = new Guid("43c8ac9e-79a9-4767-b176-1a58e0b93329"),
                            IngredientEntityId = new Guid("425615ff-d048-4595-b3a2-168382a29051"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("441e962c-b271-43c8-8bd2-13a3ab52b169"),
                            Unit = ""
                        },
                        new
                        {
                            Id = new Guid("725ee0a3-e19e-477b-b679-b9b8f8bf026b"),
                            IngredientEntityId = new Guid("43572815-71ff-4ba8-b5b2-3d564e4fe129"),
                            Quantity = 0.75f,
                            RecipeEntityId = new Guid("441e962c-b271-43c8-8bd2-13a3ab52b169"),
                            Unit = "tsp"
                        },
                        new
                        {
                            Id = new Guid("367d0876-0098-4e73-907e-eb0317248b35"),
                            IngredientEntityId = new Guid("e21b260a-f289-47d1-ac43-e1b484b812c2"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("441e962c-b271-43c8-8bd2-13a3ab52b169"),
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