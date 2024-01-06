using Microsoft.AspNetCore.Mvc;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Controllers;

public class TicketController : Controller
{
    private ITicketRepository _ticketRepo;
    public TicketController(ITicketRepository ticketRepository)
    {
        this._ticketRepo = ticketRepository;
    }

    public IActionResult Index()
    {
        var tickets = this._ticketRepo.GetTickets()?.Select(f => new TicketVM(f)) ?? new List<TicketVM>().AsQueryable();
        ViewData["Tickets"] = tickets;
        return View();
    }
}
