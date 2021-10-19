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
    public class IngredientRepo : GenericRepo<IngredientEntity>, IIngredientRepo
    {
        public IngredientRepo(DbContext context) : base(context)
        {

        }

        public async Task<List<IngredientEntity>> SearchForIngredients(string searchString, CancellationToken cancellationToken)
        {
            var ingredients = from m in dbSet 
                              select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                ingredients = dbSet.Where(s => s.Name.Contains(searchString));
            }

            var ingredientsList = await ingredients.ToListAsync(cancellationToken);

            return ingredientsList;
        }
        public async Task<IngredientEntity> GetIngredientWithDetails(Guid id, CancellationToken cancellationToken)
        {
            var ingredient = await dbSet
                .Include(nameof(IngredientEntity.RecipeIngredients) + "." + nameof(RecipeIngredientEntity.Recipe))
                .FirstOrDefaultAsync(r => r.Id == id);

            return ingredient;
        }
    }
}
