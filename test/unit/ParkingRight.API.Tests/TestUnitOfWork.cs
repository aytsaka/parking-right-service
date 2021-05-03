using ParkingRight.Domain.Common;
using ParkingRight.Domain.ParkingRightAggregate;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParkingRight.API.Tests
{
    public class TestUnitOfWork : IUnitOfWork
    {
        //new Mock<IParkingRightRepository>().Object
        public IParkingRightRepository ParkingRightRepository => new TestParkingRightRepository();

        public Task<int> CompleteAsync()
        {
            return Task.FromResult(1);
        }

        public Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
