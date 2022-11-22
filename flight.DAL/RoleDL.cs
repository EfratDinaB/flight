using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.DAL
{
    public class RoleDL
    {
        TravelAgencyContext _context = new TravelAgencyContext();

        public List<Role> GetAllRoles()
        {
            try
            {
                return _context.Roles.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
