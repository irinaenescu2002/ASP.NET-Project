using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Repositories.Generic
{
    public interface IGeneric<TEntity> where TEntity : BaseEntity
    {
        Task CreateAsync (TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task <TEntity> FindByIDAsync(Guid id);

        IAsyncEnumerable<TEntity> GetAsync();

        Task<bool> SaveAsync(); 
    }
}
