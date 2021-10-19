using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DATA.Repos
{
    public interface IRecipeRepo : IGenericRepo<RecipeEntity>
    {
        Task<RecipeEntity> GetRecipeWithDetails(Guid id, CancellationToken cancellationToken);

        Task<RecipeEntity> UpdateRecipeWithDetails(RecipeEntity recipe, CancellationToken cancellationToken);
    }
}
