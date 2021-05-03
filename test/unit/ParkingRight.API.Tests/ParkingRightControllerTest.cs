using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using ParkingRight.API.Controllers;
using ParkingRight.API.ViewModels;
using ParkingRight.Domain.Common;
using ParkingRight.Domain.ParkingRightAggregate;
using Xunit;

namespace ParkingRight.API.Tests
{
    public class ParkingRightControllerTest : IClassFixture<ControllerTestFixture>
    {
        private readonly ParkingRightController _parkingRightController;

        public ParkingRightControllerTest(ControllerTestFixture fixture)
        {
            var unitOfWork = fixture.ServiceProvider.GetService(typeof(IUnitOfWork)) as IUnitOfWork;
            var mapper = fixture.ServiceProvider.GetService(typeof(IMapper)) as IMapper;

            _parkingRightController = new ParkingRightController(unitOfWork, mapper);
        }

        [Fact]
        public void RegisterParkingRight()
        {
            // Arrange
            var expected = new ParkingRightResponse(new ParkRight("xyz", "abc", 1, new System.DateTime(), new System.DateTime(), 10, UserProfileType.Visitor));

            // Act
            var result = _parkingRightController.Post(new ParkingRightRequestPostViewModel()
            {
                Amount = 10,
                EndDate = new System.DateTime(),
                LicensePlate = "xyz",
                OperatorId = "abc",
                ParkingZoneId = 1,
                StartDate = new System.DateTime(),
                UserProfile = UserProfileType.Visitor
            });

            //Assert
            var actual = Assert.IsType<OkObjectResult>(result.Result).Value;
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
