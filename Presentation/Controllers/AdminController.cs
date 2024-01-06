using Microsoft.AspNetCore.Mvc;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Controllers;

public class AdminController : Controller
{
    private FlightDbRepository _flightRepo;

    public AdminController(FlightDbRepository flightRepo)
    {
        this._flightRepo = flightRepo;
    }

    public IActionResult Flights()
    {
        var flights = this._flightRepo.GetFlights().Select(f => new FlightVM(f));
        ViewData["Flights"] = flights;
        return View();
    }

    public IActionResult Tickets(int flightId)
    {
        var tickets = this._flightRepo.GetFlight(flightId)?.Tickets.Select(t => new AdminTicketVM(t));
        ViewData["Tickets"] = tickets;
        return View();
    }
}
