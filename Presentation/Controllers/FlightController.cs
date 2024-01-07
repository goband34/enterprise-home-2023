using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Domain.Models;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Controllers;

public class FlightController : Controller
{
    private FlightDbRepository _flightRepo;
    private ITicketRepository _ticketRepo;
    private UserManager<User> _userManager;

    public FlightController(FlightDbRepository flightRepository, ITicketRepository ticketRepository, UserManager<User> userManager)
    {
        this._flightRepo = flightRepository;
        this._ticketRepo = ticketRepository;
        this._userManager = userManager;
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
    public IActionResult Book(int id)
    {
        var flight = this._flightRepo.GetFlight(id);
        if (flight != null)
        {
            var user = this._userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            var flightVM = new FlightVM(flight);
            ViewData["FlightID"] = flightVM.ID;
            ViewData["FlightTitle"] = flightVM.FlightRoute;
            ViewData["FlightRows"] = flightVM.Rows;
            ViewData["FlightColumns"] = flightVM.Columns;
            ViewData["BookedSeats"] = flight.Tickets.Where(t => !t.Cancelled).Select(t => (t.Row,t.Column));
            ViewData["UserPassport"] = user?.PassportNumber;
            return View();
        }
        // TODO: Better error handling
        return View("Index");
    }

    [HttpPost]
    public IActionResult Book(BookingVM booking, [FromServices]IWebHostEnvironment host)
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

        try
        {
            var flight = this._flightRepo.GetFlight(booking.FlightID.Value);
            if (flight == null)
            {
                TempData["error"] = $"Trying to book a ticket for flight with id {booking.FlightID.Value} which does not exist";
                return RedirectToAction("Index");
            }

            var pricePaid = flight.WholesalePrice + (flight.WholesalePrice * flight.CommissionRate);
            booking.PricePaid = pricePaid;

            if (booking.PassportImage != null)
            {
                string uniqueId = Guid.NewGuid().ToString();
                string newFileName = $"{uniqueId}{Path.GetExtension(booking.PassportImage.FileName)}";
                string relativePath = $"PassportImages/{newFileName}";
                string path = $"{host.WebRootPath}/{relativePath}";
                // Ensure directory exists
                System.IO.Directory.CreateDirectory($"{host.WebRootPath}/PassportImages");

                using (FileStream fileStream = new FileStream(path, FileMode.CreateNew))
                {
                    booking.PassportImage.CopyTo(fileStream);
                    fileStream.Flush();
                }

                booking.SetPassportImagePath(relativePath);
            }

            var ticket = booking.ToTicket();

            if (ticket == null)
            {
                // TODO: Error handling
                return RedirectToAction("Index");
            }

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
