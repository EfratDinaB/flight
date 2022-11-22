//using flight.BL;
//using flight.DAL.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace flight.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CountryController : ControllerBase
//    {
//        private CountryBL _CountryBL;


//        [HttpGet]
//        [Route("Countries")]
//        public dynamic GetAllCountries()
//        {
//            List<Country> Country = _CountryBL.GetAllCountries();
//            return Country;
//        }


//        [HttpPost]
//        [Route("add")]
//        public void AddCountry([FromBody] Country Country)
//        {
//            _CountryBL.AddCountry(Country);
//        }


//        [HttpDelete]
//        [Route("delete/{id}")]
//        public bool DeletCountry(int id)
//        {
//            return _CountryBL.DeleteCountry(id);
//        }

//        [HttpPut]
//        [Route("update/{id}")]
//        public bool UpdateCountry(int id, [FromBody] Country Country)
//        {
//            return _CountryBL.UpdateCountry(id, Country);
//        }

//    }
//}
