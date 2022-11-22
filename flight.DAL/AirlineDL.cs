using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.DAL
{
    public class AirlineDL
    {
        TravelAgencyContext _context = new TravelAgencyContext();

        public List<Airline> GetAllAirline()
        {
            try
            {
                return _context.Airlines.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public void AddAirline(Airline airline)
        //{
        //    try
        //    {
        //        _context.Airlines.Add(airline);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        ////DELETE
        //public bool DeleteAirlines(int airlineId)
        //{
        //    try
        //    {
        //        Airline currentAirline = _context.Airlines.SingleOrDefault(x => x.Id == airlineId);
        //        _context.Airlines.Remove(currentAirline);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        ////UPDATE

        //public bool UpdatAirline(int id, Airline airline)
        //{
        //    try
        //    {// שליפת הרשומה שנדרשת לעדכון
        //        Airline currentAirlineToUpdate = _context.Airlines.SingleOrDefault(x => x.Id == id);
        //        _context.Entry(currentAirlineToUpdate).CurrentValues.SetValues(airline);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}
    }
}
