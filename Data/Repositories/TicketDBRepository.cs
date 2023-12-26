using Domain.Models;
using Data.Contexts;

namespace Data.Repositories;

public class TicketDBRepository
{
    private AirlineDbContext _context;

    public TicketDBRepository(AirlineDbContext _context)
    {
	this._context = _context;
    }
    
    public void Book(Ticket ticket)
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
