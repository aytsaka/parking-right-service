using System;

namespace ParkingRight.Domain.Common
{
    [Serializable]
    public class RuleBrokenException : BaseException
    {
        public RuleBrokenException()
        {
        }

        public RuleBrokenException(string message) : base(message)
        {
            // Logs can be added here.
        }

        public RuleBrokenException(string message, Exception innerException) : base(message, innerException)
        {
            // Logs can be added here.
        }
    }
}
