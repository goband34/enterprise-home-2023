namespace Data;

using Domain;

public class TicketDBRepository
{
    private AirlineDbContext _context;

    public TicketDBRepository(AirlineDbContext _context)
    {
	this._context = _context;
    }
    
    public void Book(Flight flight)
    {
    }

    public void Cancel(Ticket ticket)
    {
    }

    public IQueryable<Ticket> GetTickets()
    {
	return _context.Tickets;
    }
}
