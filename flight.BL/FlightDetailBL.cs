using flight.DAL;
using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.BL
{
    public class FlightDetailBL
    {
        FlightDetailDL _FlightDetailDL = new FlightDetailDL();
        public FlightDetail GetFlightDetail(int id)
        {
            
            try
            {
                return _FlightDetailDL.GetFlightDetail(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddFlightDetail(FlightDetail FlightDetail)
        {
            try
            {
                _FlightDetailDL.AddFlightDetail(FlightDetail);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteFlightDetail(int id)
        {
            return _FlightDetailDL.DeleteFlightDetail(id);
        }

        public bool UpdateFlightDetail(int id, FlightDetail FlightDetail)
        {
            return _FlightDetailDL.UpdatFlightDetail(id, FlightDetail);
        }

        
    }
}

