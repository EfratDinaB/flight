using flight.DAL;
using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.BL
{
    public class RoleBL
    {
        RoleDL _RoleDL = new RoleDL();

        public List<Role> GetAllRoles()
        {
            try
            {
                return _RoleDL.GetAllRoles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
