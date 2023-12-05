using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class Flight 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public int Rows { get; set; }
    public int Columns { get; set; }

    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }

    public string CountryFrom { get; set; } = null!;
    public string CountryTo { get; set; } = null!;

    public double WholesalePrice { get; set; }
    public double CommissionRate { get; set; }
}
