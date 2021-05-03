using ParkingRight.Infrastructure;

namespace ParkingRight.Domain.ParkingRightAggregate
{
    public class ParkingRightRepository : Repository<ParkRight>, IParkingRightRepository
    {
        public ParkingRightRepository(ParkingRightDbContext context) : base(context)
        {
        }
    }
}
