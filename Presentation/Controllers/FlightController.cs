using Microsoft.AspNetCore.Mvc;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Controllers;

public class FlightController : Controller
{
    private FlightDbRepository _flightRepo;
    private TicketDBRepository _ticketRepo;

    public FlightController(FlightDbRepository flightRepository, TicketDBRepository ticketRepository)
    {
        this._flightRepo = flightRepository;
        this._ticketRepo = ticketRepository;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var flights = this._flightRepo.GetFlights().Select(f => new FlightVM(f));
        ViewData["Flights"] = flights;
        return View();
    }

    [HttpGet]
    public IActionResult Book(int? id)
    {
        if (id.HasValue)
        {
            var flight = this._flightRepo.GetFlight(id.Value);
            if (flight != null)
            {
                var flightVM = new FlightVM(flight);
                ViewData["FlightID"] = flightVM.ID;
                ViewData["FlightTitle"] = flightVM.FlightRoute;
                ViewData["FlightRows"] = flightVM.Rows;
                ViewData["FlightColumns"] = flightVM.Columns;
                return View();
            }
            // TODO: Better error handling
            return View("Index");
        }
        // TODO: Better error handling
        return View("Index");
    }

    [HttpPost]
    public IActionResult Book(BookingVM booking)
    {
        var flightVM = new FlightVM(this._flightRepo.GetFlight(booking.FlightID.Value));
        if (!ModelState.IsValid)
        {
            if (booking.FlightID.HasValue)
            {
                ViewData["FlightID"] = flightVM.ID;
                ViewData["FlightTitle"] = flightVM.FlightRoute;
                ViewData["FlightRows"] = flightVM.Rows;
                ViewData["FlightColumns"] = flightVM.Columns;
                return View();
            }
            else
            {
                // TODO: Better error handling
                return RedirectToAction("Index");
            }
        }
        else
        {
            var ticket = booking.ToTicket();
            if (ticket != null)
            {
                this._ticketRepo.Book(ticket);

                return RedirectToAction("Index");
            }
            else
            {
                // TODO: Error handling
                return RedirectToAction("Index");
            }
        }
    }
}
