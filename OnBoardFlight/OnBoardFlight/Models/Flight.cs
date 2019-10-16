using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoardFlight.Models
{
    public class Flight
    {
        #region Properties

        public int FlightId { get; set; }

        public string FlightNumber { get; set; }

        public DateTime ETA { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DurationOfFlight { get; set; }



        #endregion

        #region Constructors

        public Flight()
        {

        }

        public Flight(string flightNumber, DateTime eTA, string origin, string destination, DateTime departureTime, DateTime arrivalTime, DateTime durationOfFlight)
        {
            FlightNumber = flightNumber;
            ETA = eTA;
            Origin = origin;
            Destination = destination;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            DurationOfFlight = durationOfFlight;
        }
        #endregion
    }
}
