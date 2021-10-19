using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DATA.Repos
{
    public interface IGenericRepo<T> where T : class
    {
        Task<T> CreateAsync(T entity, CancellationToken cancellationToken);

        Task<T> GetAsync(Guid id, CancellationToken cancellationToken);

        Task<IList<T>> GetAllAsync(CancellationToken cancellationToken);

        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);

        Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken);
    }
}
