using Domain.Models;

namespace Presentation.ViewModels;

public class AdminTicketVM
{
    private Ticket _ticket;

    public int ID
    {
        get => this._ticket.ID;
    }
    public string Route 
    {
        get
        {
            var flight = this._ticket.Flight;
            return $"{flight.CountryFrom}-{flight.CountryTo}";
        }
    }
    public int Row
    {get => this._ticket.Row;
    }
    public int Column
    {
        get => this._ticket.Column;
    }
    public string Dates
    {
        get
        {
            string departureDate = this._ticket.Flight.DepartureDate.ToString("dd/MM/yyyy");
            string arrivalDate = this._ticket.Flight.ArrivalDate.ToString("dd/MM/yyyy");
            return $"{departureDate} - {arrivalDate}";
        }
    }
    public double PricePaid
    {
        get => this._ticket.PricePaid;
    }
    public string PassportNo
    {
        get => this._ticket.Passport;
    }
    public bool HasImage
    {
        get => this._ticket.PassportImagePath != null && this._ticket.PassportImagePath != "";
    }
    public string PassportImagePath
    {
        get => $"/{this._ticket.PassportImagePath}";
    }
    public bool Cancelled
    {
        get => this._ticket.Cancelled;
    }

    public AdminTicketVM(Ticket ticket)
    {
        this._ticket = ticket;
    }
}
