using System;
using System.Collections.Generic;

namespace flight.DAL.Models
{
    public partial class User
    {
        public User()
        {
            FlightDetails = new HashSet<FlightDetail>();
            TravelAgencies = new HashSet<TravelAgency>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<FlightDetail> FlightDetails { get; set; }
        public virtual ICollection<TravelAgency> TravelAgencies { get; set; }
    }
}
