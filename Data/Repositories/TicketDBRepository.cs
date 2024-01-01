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
        // TODO: Check that row and column are unique for the flight
        this._context.Tickets.Add(ticket);
        this._context.SaveChanges();
    }

    public void Cancel(Ticket ticket)
    {
    }

    public IQueryable<Ticket> GetTickets()
    {
	return _context.Tickets;
    }
}
