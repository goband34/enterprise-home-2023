using Domain.Models;

namespace Presentation.ViewModels;

public class TicketVM
{
    private Ticket _ticket;

    public string Title
    {
        get
        {
            var flight = this._ticket.Flight;
            return $"{flight.CountryFrom}-{flight.CountryTo}";
        }
    }
    public string Description 
    {
        get => this._ticket.Flight.DepartureDate.ToString("dd/MM/yyyy");
    }

    public TicketVM(Ticket ticket)
    {
        this._ticket = ticket;
    }
}
