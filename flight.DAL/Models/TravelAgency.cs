using System;
using System.Collections.Generic;

namespace flight.DAL.Models
{
    public partial class TravelAgency
    {
        public int AgencyCode { get; set; }
        public int? ManegerId { get; set; }
        public int? FlightId { get; set; }

        public virtual Flight? Flight { get; set; }
        public virtual User? Maneger { get; set; }
    }
}
