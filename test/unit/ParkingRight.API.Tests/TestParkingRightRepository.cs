using ParkingRight.Domain.ParkingRightAggregate;
using System.Threading.Tasks;

namespace ParkingRight.API.Tests
{
    public class TestParkingRightRepository : IParkingRightRepository
    {
        public Task<ParkRight> AddAsync(ParkRight entity)
        {
            return Task.FromResult(entity);
        }
    }
}
