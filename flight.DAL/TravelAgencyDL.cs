using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.DAL
{
    public class TravelAgencyDL
    {
        TravelAgencyContext _context = new TravelAgencyContext();

        public List<TravelAgency> GetAllTravelAgency()
        {
            try
            {
                return _context.TravelAgencies.ToList();
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
                _context.TravelAgencies.Add(TravelAgency);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE
        public bool DeleteTravelAgency(int Id)
        {
            try
            {
                TravelAgency currentTravelAgency = _context.TravelAgencies.SingleOrDefault(x => x.AgencyCode == Id);
                _context.TravelAgencies.Remove(currentTravelAgency);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //UPDATE

        public bool UpdateTravelAgency(int id, TravelAgency TravelAgency)
        {
            try
            {// שליפת הרשומה שנדרשת לעדכון
                TravelAgency currentTravelAgency = _context.TravelAgencies.SingleOrDefault(x => x.AgencyCode == id);
                _context.Entry(currentTravelAgency).CurrentValues.SetValues(TravelAgency);
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
