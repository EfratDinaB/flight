using flight.DAL;
using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.BL
{
    public class TravelAgencyBL
    {
        TravelAgencyDL _TravelAgencyDL = new TravelAgencyDL();

        public List<TravelAgency> GetAllTravelAgency()
        {
            try
            {
                return _TravelAgencyDL.GetAllTravelAgency();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddTravelAgency(TravelAgency TravelAgency)
        {
            try
            {
                _TravelAgencyDL.AddTravelAgency(TravelAgency);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteTravelAgency(int id)
        {
            return _TravelAgencyDL.DeleteTravelAgency(id);
        }

        public bool UpdateTravelAgency(int id, TravelAgency TravelAgency)
        {
            return _TravelAgencyDL.UpdateTravelAgency(id, TravelAgency);
        }
    }
}
