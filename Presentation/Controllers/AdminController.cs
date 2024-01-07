using Microsoft.AspNetCore.Mvc;
using Data.Repositories;
using Presentation.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Presentation.Controllers;

[Authorize(Roles = "Administrator")]
public class AdminController : Controller
{
    private FlightDbRepository _flightRepo;
    private ITicketRepository _ticketRepo;

    public AdminController(FlightDbRepository flightRepo, ITicketRepository ticketRepo)
    {
        this._flightRepo = flightRepo;
        this._ticketRepo = ticketRepo;
    }
    
    public IActionResult Flights()
    {
        var flights = this._flightRepo.GetFlights().Select(f => new FlightVM(f));
        ViewData["Flights"] = flights;
        return View();
    }

    [HttpGet]
    public IActionResult Tickets(int id)
    {
        var flight = this._flightRepo.GetFlight(id);
        if (flight == null)
        {
            TempData["error"] = $"No flight found with ID {id}";
            return RedirectToAction("Flights");
        }

        var tickets = flight.Tickets.Select(t => new AdminTicketVM(t));
        ViewData["Tickets"] = tickets;
        return View();
    }

    [HttpGet]
    public IActionResult TicketInfo(int id)
    {
        var ticket = this._ticketRepo.GetTicket(id);
        if (ticket == null)
        {
            TempData["error"] = $"No ticket found with ID {id}";
            return RedirectToAction("Flights");
        }

        ViewData["Ticket"] = new AdminTicketVM(ticket);
        return View();
    }
}
