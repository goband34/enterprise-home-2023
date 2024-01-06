using Domain.Models;

namespace Presentation.ViewModels;

public class AdminTicketVM
{
    private Ticket _ticket;

    public string Relation
    {
        get
        {
            var flight = this._ticket.Flight;
            return $"{flight.CountryFrom}-{flight.CountryTo}";
        }
    }
    public string DepartureDate
    {
        get => this._ticket.Flight.DepartureDate.ToString("dd/MM/yyyy");
    }
    public string ArrivalDate 
    {
        get => this._ticket.Flight.ArrivalDate.ToString("dd/MM/yyyy");
    }
    public double PricePaid
    {
        get => this._ticket.PricePaid;
    }

    public AdminTicketVM(Ticket ticket)
    {
        this._ticket = ticket;
    }
}
