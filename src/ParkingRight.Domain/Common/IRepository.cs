using System.Threading.Tasks;

namespace ParkingRight.Domain.Common
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        Task<TEntity> AddAsync(TEntity entity);
    }
}