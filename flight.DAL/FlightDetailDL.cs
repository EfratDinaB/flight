using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.DAL
{
    public class FlightDetailDL
    {
        TravelAgencyContext _context = new TravelAgencyContext();
    
        public FlightDetail GetFlightDetail(int id)
        {
            try
            {
                FlightDetail f=_context.FlightDetails.SingleOrDefault(x => x.FlightCode == id);
                return f;
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
                _context.FlightDetails.Add(FlightDetail);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE
        public bool DeleteFlightDetail(int FlightCode)
        {
            try
            {
                FlightDetail currentFlightDetail = _context.FlightDetails.SingleOrDefault(x => x.FlightCode == FlightCode);
                _context.FlightDetails.Remove(currentFlightDetail);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //UPDATE

        public bool UpdatFlightDetail(int id, FlightDetail FlightDetail)
        {
            try
            {
                FlightDetail currentFlightDetailToUpdate = _context.FlightDetails.SingleOrDefault(x => x.FlightCode == id);
                _context.Entry(currentFlightDetailToUpdate).CurrentValues.SetValues(FlightDetail);
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
