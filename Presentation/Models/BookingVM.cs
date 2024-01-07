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
    [Presentation.Validators.ColumnValidator()]
    public int? Column { get; set; }

    [Required(ErrorMessage = "You must enter your passport number")]
    public string? PassportNo { get; set; }

    [Required(ErrorMessage = "You must upload a picture of your passport")]
    public IFormFile? PassportImage { get; set; }

    private string? PassportImagePath { get; set; }

    public double PricePaid { get; set; }

    public void SetPassportImagePath(string path)
    {
        this.PassportImagePath = path;
    }

    public Ticket? ToTicket()
    {
        if (this.Row.HasValue &&
            this.Column.HasValue &&
            this.FlightID.HasValue &&
            this.PassportNo != null &&
            this.PassportImagePath != null
        )
        {
            return new Ticket
            {
                Row = this.Row.Value,
                Column = this.Column.Value,
                FlightFK = this.FlightID.Value,
                Passport = this.PassportNo,
                PassportImagePath = this.PassportImagePath,
                PricePaid = this.PricePaid,
                Cancelled = false
            };
        }

        return null;
    }
}
