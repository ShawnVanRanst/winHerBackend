using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoardFlight.Models.IRepositories
{
    public interface IFlightCrewRepository
    {

        FlightCrewMember GetFlightCrewMember();

        IEnumerable<FlightCrewMember> GetFlightCrewMembers();

        void AddFlightCrewMember();

        void DeleteFlightCrewMember(FlightCrewMember flightCrewMember);

        void UpdateFlightCrewMember(FlightCrewMember flightCrewMember);

        void SaveChanges();
    }
}
