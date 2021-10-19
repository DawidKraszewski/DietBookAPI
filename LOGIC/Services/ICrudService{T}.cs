using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public interface ICrudService<T> where T : IDto
    {
        Task<OperationResult<IList<T>>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<OperationResult<T>> GetAsync(Guid id, CancellationToken cancellationToken = default);

        Task<OperationResult<T>> CreateAsync(T model, CancellationToken cancellationToken = default);

        Task<OperationResult> DeleteAsync(Guid id, CancellationToken cancellationToken = default);

        Task<OperationResult> UpdateAsync(T model, CancellationToken cancellationToken = default);

        
    }
}
