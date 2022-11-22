using System;
using System.Collections.Generic;

namespace flight.DAL.Models
{
    public partial class Flight
    {
        public Flight()
        {
            FlightDetails = new HashSet<FlightDetail>();
            TravelAgencies = new HashSet<TravelAgency>();
        }

        public int FlightId { get; set; }
        public int? TerminalNumber { get; set; }
        public int? CountryOfOriginCode { get; set; }
        public int? DestinationCountryCode { get; set; }
        public double? Price { get; set; }
        public int? NumberOfSeats { get; set; }
        public int AirlineCode { get; set; }
        public DateTime? DateF { get; set; }

        public virtual Airline AirlineCodeNavigation { get; set; } = null!;
        public virtual Country? CountryOfOriginCodeNavigation { get; set; }
        public virtual Country? DestinationCountryCodeNavigation { get; set; }
        public virtual ICollection<FlightDetail> FlightDetails { get; set; }
        public virtual ICollection<TravelAgency> TravelAgencies { get; set; }
    }
}
