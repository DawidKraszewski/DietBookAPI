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
    [Migration("20211006113531_deleteimages")]
    partial class deleteimages
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
                            Id = new Guid("1a946187-e024-4b0a-a6d3-1a14e0296dd3"),
                            Name = "chicken stock"
                        },
                        new
                        {
                            Id = new Guid("cd91fcd1-e2e1-4ff4-8ece-15a1200f45b6"),
                            Name = "frozen peas"
                        },
                        new
                        {
                            Id = new Guid("bf5ddd92-adc5-4d15-a761-6517be1f711f"),
                            Name = "tarragon leaves"
                        },
                        new
                        {
                            Id = new Guid("29b6472f-05e1-44fa-b9a7-36e76fb7b50e"),
                            Name = "salt"
                        },
                        new
                        {
                            Id = new Guid("6736f59c-3491-4765-ac0e-4b81f682c4b8"),
                            Name = "pancetta"
                        },
                        new
                        {
                            Id = new Guid("38fb63a8-3f50-41ea-a9b3-8f65b49af37d"),
                            Name = "vegetable oil"
                        },
                        new
                        {
                            Id = new Guid("48c17ab1-baa9-47a4-bb49-516b76395117"),
                            Name = "soy sauce"
                        },
                        new
                        {
                            Id = new Guid("d58fb518-f476-4711-8e48-63f47b6af88c"),
                            Name = "honey"
                        },
                        new
                        {
                            Id = new Guid("09ab1054-a558-4471-be74-db9865872822"),
                            Name = "cucumber"
                        },
                        new
                        {
                            Id = new Guid("7aa0f9d0-503e-47c5-a92e-4565e81be5da"),
                            Name = "pepper"
                        },
                        new
                        {
                            Id = new Guid("70c20e8d-32f6-4dc6-aa3e-ba259c8d25b0"),
                            Name = "salt"
                        },
                        new
                        {
                            Id = new Guid("1f83544a-7428-40ee-af8f-fd4f28be89d7"),
                            Name = "egg noodles"
                        },
                        new
                        {
                            Id = new Guid("33098acf-a9c5-4ee7-8047-f50782fc1e7e"),
                            Name = "black pepper"
                        },
                        new
                        {
                            Id = new Guid("3ff335b7-4e1d-4831-9f8b-8b09bca41921"),
                            Name = "peanuts"
                        },
                        new
                        {
                            Id = new Guid("896a24d6-e95d-4650-a3b3-bd9aa683b9c7"),
                            Name = "chilli flakes"
                        },
                        new
                        {
                            Id = new Guid("69ff199f-92f3-4b8d-ad58-e4b99a6abbbf"),
                            Name = "egg white"
                        },
                        new
                        {
                            Id = new Guid("9af752cc-5056-45e7-9651-da1a880848ad"),
                            Name = "caster sugar"
                        },
                        new
                        {
                            Id = new Guid("05c646db-e41c-42eb-b211-29ac9ac0fbf3"),
                            Name = "ground almonds"
                        },
                        new
                        {
                            Id = new Guid("0f3d56b2-36fb-41ec-b243-3d749459da7d"),
                            Name = "amaretto liqueur"
                        },
                        new
                        {
                            Id = new Guid("33444a0e-2a09-41b9-914a-9c230efb0bb0"),
                            Name = "butter"
                        },
                        new
                        {
                            Id = new Guid("e59c0e62-e595-4319-ac4b-eb93035ca204"),
                            Name = "egg"
                        },
                        new
                        {
                            Id = new Guid("1792fb22-66e8-4d5f-8f48-fd55007767fb"),
                            Name = "caster sugar"
                        },
                        new
                        {
                            Id = new Guid("28a90979-1888-4f92-b56e-33df57778d8e"),
                            Name = "plain flour"
                        },
                        new
                        {
                            Id = new Guid("839ac76d-609e-495c-b2d5-66dcd63b9ab0"),
                            Name = "lemon"
                        },
                        new
                        {
                            Id = new Guid("46fdfe5f-fc4e-4b05-91d5-bca7d7e24cfe"),
                            Name = "baking powder"
                        },
                        new
                        {
                            Id = new Guid("bd28c339-25b5-4f08-8d28-70bc61eafa9b"),
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

                    b.Property<string>("CreatedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Steps")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c41c111-da82-4614-bd84-2647d16b3aca"),
                            Author = "Nigel Slater",
                            Name = "Pea soup with pancetta",
                            Steps = "Heat the chicken stock in a saucepan until it is simmering. Add the peas and simmer for 2 minutes, or until just tender. Stir in the tarragon and salt.##Transfer the mixture to a food processor and blend for a few short blasts to a rough-textured soup. Return the soup to the saucepan and keep warm over a low heat.##Using a pair of tongs, heat each slice of pancetta over the gas flame of your hob for a few seconds until it crisps up. (Alternatively, preheat your grill to its highest setting, lay the slices of pancetta onto a baking tray and grill for 1-2 minutes, or until crisp).##To serve, ladle the soup into bowls. Break the crisp pancetta into pieces and sprinkle on top of the soup."
                        },
                        new
                        {
                            Id = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            Author = "Paul Rankin",
                            Name = "Noodle salad with chilli nuts",
                            Steps = "For the noodle salad, put the vegetable oil, soy sauce and honey in a large bowl and mix well.##Add the cucumber, pepper and cooked noodles, season with salt and pepper and mix well.##For the chilli nuts, heat the vegetable oil in a frying pan over a medium heat and fry the peanuts for 3-4 minutes. Drain off the oil and fry for a further 2-3 minutes, then add the salt and chilli and stir well to coat the nuts.##Put the noodle salad in a bowl, sprinkle over the nuts and serve."
                        },
                        new
                        {
                            Id = new Guid("a27b18cf-8cf3-4ab0-8d93-b333a02aedd8"),
                            Author = "Gino D'Acampo",
                            Name = "Amaretti biscuits",
                            Steps = "Preheat the oven to 170C/325F/Gas 3.##In a large bowl beat the egg whites until firm. Mix the sugar and the almonds gently into it. Add the amaretto liquor and fold in gently until you have a smooth paste.##Place some baking paper on a baking tray and lightly brush with butter. Using a teaspoon place small heaps of the mixture approximately 2cm/¾in apart, as they will expand while cooking. Bake for approximately 15 minutes until golden brown. Leave to cool slightly then serve or store in an air-tight container."
                        },
                        new
                        {
                            Id = new Guid("a4ead8fc-eb82-4f57-a10d-509ed90d5183"),
                            Author = "Michel Roux Jr.",
                            Name = "Madeleines",
                            Steps = "Preheat the oven to 200C/400F/Gas 6. Brush the madeleine tray with melted butter then shake in a little flour to coat, tapping out the excess.##Whisk together the eggs and the sugar in a bowl until frothy. Lightly whisk in the remaining ingredients. Leave to stand for 20 minutes before carefully pouring into the prepared madeleine tray.##Bake for 8-10 minutes, or until the mixture has risen a little in the middle and is fully cooked through. Transfer the madeleines to a wire rack and leave for a few minutes to cool slightly. These are best eaten within an hour of cooking."
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

                    b.Property<Guid>("UnitEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IngredientEntityId");

                    b.HasIndex("RecipeEntityId");

                    b.HasIndex("UnitEntityId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4fef9c8-725f-483a-aed1-640e27129c5f"),
                            IngredientEntityId = new Guid("1a946187-e024-4b0a-a6d3-1a14e0296dd3"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("6c41c111-da82-4614-bd84-2647d16b3aca"),
                            UnitEntityId = new Guid("e8417d95-d7e1-4982-9d80-609c84e415ef")
                        },
                        new
                        {
                            Id = new Guid("431fcb05-63e5-41c9-b188-1f299fd1669c"),
                            IngredientEntityId = new Guid("cd91fcd1-e2e1-4ff4-8ece-15a1200f45b6"),
                            Quantity = 500f,
                            RecipeEntityId = new Guid("6c41c111-da82-4614-bd84-2647d16b3aca"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("fc01c651-7e65-4713-b6a7-8e9c516b4f92"),
                            IngredientEntityId = new Guid("bf5ddd92-adc5-4d15-a761-6517be1f711f"),
                            Quantity = 10f,
                            RecipeEntityId = new Guid("6c41c111-da82-4614-bd84-2647d16b3aca"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("e8735db6-3ee5-4518-8b98-72eae30f0607"),
                            IngredientEntityId = new Guid("29b6472f-05e1-44fa-b9a7-36e76fb7b50e"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("6c41c111-da82-4614-bd84-2647d16b3aca"),
                            UnitEntityId = new Guid("24c4010d-dc64-4399-a3a1-80082e1716f6")
                        },
                        new
                        {
                            Id = new Guid("3ca9ca5e-98af-4d6d-8b00-d2f83f13518b"),
                            IngredientEntityId = new Guid("6736f59c-3491-4765-ac0e-4b81f682c4b8"),
                            Quantity = 4f,
                            RecipeEntityId = new Guid("6c41c111-da82-4614-bd84-2647d16b3aca"),
                            UnitEntityId = new Guid("9cd37a29-d3e8-4b6e-9249-7e559ebe2974")
                        },
                        new
                        {
                            Id = new Guid("8d124954-9409-426e-bc43-38acdd069653"),
                            IngredientEntityId = new Guid("38fb63a8-3f50-41ea-a9b3-8f65b49af37d"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f")
                        },
                        new
                        {
                            Id = new Guid("8b9031a5-e146-4363-b10c-4c57e6a68406"),
                            IngredientEntityId = new Guid("48c17ab1-baa9-47a4-bb49-516b76395117"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f")
                        },
                        new
                        {
                            Id = new Guid("3ba15c36-17ae-4d1b-acdb-af25533da603"),
                            IngredientEntityId = new Guid("d58fb518-f476-4711-8e48-63f47b6af88c"),
                            Quantity = 2f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f")
                        },
                        new
                        {
                            Id = new Guid("c8e7416a-69bc-4c99-80b6-c8e700b8b3ed"),
                            IngredientEntityId = new Guid("09ab1054-a558-4471-be74-db9865872822"),
                            Quantity = 0.25f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("85194fb4-cf5e-4947-be72-180d6052d58d")
                        },
                        new
                        {
                            Id = new Guid("6a2871fd-9a7a-487d-8f1b-a2938f0209a9"),
                            IngredientEntityId = new Guid("7aa0f9d0-503e-47c5-a92e-4565e81be5da"),
                            Quantity = 0.25f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("85194fb4-cf5e-4947-be72-180d6052d58d")
                        },
                        new
                        {
                            Id = new Guid("0db0effd-5da0-4338-a70c-3391833cf4a6"),
                            IngredientEntityId = new Guid("70c20e8d-32f6-4dc6-aa3e-ba259c8d25b0"),
                            Quantity = 0.5f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f")
                        },
                        new
                        {
                            Id = new Guid("3aae1789-f4dc-46b6-bda4-8d2cc49b147b"),
                            IngredientEntityId = new Guid("1f83544a-7428-40ee-af8f-fd4f28be89d7"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("8631e811-8b8f-4bc4-a014-f7834899ce29"),
                            IngredientEntityId = new Guid("33098acf-a9c5-4ee7-8047-f50782fc1e7e"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("24c4010d-dc64-4399-a3a1-80082e1716f6")
                        },
                        new
                        {
                            Id = new Guid("e8f2a011-6c24-46ed-94b8-a1cd37b35226"),
                            IngredientEntityId = new Guid("38fb63a8-3f50-41ea-a9b3-8f65b49af37d"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f")
                        },
                        new
                        {
                            Id = new Guid("45ce1c5e-7c48-49e8-8552-86d916b02098"),
                            IngredientEntityId = new Guid("3ff335b7-4e1d-4831-9f8b-8b09bca41921"),
                            Quantity = 50f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("13e9e716-dc49-4ff2-904c-80883a95be1a"),
                            IngredientEntityId = new Guid("896a24d6-e95d-4650-a3b3-bd9aa683b9c7"),
                            Quantity = 0.5f,
                            RecipeEntityId = new Guid("5f1af0b0-273b-40c3-b7ee-ee8c91f2a1f2"),
                            UnitEntityId = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f")
                        },
                        new
                        {
                            Id = new Guid("0f93a1da-e68f-4446-9743-3a3f7dc9682c"),
                            IngredientEntityId = new Guid("69ff199f-92f3-4b8d-ad58-e4b99a6abbbf"),
                            Quantity = 4f,
                            RecipeEntityId = new Guid("a27b18cf-8cf3-4ab0-8d93-b333a02aedd8"),
                            UnitEntityId = new Guid("85194fb4-cf5e-4947-be72-180d6052d58d")
                        },
                        new
                        {
                            Id = new Guid("c1db14f0-afde-4276-8b90-f5e014485a33"),
                            IngredientEntityId = new Guid("9af752cc-5056-45e7-9651-da1a880848ad"),
                            Quantity = 340f,
                            RecipeEntityId = new Guid("a27b18cf-8cf3-4ab0-8d93-b333a02aedd8"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("96244452-55bf-412d-b396-34c578a6a39a"),
                            IngredientEntityId = new Guid("05c646db-e41c-42eb-b211-29ac9ac0fbf3"),
                            Quantity = 340f,
                            RecipeEntityId = new Guid("a27b18cf-8cf3-4ab0-8d93-b333a02aedd8"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("441e65d4-d107-46d0-b733-c6c71987fc02"),
                            IngredientEntityId = new Guid("0f3d56b2-36fb-41ec-b243-3d749459da7d"),
                            Quantity = 30f,
                            RecipeEntityId = new Guid("a27b18cf-8cf3-4ab0-8d93-b333a02aedd8"),
                            UnitEntityId = new Guid("ebf484dd-4101-47ed-8ce9-8b6215fff4e9")
                        },
                        new
                        {
                            Id = new Guid("cdf3a877-17eb-4c16-9fed-73dfed144c27"),
                            IngredientEntityId = new Guid("33444a0e-2a09-41b9-914a-9c230efb0bb0"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("a27b18cf-8cf3-4ab0-8d93-b333a02aedd8"),
                            UnitEntityId = new Guid("9cd37a29-d3e8-4b6e-9249-7e559ebe2974")
                        },
                        new
                        {
                            Id = new Guid("8045be58-c718-49ed-a2e6-f4b127525384"),
                            IngredientEntityId = new Guid("e59c0e62-e595-4319-ac4b-eb93035ca204"),
                            Quantity = 2f,
                            RecipeEntityId = new Guid("a4ead8fc-eb82-4f57-a10d-509ed90d5183"),
                            UnitEntityId = new Guid("85194fb4-cf5e-4947-be72-180d6052d58d")
                        },
                        new
                        {
                            Id = new Guid("8fce8e91-ce52-4ec1-bf7e-3ed1c2f08f51"),
                            IngredientEntityId = new Guid("1792fb22-66e8-4d5f-8f48-fd55007767fb"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("a4ead8fc-eb82-4f57-a10d-509ed90d5183"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("51755685-a066-4b5a-a39c-402ca85ef2a6"),
                            IngredientEntityId = new Guid("28a90979-1888-4f92-b56e-33df57778d8e"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("a4ead8fc-eb82-4f57-a10d-509ed90d5183"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        },
                        new
                        {
                            Id = new Guid("6946e8ad-8511-47d0-8c80-a13388113fa3"),
                            IngredientEntityId = new Guid("839ac76d-609e-495c-b2d5-66dcd63b9ab0"),
                            Quantity = 1f,
                            RecipeEntityId = new Guid("a4ead8fc-eb82-4f57-a10d-509ed90d5183"),
                            UnitEntityId = new Guid("85194fb4-cf5e-4947-be72-180d6052d58d")
                        },
                        new
                        {
                            Id = new Guid("c9f3e809-0c3c-41e6-946a-979f786fad0e"),
                            IngredientEntityId = new Guid("46fdfe5f-fc4e-4b05-91d5-bca7d7e24cfe"),
                            Quantity = 0.75f,
                            RecipeEntityId = new Guid("a4ead8fc-eb82-4f57-a10d-509ed90d5183"),
                            UnitEntityId = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f")
                        },
                        new
                        {
                            Id = new Guid("5189c7ac-5c06-4564-9478-8672aea312f4"),
                            IngredientEntityId = new Guid("bd28c339-25b5-4f08-8d28-70bc61eafa9b"),
                            Quantity = 100f,
                            RecipeEntityId = new Guid("a4ead8fc-eb82-4f57-a10d-509ed90d5183"),
                            UnitEntityId = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b")
                        });
                });

            modelBuilder.Entity("DATA.Models.UnitEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e8417d95-d7e1-4982-9d80-609c84e415ef"),
                            Name = "l"
                        },
                        new
                        {
                            Id = new Guid("2ea26cac-b37f-4590-a65d-7236eab22c7b"),
                            Name = "g"
                        },
                        new
                        {
                            Id = new Guid("24c4010d-dc64-4399-a3a1-80082e1716f6"),
                            Name = "pinch"
                        },
                        new
                        {
                            Id = new Guid("9cd37a29-d3e8-4b6e-9249-7e559ebe2974"),
                            Name = "slice"
                        },
                        new
                        {
                            Id = new Guid("19de8b03-56e3-4e10-ac6c-49d53133da2f"),
                            Name = "tsp"
                        },
                        new
                        {
                            Id = new Guid("ebf484dd-4101-47ed-8ce9-8b6215fff4e9"),
                            Name = "ml"
                        },
                        new
                        {
                            Id = new Guid("85194fb4-cf5e-4947-be72-180d6052d58d"),
                            Name = ""
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

                    b.HasOne("DATA.Models.UnitEntity", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");

                    b.Navigation("Unit");
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
