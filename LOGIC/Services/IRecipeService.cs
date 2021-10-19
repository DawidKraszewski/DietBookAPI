using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public interface IRecipeService : ICrudService<RecipeDto>
    {

        Task<OperationResult<RecipeWithDetailsDto>> GetRecipeWithDetails(Guid id, CancellationToken cancellationToken = default);

        Task<OperationResult<RecipeWithDetailsDto>> CreateWithDetailsAsync(RecipeCreateDto recipe , CancellationToken cancellationToken = default);

        Task<OperationResult> UpdateWithDetailsAsync(RecipeEditDto recipe, CancellationToken cancellationToken = default);
    }
}
