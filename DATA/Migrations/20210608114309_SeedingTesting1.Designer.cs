// <auto-generated />
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
    [Migration("20210608114309_SeedingTesting1")]
    partial class SeedingTesting1
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

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fbad7650-6109-479d-b884-65b1e7f69aef"),
                            Author = "Dawid",
                            Image = "123",
                            Name = "Pea soup"
                        },
                        new
                        {
                            Id = new Guid("cde386c6-2a90-4611-b6ac-e0fa35530370"),
                            Author = "Monika",
                            Image = "456",
                            Name = "Apple soup"
                        });
                });

            modelBuilder.Entity("DATA.Models.RecipeIngredientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IngredientEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

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
