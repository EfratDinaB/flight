using System;
using System.Collections.Generic;

namespace flight.DAL.Models
{
    public partial class Country
    {
        public Country()
        {
            FlightCountryOfOriginCodeNavigations = new HashSet<Flight>();
            FlightDestinationCountryCodeNavigations = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Flight> FlightCountryOfOriginCodeNavigations { get; set; }
        public virtual ICollection<Flight> FlightDestinationCountryCodeNavigations { get; set; }
    }
}
