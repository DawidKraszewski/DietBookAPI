using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public interface IIngredientService : ICrudService<IngredientDto>
    {
        Task<OperationResult<IList<IngredientDto>>> SearchForIngredients(string searchString, CancellationToken cancellationToken);

        Task<OperationResult<IngredientWithDetailsDto>> GetIngredientWithDetails(Guid id, CancellationToken cancellationToken = default);
    }
}
