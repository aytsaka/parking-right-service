using Microsoft.Extensions.DependencyInjection;
using ParkingRight.Domain.Common;
using System;

namespace ParkingRight.API.Tests
{
    public class ControllerTestFixture : IDisposable
    {
        public ServiceProvider ServiceProvider { get; }

        public ControllerTestFixture()
        {
            var services = new ServiceCollection();
            services.AddScoped<IUnitOfWork, TestUnitOfWork>();
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            ServiceProvider = services.BuildServiceProvider();
        }

        public void Dispose() => ServiceProvider.Dispose();
    }
}
