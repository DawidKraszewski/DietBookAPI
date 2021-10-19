using DATA.Context;
using DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DATA.Repos
{
    public class RecipeRepo : GenericRepo<RecipeEntity>, IRecipeRepo
    {
        public DbSet<IngredientEntity> Ingredients {set; get;}
        public RecipeRepo(DbContext context) : base(context)
        {
            Ingredients = dbContext.Set<IngredientEntity>();
        }

        public async Task<RecipeEntity> GetRecipeWithDetails(Guid id, CancellationToken cancellationToken)
        {
            var recipe = await dbSet
                .Include(nameof(RecipeEntity.RecipeIngredients) + "." + nameof(RecipeIngredientEntity.Ingredient))
                .Include(nameof(RecipeEntity.RecipeIngredients) + "." + nameof(RecipeIngredientEntity.Unit))
                .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);

            return recipe;
        }

        public async Task<RecipeEntity> UpdateRecipeWithDetails (RecipeEntity recipe, CancellationToken cancellationToken)
        {
            var oldRecipe = dbSet
                .Include(nameof(RecipeEntity.RecipeIngredients) + "." + nameof(RecipeIngredientEntity.Ingredient))
                .Include(nameof(RecipeEntity.RecipeIngredients) + "." + nameof(RecipeIngredientEntity.Unit))
                .Single(r => r.Id == recipe.Id);

            this.dbContext.Entry(oldRecipe).CurrentValues.SetValues(recipe);

            oldRecipe.RecipeIngredients.Clear();

            foreach (var recipeIngredient in recipe.RecipeIngredients)
            {
                var ingredientEntity = Ingredients
                    .Include(nameof(IngredientEntity.RecipeIngredients) + "." + nameof(RecipeIngredientEntity.Recipe))
                    .FirstOrDefault(i => i.Id == recipeIngredient.IngredientEntityId);

                oldRecipe.RecipeIngredients.Add(new RecipeIngredientEntity
                {
                    RecipeEntityId = oldRecipe.Id,
                    IngredientEntityId = ingredientEntity.Id,
                    UnitEntityId =recipeIngredient.UnitEntityId,
                    Quantity = recipeIngredient.Quantity
                });
            }

            await dbContext.SaveChangesAsync(cancellationToken);

            return oldRecipe;
        }

    }
}
