using ParkingRight.Domain.ParkingRightAggregate;
using System.Threading;
using System.Threading.Tasks;

namespace ParkingRight.Domain.Common
{
    /// <summary>
    /// Represents the interface for <see cref="UnitOfWork"/>.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// ParkingRight Repository.
        /// </summary>
        IParkingRightRepository ParkingRightRepository { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<int> CompleteAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> CompleteAsync(CancellationToken cancellationToken);
    }
}
