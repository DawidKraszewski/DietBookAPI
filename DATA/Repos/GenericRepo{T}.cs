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
    public class GenericRepo<T> : IGenericRepo<T> where T : class, IEntity
    {
        public readonly DbContext dbContext;
        public readonly DbSet<T> dbSet;

        public GenericRepo(DbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken)
        {
            entity.Id = this.ResolveId(entity);

            var newEntity = await Task.Run(() => this.dbSet.Add(entity).Entity);

            this.dbContext.SaveChanges();

            return newEntity;
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await this.dbSet.FindAsync(new object[] { id }, cancellationToken);

            if (entity != null)
            {
                this.dbSet.Remove(entity);
                this.dbContext.SaveChanges();

                return true;
            }

            return false;
        }

        public async Task<IList<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await dbSet.ToListAsync(cancellationToken);
        }

        public async Task<T> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            T entity = await this.dbSet.FindAsync(new object[] { id }, cancellationToken);

            return entity;
        }

        public async Task<bool> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            var oldEntity = await this.dbSet.FindAsync(new object[] { entity.Id }, cancellationToken);

            if (oldEntity != null)
            {
                this.dbContext.Entry(oldEntity).CurrentValues.SetValues(entity);
                this.dbContext.SaveChanges();

                return true;
            }

            return false;
        }

        protected virtual Guid ResolveId(T entity) => entity.Id == Guid.Empty ? Guid.NewGuid() : entity.Id;
    }
}
