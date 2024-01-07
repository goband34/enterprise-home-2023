using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Domain.Models;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Controllers;

public class TicketController : Controller
{
    private ITicketRepository _ticketRepo;
    private UserManager<User> _userManager;

    public TicketController(ITicketRepository ticketRepository, UserManager<User> userManager)
    {
        this._ticketRepo = ticketRepository;
        this._userManager = userManager;
    }

    public ActionResult Index()
    {
        var user = this._userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
        if (user == null)
        {
            TempData["error"] = "Must be logged in to view this page";
            return RedirectToAction("Index", "Index");
        }

        var tickets = this._ticketRepo.GetTickets()?.Where(t => !t.Cancelled && t.Passport == user.PassportNumber).Select(f => new TicketVM(f)) ?? new List<TicketVM>().AsQueryable();
        ViewData["Tickets"] = tickets;
        return View();
    }

    public IActionResult CancelTicket(int id)
    {
        var ticket = this._ticketRepo.GetTicket(id);
        if (ticket == null)
        {
            TempData["error"] = "Trying to cancel a non-existant ticket";
            return RedirectToAction("Index");
        }

        try
        {
            this._ticketRepo.Cancel(ticket);
        }
        catch (Exception e)
        {
            TempData["error"] = $"Failed to cancel with exception: {e.Message}";
        }

        return RedirectToAction("Index");
    }
}
