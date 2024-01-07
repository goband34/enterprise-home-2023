using Domain.Models;

namespace Presentation.ViewModels;

public class TicketVM
{
    private Ticket _ticket;

    public int ID
    {
        get => this._ticket.ID;
    }
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
    public double PricePaid
    {
        get => this._ticket.PricePaid;
    }

    public TicketVM(Ticket ticket)
    {
        this._ticket = ticket;
    }
}
