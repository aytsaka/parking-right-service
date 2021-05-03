using ParkingRight.Domain.ParkingRightAggregate;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParkingRight.Domain.Common
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly ParkingRightDbContext _context;

        public IParkingRightRepository ParkingRightRepository { get; private set; }

        public UnitOfWork(ParkingRightDbContext context)
        {
            _context = context;
            ParkingRightRepository = new ParkingRightRepository(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }
    }
}
