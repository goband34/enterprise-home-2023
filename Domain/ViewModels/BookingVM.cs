using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace Domain.ViewModels;

public class BookingVM
{
    [Required(ErrorMessage = "You must select a flight")]
    public int FlightID { get; set; }

    [Required(ErrorMessage = "You must select a row")]
    public int Row { get; set; }

    [Required(ErrorMessage = "You must select a column")]
    public int Column { get; set; }

    [Required(ErrorMessage = "You must enter your passport number")]
    public string PassportNo { get; set; }
    public double PricePaid { get; set; }

    public Ticket ToTicket()
    {
        return new Ticket
        {
            Row = this.Row,
            Column = this.Column,
            FlightFK = this.FlightID,
            Passport = this.PassportNo,
            Cancelled = false
        };
    }
}
