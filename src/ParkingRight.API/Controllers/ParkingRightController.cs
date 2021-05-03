using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParkingRight.API.ViewModels;
using ParkingRight.Domain.Common;
using ParkingRight.Domain.ParkingRightAggregate;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading.Tasks;

namespace ParkingRight.API.Controllers
{
    /// <summary>
    /// WebApi parking right operations.
    /// </summary>
    [Route("api/parkingright")]
    [ApiController]
    public class ParkingRightController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        /// <summary>
        /// Creating a new instance of the <see cref="ParkingRightController"/>.
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public ParkingRightController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// Register a parking right.
        /// </summary>
        /// <param name="request">Request of the parking right to be added.</param>
        /// <returns>Returns the parking right identifier that were added based on given parking right request.</returns>
        [HttpPost]
        [SwaggerOperation("AddParkingRight"), SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(ParkingRightResponse))]
        public async Task<IActionResult> Post([FromBody] ParkingRightRequestPostViewModel request)
        {
            var parkRightItem = _mapper.Map<ParkingRightRequestPostViewModel, ParkRight>(request);
            parkRightItem = await _unitOfWork.ParkingRightRepository.AddAsync(parkRightItem);
            await _unitOfWork.CompleteAsync();
            return Ok(new ParkingRightResponse(parkRightItem));
        }
    }
}
