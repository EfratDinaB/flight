using System;
using System.Collections.Generic;

namespace flight.DAL.Models
{
    public partial class FlightDetail
    {
        public int OrderNumber { get; set; }
        public int FlightCode { get; set; }
        public int? UserId { get; set; }

        public virtual Flight FlightCodeNavigation { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
