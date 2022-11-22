using flight.BL;
using flight.DAL;
using flight.DAL.Models;
using flight.DTO;
using Microsoft.AspNetCore.Mvc;

namespace flight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : ControllerBase
    {

        private IFlightBL _flightBL;

        public FlightsController(IFlightBL iflightBL)
        {
            _flightBL = iflightBL;
            
        }




        [HttpGet]
        [Route("Flights")]
        public dynamic GetAllFlights()
        {
            List<FlightDTO> flight =_flightBL.GetAllFlights();
            return flight;
        }
        

        [HttpPost]
        [Route("add")]
       public void AddFlight([FromBody] FlightDTO Flight)
        {
          _flightBL.AddFlight(Flight);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteFlight(int id)
        {
            return _flightBL.DeleteFlight(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateFlight(int id, [FromBody] FlightDTO Flight)
        {
            return _flightBL.UpdateFlight(id, Flight);
        }

        [HttpGet]
        [Route("SearchFlight")]
        public dynamic SearchFlight(int id, int des)
        {
            return _flightBL.SearchFlight(id, des);

        }

    }
}