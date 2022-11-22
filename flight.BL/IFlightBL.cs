using flight.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.BL
{
    public interface IFlightBL
    {
        List<FlightDTO> GetAllFlights();
        void AddFlight(FlightDTO Flight);
        bool DeleteFlight(int flightId);
        bool UpdateFlight(int id, FlightDTO flight);
        FlightDTO SearchFlight(int id, int destination);
    }
}
