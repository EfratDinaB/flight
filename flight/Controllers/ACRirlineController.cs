using flight.BL;
using flight.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flight.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ACRirlineController : ControllerBase
    {

        private AirlineBL _airlineBL;
        private CountryBL _CountryBL;
        private RoleBL _RoleBL;
        [HttpGet]
        [Route("Airlines")]
        public dynamic GetAllAirlines()
        {
            List<Airline> airline = _airlineBL.GetAllAirlines();
            return airline;
        }
        [HttpGet]
        [Route("Countries")]
        public dynamic GetAllCountries()
        {
            List<Country> Country = _CountryBL.GetAllCountries();
            return Country;
        }
        [HttpGet]
        [Route("Role")]
        public dynamic GetAllRoles()
        {
            List<Role> Role = _RoleBL.GetAllRoles();
            return Role;
        }


        //[HttpPost]
        //[Route("add")]
        //public void AddAirline([FromBody] Airline Airline)
        //{
        //    _airlineBL.AddAirline(Airline);
        //}


        //[HttpDelete]
        //[Route("delete/{id}")]
        //public bool DeletAirline(int id)
        //{
        //    return _airlineBL.DeleteAirline(id);
        //}

        //[HttpPut]
        //[Route("update/{id}")]
        //public bool UpdateAirline(int id, [FromBody] Airline Airline)
        //{
        //    return _airlineBL.UpdateAirline(id, Airline);
        //}

    }
}
