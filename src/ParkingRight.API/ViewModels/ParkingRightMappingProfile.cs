using AutoMapper;
using ParkingRight.Domain.ParkingRightAggregate;

namespace ParkingRight.API.ViewModels
{
    /// <summary>
    /// Represents a class to configure model mappings.
    /// </summary>
    public class ParkingRightMappingProfile : Profile
    {
        /// <summary>
        /// Creating a new instance of the <see cref="ParkingRightMappingProfile"/> and does mappings.
        /// </summary>
        public ParkingRightMappingProfile()
        {
            CreateMap<ParkingRightRequestPostViewModel, ParkingRightRequestPost>();
            CreateMap<ParkingRightRequestPost, ParkRight>();
        }
    }
}
