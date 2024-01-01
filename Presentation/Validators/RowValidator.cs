using System.ComponentModel.DataAnnotations;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Validators;

public class RowValidator : ValidationAttribute
{
    public string GetErrorMessage() =>
        "Chosen row is outside the row range of the flight";

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        FlightDbRepository? _flightsRepository = (FlightDbRepository)validationContext.GetService(typeof(FlightDbRepository));
        if (_flightsRepository != null)
        {
            int? flightIdN = ((BookingVM)validationContext.ObjectInstance).FlightID;
            if (!flightIdN.HasValue)
            {
                return new ValidationResult("Cannot decide validity of row before choosing a flight");
            }
            int flightId = flightIdN.Value;
            var flight = _flightsRepository.GetFlight(flightId);
            if (flight != null && value != null)
            {
                if ((int)value >= 1 && (int)value <= flight.Rows)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            else
            {
                return new ValidationResult("Something went wrong while retrieving value from input");
            }
        }

        return new ValidationResult("Could not get the repository");
    }
}
