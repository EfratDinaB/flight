namespace flight.DTO
{
    public class FlightDTO
    {
        public int FlightId { get; set; }
        public int? TerminalNumber { get; set; }
        public int? CountryOfOriginCode { get; set; }
        public int? DestinationCountryCode { get; set; }
        public double? Price { get; set; }
        public int? NumberOfSeats { get; set; }
        public int AirlineCode { get; set; }
        public DateTime? DateF { get; set; }
    }
}