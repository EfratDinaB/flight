using flight.BL;
using flight.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flight.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelAgencyController : ControllerBase
    {
        private TravelAgencyBL _TravelAgencyBL;

        [HttpGet]
        [Route("TravelAgency")]
        
        public dynamic GetAllTravelAgency()
        {
            List<TravelAgency> TravelAgency = _TravelAgencyBL.GetAllTravelAgency();
            return TravelAgency;
        }

        [HttpPost]
        [Route("add")]
        public void AddTravelAgency([FromBody] TravelAgency TravelAgency)
        {
            _TravelAgencyBL.AddTravelAgency(TravelAgency);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteTravelAgency(int id)
        {
            return _TravelAgencyBL.DeleteTravelAgency(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateTravelAgency(int id, [FromBody] TravelAgency TravelAgency)
        {
            return _TravelAgencyBL.UpdateTravelAgency(id, TravelAgency);
        }

    }
}
