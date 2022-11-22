using flight.BL;
using flight.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flight.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserBL _UserBL;


        [HttpGet]
        [Route("User")]
        public dynamic GetAllUsers()
        {
            return _UserBL.GetAllUsers();

        }


        [HttpPost]
        [Route("add")]
        public void AddUser([FromBody] User User)
        {
            _UserBL.AddUser(User);

        }


        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteUser(int id)
        {
            return _UserBL.DeleteUser(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateUser(int id, [FromBody] User User)
        {
            return _UserBL.UpdateUser(id, User);
        }
        [HttpGet]
        [Route("login/{email}")]
        public dynamic Login(string email)
        {
            return _UserBL.Login(email);

        }
    }
}
