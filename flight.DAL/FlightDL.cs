using flight.DAL.Models;

namespace flight.DAL
{
    public class FlightDL:IFlightDL
    {
        TravelAgencyContext _context = new TravelAgencyContext();

        public List<Flight> GetAllFlights()
        {
            try
            {
                return _context.Flights.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        
        public void AddFlight(Flight Flight)
        {
            try
            {
                _context.Flights.Add(Flight);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE
        public bool DeleteFlight(int flightId)
        {
           try
            {
                Flight currentFlight = _context.Flights.SingleOrDefault(x => x.FlightId == flightId);
                _context.Flights.Remove(currentFlight);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //UPDATE

        public bool UpdateFlight(int id, Flight flight)
        {
            try
            {// שליפת הרשומה שנדרשת לעדכון
                Flight currentFlightToUpdate = _context.Flights.SingleOrDefault(x => x.FlightId == id);
                _context.Entry(currentFlightToUpdate).CurrentValues.SetValues(flight);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Flight SearchFlight(int id, int destination)
        {
            try
            {
                Flight f = _context.Flights.SingleOrDefault(x => x.FlightId == id && x.DestinationCountryCode== destination);
                return f;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
    }
}