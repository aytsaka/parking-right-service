using ParkingRight.Infrastructure.Models;
using System.Threading.Tasks;

namespace ParkingRight.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        Task<TEntity> AddAsync(TEntity entity);
    }
}