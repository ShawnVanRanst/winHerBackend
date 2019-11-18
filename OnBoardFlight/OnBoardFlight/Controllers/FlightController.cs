using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnBoardFlight.Model;

namespace OnBoardFlight.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightRepository _flightRepository;

        public FlightController(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        // GET api/flight
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            IEnumerable<Flight> fl = _flightRepository.getFlight();
            
            return new string[] { fl.Count().ToString(), "value2" };
        }
    }
}