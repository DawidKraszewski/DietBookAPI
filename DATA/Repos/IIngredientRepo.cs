using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DATA.Repos
{
    public interface IIngredientRepo : IGenericRepo<IngredientEntity>
    {
        Task<List<IngredientEntity>> SearchForIngredients(string searchString, CancellationToken cancellationToken);

        Task<IngredientEntity> GetIngredientWithDetails(Guid id, CancellationToken cancellationToken);
    }
}
