using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace Presentation.ViewModels;

public class BookingVM
{
    [Required(ErrorMessage = "You must select a flight")]
    public int? FlightID { get; set; }

    [Required(ErrorMessage = "You must select a row")]
    [Presentation.Validators.RowValidator()]
    public int? Row { get; set; }

    [Required(ErrorMessage = "You must select a column")]
    public int? Column { get; set; }

    [Required(ErrorMessage = "You must enter your passport number")]
    public string? PassportNo { get; set; }

    public double PricePaid { get; set; }

    public Ticket? ToTicket()
    {
        if (this.Row.HasValue &&
            this.Column.HasValue &&
            this.FlightID.HasValue &&
            this.PassportNo != null)
        {
            return new Ticket
            {
                Row = this.Row.Value,
                Column = this.Column.Value,
                FlightFK = this.FlightID.Value,
                Passport = this.PassportNo,
                PricePaid = this.PricePaid,
                Cancelled = false
            };
        }

        return null;
    }
}
