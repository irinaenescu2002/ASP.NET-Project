using ASP.NET_Project.Context;
using ASP.NET_Project.Models.Base;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Project.Repositories.Generic
{
    public class Generic<TEntity> : IGeneric<TEntity> where TEntity : BaseEntity
    {
        protected readonly DBContext _DBContext;
        protected readonly DbSet<TEntity> _table;

        public Generic(DBContext dataBaseContext)
        {
            _DBContext = dataBaseContext;
            _table = _DBContext.Set<TEntity>();
        }

        /// Create - Generic 
       
        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        /// Delete - Generic

        public async Task DeleteAsync(TEntity entity)
        {
            _table.Remove(entity);
        }

        /// Find by ID - Generic

        public async Task<TEntity> FindByIDAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }

        /// Save the changes - Generic

        public async Task<bool> SaveAsync()
        {
            try
            {
                return await _DBContext.SaveChangesAsync() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex);
            }

            return false;
        }

        /// Get (show all rows) - Generic
        
        public async IAsyncEnumerable<TEntity> GetAsync()
        {
            var location = await _table.AsNoTracking().ToListAsync();

            foreach (var entity in location)
            {
                yield return entity;
            }
        }

    }
}
