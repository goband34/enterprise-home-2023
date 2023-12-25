using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

class TicketController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
