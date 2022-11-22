using flight.DAL;
using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.BL
{
    public class UserBL
    {
        UserDL _UserDL = new UserDL();

        public List<User> GetAllUsers()
        {
            try
            {
                return _UserDL.GetAllUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddUser(User User)
        {
            try
            {
                _UserDL.AddUser(User);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteUser(int id)
        {
            return _UserDL.DeleteUser(id);
        }

        public bool UpdateUser(int id, User User)
        {
            return _UserDL.UpdateUser(id, User);
        }

        public User Login(string email)
        {
            User user = _UserDL.Login(email);   
            return user;
        }
    }
}
