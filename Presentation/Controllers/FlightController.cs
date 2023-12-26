using Microsoft.AspNetCore.Mvc;
using Data.Repositories;
using Domain.ViewModels;

namespace Presentation.Controllers;

public class FlightController : Controller
{
    private FlightDbRepository _flightRepo;

    public FlightController(FlightDbRepository flightRepository)
    {
        this._flightRepo = flightRepository;
    }

    public IActionResult Index()
    {
        var flights = this._flightRepo.GetFlights().Select(f => new FlightVM(f));
        ViewData["Flights"] = flights;
        return View();
    }

    public IActionResult Book(int? id)
    {
        var flights = this._flightRepo.GetFlights().Select(f => new FlightVM(f));
        ViewData["Flights"] = flights;
        ViewData["FlightId"] = id;
        return View("BookFlight");
    }

    [HttpPost]
    public IActionResult BookFlight(BookingVM booking)
    {
        if (!ModelState.IsValid)
        {
            return this.Book(booking.FlightID);
        }
        else
        {
            return RedirectToAction("Index");
        }
    }
}
