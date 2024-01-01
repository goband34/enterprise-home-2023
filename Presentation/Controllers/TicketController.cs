using Microsoft.AspNetCore.Mvc;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Controllers;

public class TicketController : Controller
{
    private TicketDBRepository _ticketRepo;
    public TicketController(TicketDBRepository ticketRepository)
    {
        this._ticketRepo = ticketRepository;
    }

    public IActionResult Index()
    {
        var tickets = this._ticketRepo.GetTickets().Select(f => new TicketVM(f));
        ViewData["Tickets"] = tickets;
        return View();
    }
}
