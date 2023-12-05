using Domain;

namespace Data;

public class FlightDbRepository
{
    private AirlineDbContext _context;

    public FlightDbRepository(AirlineDbContext _context) {
	    this._context = _context;
    }

    public Flight? GetFlight(int id)
    {
	    return _context.Flights.Find(id);
    }

    public IQueryable<Flight> GetFlights()
    {
	    return _context.Flights;
    }

    public IQueryable<Flight> GetCurrentFlights()
    {
	    return this.GetFlights().Where((f) => f.DepartureDate > DateTime.Now);
    }
}
