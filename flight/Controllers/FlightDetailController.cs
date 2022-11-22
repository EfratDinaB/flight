using flight.BL;
using flight.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flight.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDetailController : ControllerBase
    {
        private FlightDetailBL _FlightDetailBL;


        [HttpGet]
        [Route("FlightDetail")]
        public dynamic GetFlightDetail(int id)
        {
            return  _FlightDetailBL.GetFlightDetail(id);
             
        }


        [HttpPost]
        [Route("add")]
        public void AddFlightDetail([FromBody] FlightDetail flightDetail)
        {
            _FlightDetailBL.AddFlightDetail(flightDetail);
           
        }


        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteFlightDetail(int id)
        {
            return _FlightDetailBL.DeleteFlightDetail(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateFlightDetail(int id, [FromBody] FlightDetail FlightDetail)
        {
            return _FlightDetailBL.UpdateFlightDetail(id, FlightDetail);
        }

    }
}
