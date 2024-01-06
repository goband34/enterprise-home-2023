using Microsoft.EntityFrameworkCore;
using Data.Contexts;
using Data.Repositories;
using Domain.Models;

namespace Presentation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        builder.Services
            .AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<AirlineDbContext>();
        builder.Services.AddRazorPages();
        builder.Services.AddDbContext<AirlineDbContext>(options =>
            options.UseSqlite(connectionString));
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddScoped<FlightDbRepository>();

        // Ensure directory exists
        System.IO.Directory.CreateDirectory($"{builder.Environment.ContentRootPath}/JsonData");
        string jsonTicketsPath = $"{builder.Environment.ContentRootPath}/JsonData/tickets.json";
        // builder.Services
        // .AddScoped<ITicketRepository, TicketFileRepository>(
        // options =>
        // new TicketFileRepository(jsonTicketsPath, options.GetRequiredService<FlightDbRepository>())
        // );
        builder.Services.AddScoped<ITicketRepository, TicketDBRepository>();

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.MapRazorPages();
        app.Run();
    }
}
