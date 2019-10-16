using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoardFlight.Models
{
    public class Passenger
    {

        #region Properties

        public int PassengerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Seat { get; set; }



        #endregion

        #region Constructors

        public Passenger()
        {
        }

        public Passenger(string firstName, string lastName, string seat)
        {
            FirstName = firstName;
            LastName = lastName;
            Seat = seat;
        }


        #endregion

        #region Methods

        #endregion
    }
}
