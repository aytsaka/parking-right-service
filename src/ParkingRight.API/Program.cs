using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ParkingRight.API
{
    /// <summary>
    /// Represents a class to start the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Creates and runs the host.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the host.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
