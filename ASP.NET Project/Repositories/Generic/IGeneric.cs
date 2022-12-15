using ASP.NET_Project.Models.Base;

namespace ASP.NET_Project.Repositories.Generic
{
    public interface IGeneric<TEntity> where TEntity : BaseEntity
    {
        Task CreateAsync (TEntity entity);

        Task<bool> SaveAsync(); 
    }
}
