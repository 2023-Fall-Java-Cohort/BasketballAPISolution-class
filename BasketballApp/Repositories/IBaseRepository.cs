
namespace BasketballApp.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellation = default);
        Task<bool> DeleteAsync(int id, CancellationToken cancellation = default);
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellation = default);
        Task<TEntity?> GetAsync(int id, CancellationToken cancellation = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellation = default);
    }
}