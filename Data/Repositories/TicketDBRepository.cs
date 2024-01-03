using Domain.Models;
using Data.Contexts;
using Data.Repositories; 

namespace Data.Repositories;

public class TicketDBRepository
{
    private AirlineDbContext _context;
    private FlightDbRepository _flightRepo;

    public TicketDBRepository(AirlineDbContext context, FlightDbRepository flightRepo)
    {
	this._context = context;
        this._flightRepo = flightRepo;
    }
    
    public void Book(Ticket ticket)
    {
        if (this._flightRepo.GetFlight(ticket.FlightFK)?.DepartureDate < DateTime.Now)
        {
            throw new Exception("Trying to book a flight that was in the past");
        }

        var existingTicket =
            this._context.Tickets
            ?.Where(t => t.FlightFK == ticket.FlightFK && t.Row == ticket.Row && t.Column == ticket.Column)
            .FirstOrDefault();

        if (existingTicket != null && existingTicket.Cancelled == false)
        {
            throw new Exception("Trying to book a ticket that's occupied");
        }

        this._context.Tickets?.Add(ticket);
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
