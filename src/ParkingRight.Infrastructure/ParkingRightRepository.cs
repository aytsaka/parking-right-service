using ParkingRight.Domain.ParkingRightAggregate;

namespace ParkingRight.Infrastructure
{
    public class ParkingRightRepository : Repository<ParkRight>, IParkingRightRepository
    {
        public ParkingRightRepository(ParkingRightDbContext context) : base(context)
        {
        }
    }
}
