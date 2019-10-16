using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoardFlight.Models
{
    public class FlightCrew
    {

        #region Properties

        public int FlightCrewId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }



        #endregion

        #region Constructors

        public FlightCrew()
        {
        }

        public FlightCrew(string email, string firstName, string lastName)
        {
            Email = userName;
            FirstName = firstName;
            LastName = lastName;
        }


        #endregion

        #region Methods

        #endregion
    }
}
