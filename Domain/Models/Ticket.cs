using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Ticket
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; } 

    public int Row { get; set; }
    public int Column { get; set; }

    [ForeignKey("Flight")]
    public int FlightFK { get; set; }
    public virtual Flight Flight { get; set; }

    public string Passport { get; set; }

    public string PassportImagePath { get; set; }

    public double PricePaid { get; set; }
    
    public bool Cancelled { get; set; }
}
