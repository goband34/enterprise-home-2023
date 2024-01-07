using Domain.Models;
using Data.Repositories;
using System.Text.Json;

namespace Data.Repositories;

public class TicketFileRepository : ITicketRepository
{
    private string jsonFilePath;
    private FlightDbRepository _flightRepo;

    public TicketFileRepository(string path, FlightDbRepository flightRepo)
    {
        this._flightRepo = flightRepo;
        this.jsonFilePath = path;

        // if it doesn't exist, create it
        if (!System.IO.File.Exists(path))
        {
            using (var f = System.IO.File.Create(path))
            {
                f.Close();
            }
        }
    }

    public IQueryable<Ticket>? GetTickets()
    {
        string fileContent = System.IO.File.ReadAllText(this.jsonFilePath);
        if (fileContent == "")
        {
            return new List<Ticket>().AsQueryable();
        }

        try
        {
            List<Ticket>? tickets = JsonSerializer.Deserialize<List<Ticket>>(fileContent);
            return tickets?.AsQueryable();
        }
        catch
        {
            return new List<Ticket>().AsQueryable();
        }
    }

    public Ticket? GetTicket(int id)
    {
        return this.GetTickets()?.SingleOrDefault<Ticket>(t => t.ID == id);
    }

    public void Book(Ticket ticket)
    {
        if (this._flightRepo.GetFlight(ticket.FlightFK)?.DepartureDate < DateTime.Now)
        {
            throw new Exception("Trying to book a flight that was in the past");
        }

        var existingTicket =
            this.GetTickets()
            ?.Where(t => t.FlightFK == ticket.FlightFK && t.Row == ticket.Row && t.Column == ticket.Column && !ticket.Cancelled)
            .FirstOrDefault();

        if (existingTicket != null)
        {
            throw new Exception("Trying to book a ticket that's occupied");
        }

        int id = 1;
        if (this.GetTickets()?.Count() > 0)
        {
            int? newId = this.GetTickets()?.Select(t => t.ID).Max();
            id = newId.Value + 1;
        }
        ticket.ID = id;

        var currentTickets = this.GetTickets()?.ToList() ?? new List<Ticket>();
        currentTickets.Add(ticket);
        var json = JsonSerializer.Serialize(currentTickets);
        System.IO.File.WriteAllText(this.jsonFilePath, json);
    }

    public void Cancel(Ticket ticket)
    {
        var currentTickets = this.GetTickets()?.ToList();
        if (currentTickets == null)
        {
            throw new Exception("No tickets to cancel");
        }

        int ticketToModifyIndex = currentTickets.FindIndex(t => t.ID == ticket.ID);
        if (ticketToModifyIndex == -1)
        {
            throw new Exception("Trying to cancel a non-existant ticket");
        }

        currentTickets[ticketToModifyIndex].Cancelled = true;
        var json = JsonSerializer.Serialize(currentTickets);
        System.IO.File.WriteAllText(this.jsonFilePath, json);
    }
}
