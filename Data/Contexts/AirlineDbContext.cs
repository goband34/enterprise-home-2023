using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Domain.Models;

namespace Data.Contexts;

public class AirlineDbContext : IdentityDbContext<User> 
{
    public AirlineDbContext(DbContextOptions<AirlineDbContext> options): base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Flight>().HasData(
            new Flight
            {
                ID = 1,
                Rows = 5,
                Columns = 5,
                DepartureDate = new DateTime(2023, 12, 26),
                ArrivalDate = new DateTime(2023, 12, 26),
                CountryFrom = "Italy",
                CountryTo = "France",
                WholesalePrice = 50.0,
                CommissionRate = 0.5
            },
            new Flight
            {
                ID = 2,
                Rows = 7,
                Columns = 5,
                DepartureDate = new DateTime(2022, 02, 02),
                ArrivalDate = new DateTime(2023, 02, 04),
                CountryFrom = "Spain",
                CountryTo = "Japan",
                WholesalePrice = 650.0,
                CommissionRate = 2.0 
            },
            new Flight
            {
                ID = 3,
                Rows = 10,
                Columns = 4,
                DepartureDate = new DateTime(2024, 08, 25),
                ArrivalDate = new DateTime(2024, 08, 26),
                CountryFrom = "Australia",
                CountryTo = "Russia",
                WholesalePrice = 450.0,
                CommissionRate = 1.5 
            },
            new Flight
            {
                ID = 4,
                Rows = 1,
                Columns = 1,
                DepartureDate = new DateTime(2024, 03, 21),
                ArrivalDate = new DateTime(2024, 03, 22),
                CountryFrom = "Moldova",
                CountryTo = "Germany",
                WholesalePrice = 300.0,
                CommissionRate = 0.02
            }
        );

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }

    public DbSet<Ticket>? Tickets { get; set; }
    public DbSet<Flight>? Flights { get; set; }
}
