using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.DAL
{
    public class UserDL
    {
        TravelAgencyContext _context = new TravelAgencyContext();

        public User Login(string email)
        {
            User user = _context.Users.SingleOrDefault(x => x.Email.Equals(email));
            return user;
        }
        public List<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();
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
                _context.Users.Add(User);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE
        public bool DeleteUser(int id)
        {
            try
            {
                User currentUser = _context.Users.SingleOrDefault(x => x.Id == id);
                _context.Users.Remove(currentUser);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //UPDATE

        public bool UpdateUser(int id, User User)
        {
            try
            {// שליפת הרשומה שנדרשת לעדכון
                User currentUserToUpdate = _context.Users.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentUserToUpdate).CurrentValues.SetValues(User);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
