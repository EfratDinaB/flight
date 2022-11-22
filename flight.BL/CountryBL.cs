using flight.DAL;
using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.BL
{
    public class CountryBL
    {
        CountryDL _CountryDL = new CountryDL();

        public List<Country> GetAllCountries()
        {
            try
            {
                return _CountryDL.GetAllCountries();
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
        //        _CountryDL.AddCountry(Country);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public bool DeleteCountry(int id)
        //{
        //    return _CountryDL.DeleteCountry(id);
        //}

        //public bool UpdateCountry(int id, Country Country)
        //{
        //    return _CountryDL.UpdatCountry(id, Country);
        //}

        
    }
}
