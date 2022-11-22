using AutoMapper;
using flight.DAL;
using flight.DAL.Models;
using flight.DTO;

namespace flight.BL
{
    public class FlightBL: IFlightBL
    {
        IMapper mapper;
        public IFlightDL _iflightDl;
        public FlightBL( IFlightDL flightDL)
        {
            _iflightDl = flightDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });

            mapper = config.CreateMapper();
        }

        //FlightDL _flightDL = new FlightDL();
        public List<FlightDTO> GetAllFlights()
        {
            // auto mapper 
            //   צריך להמיר מאוביקט של flight-> flightDTO
            List<Flight> flights = _iflightDl.GetAllFlights();
            return mapper.Map<List<Flight>, List<FlightDTO>>(flights);
        }
        
        public void AddFlight(FlightDTO Flight)
        {
            
            try
            {
                Flight flight = mapper.Map<FlightDTO, Flight>(Flight);
                _iflightDl.AddFlight(flight);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteFlight(int id)
        {
            return _iflightDl.DeleteFlight(id);
        }

        public bool UpdateFlight(int id, FlightDTO flight)
        {
            Flight f = mapper.Map<FlightDTO, Flight>(flight);
            _iflightDl.AddFlight(f);
            return _iflightDl.UpdateFlight(id, f);
        }
        public Flight SearchFlight(int id, int des)
        {

            try
            {
                return _iflightDl.SearchFlight(id,des);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        FlightDTO IFlightBL.SearchFlight(int id, int destination)
        {
            throw new NotImplementedException();
        }
    }
}