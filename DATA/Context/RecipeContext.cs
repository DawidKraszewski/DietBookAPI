
using DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Context
{
    public class RecipeContext : DbContext
    {
        public DbSet<RecipeEntity> Recipes { get; set; }

        public DbSet<IngredientEntity> Ingredients { get; set; }

        public DbSet<RecipeIngredientEntity> RecipeIngredients { get; set; }

        public DbSet<UnitEntity> Units { get; set; }

        public RecipeContext()
        {

        }

        public RecipeContext(DbContextOptions<RecipeContext> opt) : base(opt)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
        }
    }
}
