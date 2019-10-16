using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoardFlight.Models
{
    public class FlightCrewMember
    {

        #region Properties

        public int FlightCrewId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }



        #endregion

        #region Constructors

        public FlightCrewMember()
        {
        }

        public FlightCrewMember(string email, string firstName, string lastName)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }


        #endregion

        #region Methods

        #endregion
    }
}
