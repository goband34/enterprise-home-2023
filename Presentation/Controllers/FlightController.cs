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
        var flights =
            this._flightRepo
            .GetFlights()
            .Where(f => f.DepartureDate >= DateTime.Now)
            .Select(f => new FlightVM(f));
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
        if (!ModelState.IsValid)
        {
            if (booking.FlightID.HasValue)
            {
                var flightVM = new FlightVM(this._flightRepo.GetFlight(booking.FlightID.Value));
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

        var ticket = booking.ToTicket();

        if (ticket == null)
        {
            // TODO: Error handling
            return RedirectToAction("Index");
        }

        try
        {
            this._ticketRepo.Book(ticket);
            return RedirectToAction("Index");
        }
        catch (Exception e)
        {
            TempData["error"] = e.Message;
            return RedirectToAction("Book", new { id = booking.FlightID.Value });
        }
    }
}
