using ParkingRight.Domain.ParkingRightAggregate;

namespace ParkingRight.API.ViewModels
{
    /// <summary>
    /// Parking right response.
    /// </summary>
    public class ParkingRightResponse
    {
        /// <summary>
        /// Parking right identifier.
        /// </summary>
        public long ParkingRightId { get; set; }

        /// <summary>
        /// Contructor that builds an ParkingRightResponse of an <see cref="ParkRight"/>
        /// </summary>
        /// <param name="model"></param>
        public ParkingRightResponse(ParkRight model)
        {
            ParkingRightId = model.ParkingRightId;
        }
    }
}
