using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class TicketController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
