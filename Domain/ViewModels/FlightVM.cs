using Domain.Models;

namespace Domain.ViewModels;

public class FlightVM
{
    private Flight _flight;

    public int ID
    {
        get => _flight.ID;
    }
    public string FlightRoute
    {
        get => $"{this._flight.CountryFrom}-{this._flight.CountryTo}";
    }
    public string DepartureDate
    {
        get => this._flight.DepartureDate.ToString("dd/MM/yyyy");
    }
    public string ArrivalDate
    {
        get => this._flight.ArrivalDate.ToString("dd/MM/yyyy");
    }
    public double Price
    {
        get => this._flight.WholesalePrice + (this._flight.WholesalePrice * this._flight.CommissionRate);
    }

    public FlightVM(Flight flight)
    {
        this._flight = flight;
    }
}
