using Microsoft.AspNetCore.Mvc;

namespace HomeAssignment.Controllers;

public class FlightController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Book(int? id)
    {
        ViewData["FlightId"] = id;
        return View("BookFlight");
    }
}
