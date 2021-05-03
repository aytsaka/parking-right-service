using ParkingRight.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingRight.Domain.ParkingRightAggregate
{
    public class ParkRight : IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the parking right identifier.
        /// </summary>
        [Key]
        public long ParkingRightId { get; protected set; }

        /// <summary>
        /// Gets or sets the license plate to be registered.
        /// </summary>
        public string LicensePlate { get; protected set; }

        /// <summary>
        /// Gets or sets the operator identifier.
        /// </summary>
        public string OperatorId { get; protected set; }

        /// <summary>
        /// Gets or sets the parking zone identifier.
        /// </summary>
        public long ParkingZoneId { get; protected set; }

        /// <summary>
        /// Gets or sets the start date of the registiration.
        /// </summary>
        public DateTime StartDate { get; protected set; }

        /// <summary>
        /// Gets or sets the end date of the registration.
        /// </summary>
        public DateTime EndDate { get; protected set; }

        /// <summary>
        /// Gets or sets the amount of the purchase.
        /// </summary>
        public decimal Amount { get; protected set; }

        // <summary>
        // Gets or sets the user profile of registered parking right.
        // </summary>
        public UserProfileType UserProfile { get; set; }

        protected ParkRight()
        {
        }

        public ParkRight(string licensePlate, string operatorId, long parkingZoneId, DateTime startDate, DateTime endDate, decimal amount, UserProfileType userProfileType)
        {
            LicensePlate = licensePlate;
            OperatorId = operatorId;
            ParkingZoneId = parkingZoneId;
            StartDate = startDate;
            EndDate = endDate;
            Amount = amount;
            UserProfile = userProfileType;

            CheckForRules();
        }

        private void CheckForRules()
        {
            if (string.IsNullOrEmpty(LicensePlate))
            {
                throw new RuleBrokenException("License plate cannot be empty");
            }

            //TODO: Other rules can be added here.
        }
    }
}