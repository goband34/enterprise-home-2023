using Microsoft.AspNetCore.Mvc;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Controllers;

public class AdminController : Controller
{
    private FlightDbRepository _flightRepo;
    private TicketDBRepository _ticketRepo;

    public AdminController(FlightDbRepository flightRepo, TicketDBRepository ticketRepo)
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

        var tickets = flight.Tickets.Where(t => !t.Cancelled).Select(t => new AdminTicketVM(t));
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
            return RedirectToAction("Tickets");
        }
        if (ticket.Cancelled)
        {
            TempData["error"] = $"Ticket with id {id} has been cancelled";
            return RedirectToAction("Tickets");
        }

        ViewData["Ticket"] = new AdminTicketVM(ticket);
        return View();
    }
}
