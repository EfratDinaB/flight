using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.DAL
{
    public class CountryDL
    {
        TravelAgencyContext _context = new TravelAgencyContext();

        public List<Country> GetAllCountries()
        {
            try
            {
                return _context.Countries.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public void AddCountry(Country Country)
        //{
        //    try
        //    {
        //        _context.Countries.Add(Country);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        ////DELETE
        //public bool DeleteCountry(int CountryId)
        //{
        //    try
        //    {
        //        Country currentCountry = _context.Countries.SingleOrDefault(x => x.Id == CountryId);
        //        _context.Countries.Remove(currentCountry);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        ////UPDATE

        //public bool UpdatCountry(int id, Country Country)
        //{
        //    try
        //    {
        //        Country currentCountryToUpdate = _context.Countries.SingleOrDefault(x => x.Id == id);
        //        _context.Entry(currentCountryToUpdate).CurrentValues.SetValues(Country);
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
