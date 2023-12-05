using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class Ticket
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; } 

    public int Rows { get; set; }
    public int Columns { get; set; }

    [ForeignKey("Flight")]
    public int FlightFK { get; set; }
    public virtual Flight Flight { get; set; } = null!;

    public string Passport { get; set; } = null!;

    public double PricePaid { get; set; }
    
    public bool Cancelled { get; set; }
}
