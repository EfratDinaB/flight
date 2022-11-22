using flight.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight.DAL
{
    public interface IFlightDL
    {
        List<Flight> GetAllFlights();
        void AddFlight(Flight Flight);
        bool DeleteFlight(int flightId);
        bool UpdateFlight(int id, Flight flight);
        Flight SearchFlight(int id, int destination);
    }
}
