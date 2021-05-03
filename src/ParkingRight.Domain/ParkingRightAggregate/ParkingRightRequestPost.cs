using ParkingRight.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingRight.Domain.ParkingRightAggregate
{
    public class ParkingRightRequestPost : BaseRequest
    {
        /// <summary>
        /// License plate to be registered.
        /// </summary>
        [Required]
        public string LicensePlate { get; set; }

        /// <summary>
        /// Operator identifier.
        /// </summary>
        [Required]
        public string OperatorId { get; set; }

        /// <summary>
        /// Parking zone identifier.
        /// </summary>
        [Required]
        public long ParkingZoneId { get; set; }

        /// <summary>
        /// Start date of the registiration.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End date of the registration.
        /// </summary>
        [Required]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Amount of the purchase.
        /// </summary>
        [Required]
        public decimal Amount { get; set; }

        /// <summary>
        /// User profile of registered parking right.
        /// </summary>
        [Required]
        public UserProfileType UserProfile { get; set; }
    }
}
