using System;
using System.Collections.Generic;

namespace flight.DAL.Models
{
    public partial class Airline
    {
        public Airline()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
