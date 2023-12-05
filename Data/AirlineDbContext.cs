namespace Data;

using Domain;
using Microsoft.EntityFrameworkCore;

public class AirlineDbContext : DbContext
{
    public AirlineDbContext(DbContextOptions<AirlineDbContext> options): base(options)
    {
    }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Flight> Flights { get; set; }
}
