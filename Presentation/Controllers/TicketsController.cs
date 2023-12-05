using Microsoft.AspNetCore.Mvc;
using Data;
using Domain;

namespace Presentation.Controllers;

class TicketsController: Controller
{
    private FlightDbRepository _flightRepository;
    private TicketDBRepository _ticketRepository;

    public TicketsController(FlightDbRepository _flightRepository, TicketDBRepository _ticketRepository)
    {
	    this._flightRepository = _flightRepository;
        this._ticketRepository = _ticketRepository;
    }
    
    public IActionResult Index()
    {
	    return View();
    }

    public IActionResult Flights()
    {
        var flights = _flightRepository.GetCurrentFlights();
        return View(flights);
    }

    public IActionResult BookFlight(int flightId)
    {
        var flight = _flightRepository.GetFlight(flightId);
	    return View(flight);
    }

    public IActionResult? BookFlight()
    {
        // TODO: Use ViewModel
        return null;
    }
}
