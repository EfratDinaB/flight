using flight.DAL.Models;
using flight.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.BL
{
    public class AirlineBL
    {
        AirlineDL _airlineDL = new AirlineDL();
        
        public List<Airline> GetAllAirlines()
        {
            try
            {
                return _airlineDL.GetAllAirline();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public void AddAirline(Airline Airline)
        //{
        //    try
        //    {
        //        _airlineDL.AddAirline(Airline);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public bool DeleteAirline(int id)
        //{
        //    return _airlineDL.DeleteAirlines(id);
        //}

        //public bool UpdateAirline(int id, Airline Airline)
        //{
        //    return _airlineDL.UpdatAirline(id, Airline);
        //}

        
    }
}
