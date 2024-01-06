using Domain.Models;

namespace Data.Repositories;

public interface ITicketRepository 
{
    public IQueryable<Ticket>? GetTickets();
    public Ticket? GetTicket(int id);
    public void Book(Ticket ticket);
    public void Cancel(Ticket ticket);
}
